using Vistoria;
namespace Veiculos
{
    public abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Quilometragem { get; set;}
        public List<ItemVistoria> VistoriaRealizada { get; set;}
        public Veiculo(string Marca,string Modelo,int Ano,int Quilometragem)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.Quilometragem = Quilometragem;

            VistoriaRealizada = new List<ItemVistoria>();
        }
        public void AdicionarItemVistoriado(string Nome,string Status)
        { 
            ItemVistoria item = new ItemVistoria(Nome, Status);

            VistoriaRealizada.Add(item);
        }
        public virtual List<string> ObterChecklistObrigatorio()
        {
              return new List<string>
            {
                "Nível de Óleo do Motor",
                "Bateria e Sistema Elétrico",
                "Documentação Regularizada"
            };
        }

    }
}