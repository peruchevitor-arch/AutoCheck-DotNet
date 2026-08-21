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
            return new List<string>
            {
                "Kit Transmissão/Corrente",
                "Manetes de Freio/Embreagem",
                "Pezinho Lateral"
            };
        }
    }
}