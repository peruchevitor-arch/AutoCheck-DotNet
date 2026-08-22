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
            if (percentual >= 90)
            {
                return "Aprovado com Excelência";
            }
            else if (percentual >= 60)
            {
                return "Aprovado com Apontamentos";
            }

            return "Reprovado na Vistoria";
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
        public void Relatorio(Veiculo veiculo)
        {
            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                Console.WriteLine(item.Nome + " -- status = " + item.Status + " -- pontuação = " + PontuacaoPorItem(item.Status));
            }
        }
        public int PontuacaoTotal(Veiculo veiculo)
        {
            int pontuacaoTotal = 0;

            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                pontuacaoTotal += PontuacaoPorItem(item.Status);
            }

            return pontuacaoTotal;
        }
        public bool PossuiPendencias(Veiculo veiculo)
        {
            foreach (ItemVistoria item in veiculo.VistoriaRealizada)
            {
                if (item.Status == "Regular" || item.Status == "Ruim")
                {
                    return true;
                }
            }

            return false;
        }
    }
}