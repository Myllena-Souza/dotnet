namespace P002;

public class Tarefa
{
private   string Titulo;
private string Descricao;
private DateTime DataVencimento;
private bool Conclusao;

    public Tarefa(string _titulo, string _descricao, DateTime _dataVenc, bool _conclusao)
    {
        this.Titulo = _titulo;
        this.Descricao = _descricao;
        this.DataVencimento = _dataVenc;
        this.Conclusao = _conclusao;
    }
    public string getTitulo()
    {
        return this.Titulo;
    }
    public string getDescricao()
    {
        return this.Descricao;
    }
    public DateTime getDataVencimento()
    {
        return this.DataVencimento;
    }
    public bool getConclusao()
    {
        return this.Conclusao;
    }
    public void setConclusao (bool _conclusao)
    {
        this.Conclusao = _conclusao;
    }
    public void Print()
    {
        Console.WriteLine ("Titulo: " + this.Titulo);
        Console.WriteLine ("Descricao: " + this.Descricao);
        Console.WriteLine ("Data: " + this.DataVencimento);
    }

}
