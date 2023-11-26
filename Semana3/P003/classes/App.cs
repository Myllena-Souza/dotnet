using Microsoft.VisualBasic;

namespace P003;

public class App
{
    private List<(string Codigo, string Nome, int Quantidade, double Preco)> Produtos = new ();

    private void Cadastro ()
    {
        Console.WriteLine("Digite o código do produto");
        string codigo = Console.ReadLine()!;
        Console.WriteLine("Digite o Nome do produto");
        string nome = Console.ReadLine()!;
        Console.WriteLine("Digite a quantidade do produto");
        int quantidade = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite o pereço do produto");
        double preco = double.Parse(Console.ReadLine()!);

        this.Produtos.Add((Codigo: codigo, Nome: nome, Quantidade: quantidade, Preco: preco));
    }
    private void ConsultaPeloCodigo(){

        Console.WriteLine("Digite o código do produto");
        string codigo = Console.ReadLine()!;

       var produto = this.Produtos.Find(x => x.Codigo == codigo);

       Console.WriteLine($"- Codigo: {produto.Codigo} - Nome {produto.Nome} - Quantidade {produto.Quantidade} - Preço {produto.Preco}");
    }
    private void AtualizarCodigo(){
        Console.WriteLine("Digite o código do produto que deseja atualizar");
        string codigo = Console.ReadLine()!;
        var produto = this.Produtos.Find(x => x.Codigo == codigo);
        
        Console.WriteLine("Digite a oção que deseja atualizar ");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("1. Atualizar entrada ");
        Console.WriteLine("1. Atualizar saída ");
        Console.WriteLine("-----------------------------------");
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                this.AtualizarEntrada(produto);
                break;

            case "2":
                this.AtualizarSaida(produto);
                break;

            default:
                Console.WriteLine("Opção invalida ");
                break;
        }

    }
    private void AtualizarEntrada ((string Codigo, string Nome, int Quantidade, double Preco) Produto){
        Console.WriteLine("Digite o valor de entrada que deseja atualizar.");
        int entrada = int.Parse(Console.ReadLine()!);
        Produto.Quantidade += entrada;
        //percorrendo a tupla
        foreach (var produto in Produtos)
        {
            
        }

    }
    private void AtualizarSaida ((string Codigo, string Nome, int Quantidade, double Preco) Produto){
        Console.WriteLine("Digite o valor de saida que deseja atualizar.");
        int saida = int.Parse(Console.ReadLine()!);
        //tratando a saida
        if(Produto.Quantidade >= saida){
            Produto.Quantidade -= saida;
        }
        else{
            Console.WriteLine("Imposivel atualizaro estoque, pois o valor de saída é maior que a quantidade do estoque.");
        }
    }
    private void ListarProdutoEstoq(){
    
        
    }
    private void ListarProdMinMax(){
        
    }
    private void ListarValorTot(){
    
    }

    public void Menu(){
            while (true){

                Console.WriteLine("------------------------MENU----------------------");
                Console.WriteLine("1. Cadastrar produto ");
                Console.WriteLine("2. Consultar produto Pelo Código");
                Console.WriteLine("3. Atualizar estoque de produtos");
                Console.WriteLine("4. Listar Produto em Estoque");
                Console.WriteLine("5. Listar Produto com valor Mínino e Máximo");
                Console.WriteLine("6. Listar valor total do estoque e de produtos");
                Console.WriteLine("0. Sair do programa");
                Console.WriteLine("---------------------------------------------------");

                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine()!;

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("1. Cadastrar produto");
                        this.Cadastro();
                        break;

                    case "2":
                        Console.WriteLine("Consultar produto Pelo Código: ");
                        this.ConsultaPeloCodigo();
                        break;

                    case "3":
                        Console.WriteLine("Atualizar estoque de produtos: ");
                        this.AtualizarCodigo();
                        break;

                    case "4":
                        Console.WriteLine("Listar Produto em Estoque: ");
                        this.ListarProdutoEstoq();
                        break;

                    case "5":
                        Console.WriteLine("Listar Produto com valor Mínino e Máximo: ");
                        this.ListarProdMinMax();
                        break;
                    case "6":
                        Console.WriteLine("Listar valor total do estoque e de produtos: ");
                        this.ListarValorTot();
                        break;
                    case "0":
                        Console.WriteLine("Saindo do programa.");
                        return; 
                    default:
                        Console.WriteLine("Escolha inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear(); 
            }
        }
}

