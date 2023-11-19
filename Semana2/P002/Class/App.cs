using System.Data;
using System.Runtime.InteropServices;

namespace P002
{

    public class App
    {
        private List<Tarefa> Tarefas = new List<Tarefa>();

        private void Criar ()
        {
        System.Console.WriteLine("Digite o titulo da tarefa: ");
        string titulo = Console.ReadLine();
        System.Console.WriteLine("Digite uma descrição: ");
        string descricao = Console.ReadLine();
        System.Console.WriteLine("Digite o dia: ");
        int dia = int.Parse (Console.ReadLine());
        System.Console.WriteLine("Digite o mês: ");
        int mes = int.Parse (Console.ReadLine());
        System.Console.WriteLine("Digite o ano: ");
        int ano = int.Parse (Console.ReadLine());
        System.Console.WriteLine("A tarefa foi concluida? (S/N): ");
        string aux = Console.ReadLine ();
        bool entradaConc;
        if (aux == "s")
        {
            entradaConc = true;
        }
        else
        {
            entradaConc = false;
        }

        DateTime data = new DateTime(ano, mes, dia);
        Tarefa tarefa = new Tarefa(titulo, descricao, data, entradaConc);
        this.Tarefas.Add (tarefa); // adicionando a tarefa criada
        }

        private void ListarTodos(){
            Console.WriteLine("Aqui estão todas as tarefas: ");
            int indice = 0;
            foreach ( Tarefa t in this.Tarefas)
            {
                Console.WriteLine("Tarefa numero " + indice + ":");
                t.Print();
                indice ++;
            }
            
        }
        private void ListarConcluido(){
            Console.WriteLine("Aqui estão todas as tarefas concluídas: ");
            foreach ( Tarefa t in this.Tarefas)
            {
                if(t.Conclusao)
                t.Print();
            }
        }
        private void ListarNConcluido(){
            Console.WriteLine("Aqui estão todas as tarefas não concluídas: ");
            foreach ( Tarefa t in this.Tarefas)
            {
                if(!t.Conclusao)
                t.Print();
            }
        }
        private void AlteraConclusao(){
            this.ListarTodos();
            Console.WriteLine("Qual tarefa gostaria de alterar a conclusao? Digite o número: ");
            int numero = int.Parse(Console.ReadLine());
            this.Tarefas[numero].Conclusao = !this.Tarefas[numero].Conclusao;
            
        }
        private void Excluir(){
            this.ListarTodos();
            Console.WriteLine("Qual tarefa gostaria de excluir? Digite o número: ");
            int numero = int.Parse(Console.ReadLine());
            this.Tarefas.RemoveAt(numero);
            
        }
        private void Pesquisar(){
            
        }
        private void Estatisticas(){
            
        }
        public void Menu(){
        while (true){

                Console.WriteLine("1. Criar Tarefa");
                Console.WriteLine("2. Listar todas as tarefas");
                Console.WriteLine("3. Listar tarefas concluidas");
                Console.WriteLine("4. Listar tarefas não concluidas");
                Console.WriteLine("5. Alterar conclusão de uma tarefa");
                Console.WriteLine("6. Excluir uma tarefa");
                Console.WriteLine("7. Pesquisar uma tarefa pela nome");
                Console.WriteLine("8. Estatisticas");
                Console.WriteLine("0. Sair do programa");

                Console.Write("Escolha uma opção: ");
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("1. Criar Tarefa: ");
                        this.Criar();
                        break;

                    case "2":
                        Console.WriteLine("Listar todas as tarefas: ");
                        this.ListarTodos();
                        break;

                    case "3":
                        Console.WriteLine("Listar tarefas concluidas: ");
                        this.ListarConcluido();
                        break;

                    case "4":
                        Console.WriteLine("Listar tarefas não concluidas: ");
                        this.ListarNConcluido();
                        break;

                    case "5":
                        Console.WriteLine("Alterar conclusão de uma tarefa: ");
                        this.AlteraConclusao();
                        break;
                    case "6":
                        Console.WriteLine("Excluir uma tarefa: ");
                        this.Excluir();
                        break;
                    case "7":
                        Console.WriteLine("Pesquisar uma tarefa pela nome: ");
                        this.Pesquisar();
                        break;
                    case "8":
                        Console.WriteLine("Estatisticas: ");
                        this.Estatisticas();
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
}
