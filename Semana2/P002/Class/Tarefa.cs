namespace P002;

public class Tarefa
{
    string Titulo;
    string Descricao;
    DateTime DataVencimento;
    Boolean Conclusao;

    public Tarefa(string _titulo, string _descricao, DateTime _dataVenc, Boolean _conclusao)
    {
        this.Titulo = _titulo;
        this.Descricao = _descricao;
        this.DataVencimento = _dataVenc;
        this.Conclusao = _conclusao;
    }

    public void Listar()
    {
        Console.WriteLine ("Titulo: " + this.Titulo);
        Console.WriteLine ("Descricao: " + this.Descricao);
        Console.WriteLine ("Titulo: " + this.DataVencimento);
    }


}
