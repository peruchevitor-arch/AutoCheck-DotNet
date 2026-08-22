# AutoCheck-DotNet
- nome : Vitor Peruch
  
-> oque esse projeto faz?
  Realiza uma vistoria, avalia cada item do veículo, calcula a pontuação, identifica pendências e mostra um relatório final com a classificação do veículo.
  O AutoCheck é um sistema de vistoria de veículos desenvolvido em C#.Ele permite realizar uma vistoria em diferentes tipos de veículos,avaliando itens específicos de cada   categoria.
-> Como funciona?

Ao iniciar o programa, é exibido um menu com 3 opções:

1. Realizar Nova Vistoria
2. Exibir Relatório das Vistorias
0. Sair

-> 1 - Realizar Nova Vistoria

O sistema solicita os dados do veículo, como:

- Marca
- Modelo
- Ano
- Quilometragem

Depois, dependendo do tipo de veículo, são solicitados dados específicos,
como quantidade de portas para carros, cilindradas para motos e quantidade
de eixos e capacidade de carga para caminhões.

Em seguida, o sistema apresenta uma lista de itens para inspeção.
Cada item pode receber um dos seguintes status:

- Bom
- Regular
- Ruim

->2 - Exibir Relatório das Vistorias

O sistema mostra as vistorias realizadas e apresenta:

- Dados do veículo
- Itens avaliados
- Status de cada item
- Pontuação obtida
- Percentual de aprovação
- Pendências encontradas
- Classificação final do veículo

A pontuação funciona da seguinte maneira:

- Bom = 10 pontos
- Regular = 5 pontos
- Ruim = 0 pontos

No final, o veículo recebe uma classificação:

- 90% a 100%: Aprovado com Excelência
- 60% a 89%: Aprovado com Apontamentos
- 0% a 59%: Reprovado na Vistoria
->Conceitos utilizados

Durante o desenvolvimento foram utilizados conceitos de:

- Classes e objetos
- Construtores
- Herança
- Polimorfismo
- Encapsulamento
- Listas (`List<T>`)
- Estruturas `if/else`
- Laços `while` e `foreach`
- Métodos
- Tipos `string`, `int`, `double` e `bool`

->Como executar

Clone o repositório e entre na pasta do projeto:

```bash
cd AutoCheck.ConsoleApp
