using Veiculos;
namespace Caminhoes
{
    public class Caminhao : Veiculo
    {
        public int QuantidadeEixos { get; set; }
        public double CapacidadeCargaToneladas { get; set; }
        public Caminhao(string Marca,string Modelo,int Ano,int Quilometragem,int QuantidadeEixos,double CapacidadeCargaToneladas) : base(Marca, Modelo, Ano, Quilometragem)
        {
            this.CapacidadeCargaToneladas = CapacidadeCargaToneladas;
            this.QuantidadeEixos = QuantidadeEixos;
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = base.ObterChecklistObrigatorio();

            checklist.Add("Tacógrafo");
            checklist.Add("Sistema de Freios a Ar");
            checklist.Add("Trava e Lona da Caçamba");

            return checklist;
        }
    }
}