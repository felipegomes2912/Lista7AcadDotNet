namespace Lista7AcadDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1
            /*
            Console.Write("Digite a capa (dura ou normal): ");
            string capa = Console.ReadLine();
            Console.Write("Digite a faixa etária do livro: ");
            int faixaEtaria = int.Parse(Console.ReadLine());
            Console.Write("Digite o tema do livro: ");
            string tema = Console.ReadLine();

            Livro livro = new Livro(capa, tema, faixaEtaria);

            Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.WriteLine("Dados informados :\nFaixa etária: " + livro.faixaEtaria + "\nTema: " + livro.tema + "\nCapa: " + livro.capa);
            */



            //Exercício 2
            /*

            int peso, altura;
            string corDosOlhos, corDoCabelo;

            Console.Write("Digite a altura: ");
            altura = int.Parse(Console.ReadLine());
            Console.Write("Digite o peso: ");
            peso = int.Parse(Console.ReadLine());
            Console.Write("Digite a cor dos olhos: ");
            corDosOlhos = Console.ReadLine();
            Console.Write("Digite a cor do cabelo: ");
            corDoCabelo = Console.ReadLine();
            Console.WriteLine("---------------------");

            Pessoa pessoa = new Pessoa(altura, peso, corDosOlhos, corDoCabelo);

            pessoa.getPeso();
            pessoa.getCorDoCabelo();
            pessoa.getAltura();
            pessoa.getCorDosOlhos();
            */



            //Exercício 3
            /*
            Cliente cliente = new Cliente();
            Carro carro = new Carro(10.2, "123abc123", "Honda", "Verde");
            Aluguel aluguel = new Aluguel(carro, "07/10/2022", "10/10/2022", cliente);

            while (true)
            {
                Console.WriteLine("1 - Saber a placa do carro");
                Console.WriteLine("2 - Saber a cor do carro");
                Console.WriteLine("3 - Saber o consumo do carro");
                Console.WriteLine("4 - Saber o fabricante do carro");
                Console.WriteLine("5 - Resumo das informações");
                Console.WriteLine("0 - Sair do programa");
                Console.WriteLine();
                Console.Write("Digite uma das opções acima: ");
                int op = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("-------------------------");

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Programa encerrado.");
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Placa do carro: " + aluguel.carro.getPlaca());
                        Console.WriteLine("-------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Cor do carro: " + carro.getCor());
                        Console.WriteLine("-------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Consumo do carro: " + aluguel.carro.getConsumo());
                        Console.WriteLine("-------------------------");
                        break;
                    case 4:
                        Console.WriteLine("Fabricante do carro: " + aluguel.carro.getFabricante()); ;
                        Console.WriteLine("-------------------------");
                        break;
                    case 5:
                        Console.WriteLine("Placa do carro: " + aluguel.carro.getPlaca() +
                            "\nCor do carro: " + aluguel.carro.getCor() +
                            "\nConsumo do carro: " + aluguel.carro.getConsumo() +
                            "\nFabricante do carro: " + aluguel.carro.getFabricante() +
                            "\nCliente: " + aluguel.cliente.getNome() +
                            "\nIdade do cliente: " + aluguel.cliente.getIdade() +
                            "\nData de início do aluguel: " + aluguel.getdataInicio() +
                            "\nData final do aluguel: " + aluguel.getdataFim());
                        Console.WriteLine("-------------------------");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.\nDigite uma das opções válidas.");
                        break;
                }
            }
            */



            //Exercício 4
            /*
            Arvore pessoaFilho = new Arvore();
            pessoaFilho.nome = "Felipe";
            pessoaFilho.idade = 23;

            Arvore pessoaMae = new Arvore();
            pessoaMae.nome = "Fabiana";
            pessoaMae.idade = 49;

            Arvore pessoaPai = new Arvore();
            pessoaPai.nome = "André";
            pessoaPai.idade = 58;

            Arvore pessoaAvoPai = new Arvore();
            pessoaAvoPai.nome = "José";
            pessoaAvoPai.idade = 89;

            Arvore pessoaAvoMae = new Arvore();
            pessoaAvoMae.nome = "Luiz";
            pessoaAvoMae.idade = 87;

            pessoaFilho.pai = pessoaPai;
            pessoaFilho.mae = pessoaMae;
            pessoaMae.pai = pessoaAvoMae;
            pessoaPai.pai = pessoaAvoPai;
            */


            /*
            Exercício 5 - Identifique as classes e implemente um programa para a seguinte especificação:	
            "O supermercado vende diferentes tipos de produtos. Cada produto tem um preço e uma quantidade em estoque.
            Um pedido de um cliente é composto de itens, onde cada item especifica o produto que o cliente deseja e a respectiva quantidade.
            Esse pedido pode ser pago em dinheiro, cheque ou cartão."
            

            Produto produto = new Produto();
            Pedido pedido = new Pedido();
            int op = 0;

            while (true)
            {
                Console.WriteLine("1- Quanto foi o pedido.\n2- Informar o valor do pedido.\n");
                if (op == 1)
                {
                    Console.WriteLine("Digi");
                }
            }
            */



            //Exercício 6
            /**/

            Console.Write("Altura: ");
            int altura = int.Parse(Console.ReadLine());
            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Pessoas pessoas = new Pessoas(altura, idade, nome);
            



        }
    }
}