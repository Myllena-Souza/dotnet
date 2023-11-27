using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


namespace P003;
public class ProdNaoEncontradoException : Exception
{
    public ProdNaoEncontradoException(string codigo) : base ($"O produto com o código {codigo} não foi encontado."){
    }

}

public class App
{
    private List<(string Codigo, string Nome, int Quantidade, double Preco)> Produtos = new ();

    private void Cadastro ()
    {
        Console.WriteLine("Digite o código do produto");
        string codigo = Console.ReadLine()!;
        Console.WriteLine("Digite o Nome do produto");
        string nome = Console.ReadLine()!;

        int qtdade;
        while (true){
            Console.WriteLine("Digite a quantidade do produto");
            if(int.TryParse(Console.ReadLine(), out qtdade) && qtdade >= 0)
            {
                break;
            }
            else{
                Console.WriteLine("Quantidade digitada inválida, digite novamente. (OBS: Número inteiro e positivo).");
            }
        }
        
        double preco;
        while (true)
        {
            Console.WriteLine("Digite o preço do produto");
            if (double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out preco) && preco >= 0){
                break;
            }
            else{
                Console.WriteLine("Preço digitado inválido, digite novamente um preço válido.");
               
            }
        }

        this.Produtos.Add((Codigo: codigo, Nome: nome, Quantidade: qtdade, Preco: preco));
         Console.WriteLine("O produto foi cadastrado com sucesso. ");
    }
    private void ConsultaPeloCodigo(){

        Console.WriteLine("Digite o código do produto");
        string codigo = Console.ReadLine()!;

       var produto = this.Produtos.Find(x => x.Codigo == codigo);

       if (produto != default)
       {
        Console.WriteLine($"- Codigo: {produto.Codigo} - Nome {produto.Nome} - Quantidade {produto.Quantidade} - Preço {produto.Preco}");

       }
       else{
        throw new ProdNaoEncontradoException(codigo);
       }
    }
    private void AtualizarEstoq()
    {
        Console.WriteLine("Digite o código do produto que deseja atualizar");
        string codigo = Console.ReadLine()!;
        
        Console.WriteLine("Digite a oção que deseja atualizar ");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("1. Atualizar entrada ");
        Console.WriteLine("1. Atualizar saída ");
        Console.WriteLine("-----------------------------------");
        string opcao = Console.ReadLine()!;

        switch (opcao)
        {
            case "1":
                this.AtualizarEntrada(codigo);
                break;

            case "2":
                this.AtualizarSaida(codigo);
                break;

            default:
                Console.WriteLine("Opção invalida ");
                break;
        }
    }
    private void AtualizarEntrada (string codigo)
    {
        Console.WriteLine("Digite o valor de entrada que deseja atualizar.");
        int entrada = int.Parse(Console.ReadLine()!);
        int index = this.Produtos.FindIndex(x => x.Codigo == codigo);
        
        if (index != -1){
            var prodAtualizado = (Produtos[index].Codigo, Produtos[index].Nome, Produtos[index].Quantidade + entrada, Produtos[index].Preco);
            Produtos[index] = prodAtualizado;
            Console.WriteLine($"Entrada de {entrada} unidades realizada com sucesso. Estoque atual : {Produtos[index].Quantidade}");
        }
    }
    private void AtualizarSaida (string codigo)
    {
        Console.WriteLine("Digite o valor de saida que deseja atualizar.");
        int saida = int.Parse(Console.ReadLine()!);
        
        var produto = this.Produtos.Find(x => x.Codigo == codigo);

        //tratando a saida
        if(produto != default && saida <= produto.Quantidade)
        {
            int index = this.Produtos.FindIndex(x => x.Codigo == codigo);
            var prodAtualizado = (Produtos[index].Codigo, Produtos[index].Nome, Produtos[index].Quantidade - saida, Produtos[index].Preco);
            Produtos[index] = prodAtualizado;
            Console.WriteLine($"Saída de {saida} unidades realizada com sucesso.");
            Console.WriteLine($"Estoque atual de produtos {produto.Quantidade - saida}");
        }
        else if (produto == default) 
        {
            Console.WriteLine($"O produto com o código {codigo} não encontrado. ");
        }
        else{
            Console.WriteLine("Não foi possivel atualizar o estoque, o valor de saída é superior a quantidade em estoque.");
        }
    }
    private void ListarProdutoEstoq(){
        Console.WriteLine("Digite o limite inferior de quantidade: ");
        int limite = int.Parse(Console.ReadLine()!);

        var prodAbaixoDoLimite = Produtos.Where(prod => prod.Quantidade < limite);
        Console.WriteLine("Prduto com quantidade abaixo do limite: ");
        foreach (var produto in prodAbaixoDoLimite){
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");
        }   
    }
    private void ListarProdMinMax(){

        Console.WriteLine("Digite o valor mínimo: ");
        double min = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

         Console.WriteLine("Digite o valor máximo: ");
        double max = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

        var prodEntreIntervalo = Produtos.Where (prod => prod.Preco >= min && prod.Preco <= max);

        Console.WriteLine("Produtos no intern=valo de valores: ");
        foreach (var produto in prodEntreIntervalo){
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Quantidade: {produto.Quantidade}, Preço: {produto.Preco}");   
        }
    }
    private void ListarValorTot(){
        double valorTotEstoq = Produtos.Sum(prod => prod.Quantidade * prod.Preco);
        Console.WriteLine($"Total do estoque {valorTotEstoq:C}");

        Console.WriteLine("Total por produto: ");
        foreach (var produto in Produtos){
            double valorTotProdutos = produto.Quantidade * produto.Preco;
            Console.WriteLine($"Código: {produto.Codigo}, Nome: {produto.Nome}, Valor Total: {valorTotProdutos:C}");      
        }
    }

    public void Menu()
    {
        while (true){

            Console.WriteLine("------------------------MENU----------------------");
            Console.WriteLine("1. Cadastrar produto. ");
            Console.WriteLine("2. Consultar produto Pelo Código.");
            Console.WriteLine("3. Atualizar estoque de produtos.");
            Console.WriteLine("4. Listar Produto em Estoque.");
            Console.WriteLine("5. Listar Produto com valor Mínino e Máximo.");
            Console.WriteLine("6. Listar valor total do estoque e de produtos.");
            Console.WriteLine("0. Sair do programa.");
            Console.WriteLine("---------------------------------------------------");

            Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine()!;

            try
            {
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
                        this.AtualizarEstoq();
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

            }
            catch (ProdNaoEncontradoException ex){
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex){

                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
            Console.Clear(); 
        }
    }
}

