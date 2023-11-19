using System.Data;
using System.Runtime.InteropServices;

namespace P002;

public class App
{
    private List<Tarefa> Tarefas = new List<Tarefa>();

    private void Criar (){
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
        Boolean entradaConc;
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
        this.Tarefas.Add (tarefa);

    }

}
