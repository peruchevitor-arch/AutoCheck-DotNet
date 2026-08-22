using System;
using Veiculos;
using Vistoria;
using Motor;
using Carros;
using Motos;
using Caminhoes;

// ---- SISTEMA DE VISTORIA DE VEICULOS, auto check ---- \\

List<Veiculo> listaVeiculos = new List<Veiculo>();

while (true)
{
    Console.WriteLine(" === AutoCheck - sistema de vistoria de veiculos === ");
    Console.WriteLine(" 1 - Realizar Nova Vistoria: ");
    Console.WriteLine(" 2 - Exibir Relatório das Vistorias: ");
    Console.WriteLine(" 0 - Sair ");
    int opcao = int.Parse(Console.ReadLine());
    if(opcao == 0)
    {
        return;
    } else if (opcao == 1)
    {
        Console.Clear();
        Console.WriteLine(" Qual o tipo de veiculo? ");
        Console.WriteLine(" 1 - carro ");
        Console.WriteLine(" 2 - moto ");
        Console.WriteLine(" 3 - caminhão ");
        int tipo = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine(" Qual a marca ? ");
        string Marca = Console.ReadLine();
        Console.WriteLine(" Qual o modelo ? ");
        string Modelo = Console.ReadLine();
        Console.WriteLine(" Qual o ano ? ");
        int Ano = int.Parse(Console.ReadLine());
        Console.WriteLine(" Qual a quilometragem ? ");
        int Quilometragem = int.Parse(Console.ReadLine());

        if (tipo == 1)
        {
            Console.WriteLine("Quantas portas o carro tem ?");
            int NumeroPortas = int.Parse(Console.ReadLine());
            Veiculo veiculo = new Carro(Marca,Modelo,Ano,Quilometragem,NumeroPortas);
            List<string> checklist = veiculo.ObterChecklistObrigatorio();
            foreach(string item in checklist)
            {
                Console.WriteLine(" qual o status de : " + item);
                Console.WriteLine(" 1 - Bom");
                Console.WriteLine(" 2 - Regular");
                Console.WriteLine(" 3 - Ruim");
                int StatusItem = int.Parse(Console.ReadLine());
                string Status = "";
                if (StatusItem == 1)
                {
                    Status = "Bom";
                } else if (StatusItem == 2)
                {
                    Status = "Regular";
                } else if (StatusItem == 3)
                {
                    Status = "Ruim";
                }
                veiculo.AdicionarItemVistoriado(item,Status);
            }
            Console.WriteLine("Vistoria realizada com sucesso !");
            listaVeiculos.Add(veiculo);
        } else if (tipo == 2)
        {
            Console.Write("quantas cilindradas a moto tem ?");
            int Cilindradas = int.Parse(Console.ReadLine());
            Veiculo veiculo = new Moto(Marca,Modelo,Ano,Quilometragem,Cilindradas);
            foreach(string item in veiculo.ObterChecklistObrigatorio())
            {
                Console.WriteLine(" qual o status de : " + item);
                Console.WriteLine(" 1 - Bom");
                Console.WriteLine(" 2 - Regular");
                Console.WriteLine(" 3 - Ruim");
                int StatusItem = int.Parse(Console.ReadLine());
                string Status = "";
                if (StatusItem == 1)
                {
                    Status = "Bom";
                } else if (StatusItem == 2)
                {
                    Status = "Regular";
                } else if (StatusItem == 3)
                {
                    Status = "Ruim";
                }
                veiculo.AdicionarItemVistoriado(item,Status);
            }
            listaVeiculos.Add(veiculo);
        } else if (tipo == 3)
        {
            Console.WriteLine("quantos eixos o caminhão tem ?");
            int QuantidadeEixos = int.Parse(Console.ReadLine());
            Console.WriteLine("qual a capacidade do caminhão toneladas ?");
            double CapacidadeCargaToneladas = int.Parse(Console.ReadLine());
            Veiculo veiculo = new Caminhao(Marca,Modelo,Ano,Quilometragem,QuantidadeEixos,CapacidadeCargaToneladas);
            foreach(string item in veiculo.ObterChecklistObrigatorio())
            {
                Console.WriteLine(" qual o status de : " + item);
                Console.WriteLine(" 1 - Bom");
                Console.WriteLine(" 2 - Regular");
                Console.WriteLine(" 3 - Ruim");
                int StatusItem = int.Parse(Console.ReadLine());
                string Status = "";
                if (StatusItem == 1)
                {
                    Status = "Bom";
                } else if (StatusItem == 2)
                {
                    Status = "Regular";
                } else if (StatusItem == 3)
                {
                    Status = "Ruim";
                }
                veiculo.AdicionarItemVistoriado(item,Status);
            }
            listaVeiculos.Add(veiculo);
        }

    } else if (opcao == 2)
    {
        
        Console.Clear();
        Console.WriteLine("Processamento Vistoria - Relatorio");
        if (listaVeiculos.Count == 0)
        {
            Console.WriteLine("Nenhuma vistoria realizada até o momento.");
        }
        else {
        foreach (Veiculo veiculo in listaVeiculos)
        {
            MotorVistoria motor = new MotorVistoria();
            Console.WriteLine("> dados do veiculo");
            Console.WriteLine("Tipo = " + veiculo.GetType().Name);
            Console.WriteLine("Modelo = " + veiculo.Modelo);
            Console.WriteLine("ano = " + veiculo.Ano + " || quilometragem = " + veiculo.Quilometragem);
            if (veiculo.GetType().Name == "Carro")
            {
                Console.WriteLine("Quantidade Portas = " + ((Carro)veiculo).NumeroPortas);
            } else if (veiculo.GetType().Name == "Moto"){
                Console.WriteLine("Cilindradas = " + ((Moto)veiculo).Cilindradas);
            } else if (veiculo.GetType().Name == "Caminhao"){
                Console.WriteLine("Capacidade carga toneladas = " + ((Caminhao)veiculo).CapacidadeCargaToneladas);
                Console.WriteLine("Quantidade Eixos = " + ((Caminhao)veiculo).QuantidadeEixos);
            }
            Console.WriteLine("> Avaliação dos itens inspecionados :");
            
            motor.Relatorio(veiculo);

            Console.WriteLine("> Relatorio de manutenção e recomendações :");
            motor.RelatorioPendencias(veiculo);

            Console.WriteLine("> Resumo da pontuação :");

            Console.WriteLine("Pontuação Atingida: " + motor.PontuacaoTotal(veiculo) + " / " + (veiculo.VistoriaRealizada.Count * 10));
            Console.WriteLine("Percentual de Aprovação: " + motor.Percentual(veiculo) + "%");
            if(motor.PossuiPendencias(veiculo))
            {
                Console.WriteLine("O veículo possui pendências.");
            }
            else
            {
                Console.WriteLine("Nenhuma pendência encontrada.");
            }
            Console.WriteLine("Classificação Final: : " + motor.Classificacao(veiculo));
        }
        }
    } else
    {
        Console.WriteLine("opção invalida");
    }
}

