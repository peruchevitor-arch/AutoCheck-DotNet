using Veiculos;
namespace Motos
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }
        public Moto(string Marca,string Modelo,int Ano,int Quilometragem,int Cilindradas) : base(Marca, Modelo, Ano, Quilometragem)
        {
            this.Cilindradas = Cilindradas;
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            List<string> checklist = base.ObterChecklistObrigatorio();

            checklist.Add("Kit Transmissão/Corrente");
            checklist.Add("Manetes de Freio/Embreagem");
            checklist.Add("Pezinho Lateral");

            return checklist;
        }
    }
}