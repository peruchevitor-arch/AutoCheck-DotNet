using Veiculos;
namespace Carros
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }
        public Carro(string Marca,string Modelo,int Ano,int Quilometragem,int NumeroPortas) : base(Marca, Modelo, Ano, Quilometragem)
        {
            this.NumeroPortas = NumeroPortas;
        }
        public override List<string> ObterChecklistObrigatorio()
        {
            return new List<string>
            {
                "Estepe e Macaco",
                "Triângulo de Sinalização",
                "Ar Condicionado Funcional"
            };
        }
    }
}