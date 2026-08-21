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
            return new List<string>
            {
                "Kit Transmissão/Corrente",
                "Manetes de Freio/Embreagem",
                "Pezinho Lateral"
            };
        }
    }
}