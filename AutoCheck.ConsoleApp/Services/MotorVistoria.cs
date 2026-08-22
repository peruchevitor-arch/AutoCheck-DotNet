using Veiculos;
using Vistoria;

namespace Motor
{
    public class MotorVistoria
    {
        public int PontuacaoPorItem(string Status)
        {
            if (Status == "Bom")
            {
                return 10;
            } else if (Status == "Regular")
            {
                return 5;
            } else
            {
                return 0;
            }
        }
        public double Percentual(Veiculo veiculo)
        {
            int pontos = 0;
            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                pontos += PontuacaoPorItem(item.Status);
            }
            int maxima = veiculo.VistoriaRealizada.Count * 10;

            return maxima == 0 ? 0 : (double)pontos / maxima * 100;
        }
        public string Classificacao(Veiculo veiculo)
        {
            double percentual = Percentual(veiculo);
            if(percentual >= 90 && percentual <= 100)
            {
                return "Aprovado com Excelência";
            } else if(percentual >= 60 && percentual < 89)
            {
                return "Aprovado com Apontamentos";
            } else if(percentual >= 0 && percentual < 59)
            {
                return "Reprovado";
            }
        }
        public void RelatorioPendencias(Veiculo veiculo)
        {
            Console.WriteLine("🔴 ITENS CRÍTICOS / REPROVADOS:");

            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                if (item.Status == "Ruim")
                {
                    Console.WriteLine("- " + item.Nome + ": Exigem troca/reparo obrigatório.");
                }
            }

            Console.WriteLine("🟡 ITENS DE ATENÇÃO:");

            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                if (item.Status == "Regular")
                {
                    Console.WriteLine("- " + item.Nome + ": Exigem revisão preventiva.");
                }
            }
        }
        public void Recomendacoes(Veiculo veiculo)
        {
            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                    if (item.Status == "Ruim")
            {
                Console.WriteLine($"{item.Nome}: realizar troca ou reparo obrigatório.");
            }
            else if (item.Status == "Regular")
            {
                Console.WriteLine($"{item.Nome}: realizar revisão preventiva.");
            }
            }
        }
        public void GerarRelatorio(Veiculo veiculo)
        {
            Console.WriteLine("> Avaliação dos itens inspecionados :");
            Recomendacoes(veiculo);
        }
    }
}