namespace P002;

public class Tarefa
{
    public string Titulo;
    public string Descricao;
    public DateTime DataVencimento;
    public bool Conclusao;

    public Tarefa(string _titulo, string _descricao, DateTime _dataVenc, bool _conclusao)
    {
        this.Titulo = _titulo;
        this.Descricao = _descricao;
        this.DataVencimento = _dataVenc;
        this.Conclusao = _conclusao;
    }

    public void Print()
    {
        Console.WriteLine ("Titulo: " + this.Titulo);
        Console.WriteLine ("Descricao: " + this.Descricao);
        Console.WriteLine ("Titulo: " + this.DataVencimento); // alterar para data
    }

}
