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
            List<string> checklist = base.ObterChecklistObrigatorio();

            checklist.Add("Estepe e Macaco");
            checklist.Add("Triângulo de Sinalização");
            checklist.Add("Ar Condicionado Funcional");

            return checklist;
        }
    }
}