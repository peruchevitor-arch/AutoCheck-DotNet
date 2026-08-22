
namespace Vistoria
{
    public class ItemVistoria
    {
        public string Nome { get; set;}
        public string Status { get; set;}
        public ItemVistoria(string Nome,string Status)
        {
            if(Status == "Bom" || Status == "Regular" || Status == "Ruim")
            {
                this.Status = Status;
                this.Nome = Nome;
            }
        }
    }
}