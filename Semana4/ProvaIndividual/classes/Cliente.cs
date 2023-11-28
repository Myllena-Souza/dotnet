namespace Namespace;
public class Cliente
{
    public string Nome { get; set; }
    public DateTime DataNasc { get; set; }
    public string CPF { get; set; }
    private string cpf;
    public string _CPF
    {
        get {return cpf; }
        set
        {
            if (value.Length == 11 && VerificarCpfUnico(value))
                cpf = value;
            else 
                throw new ArgumentException("CPF invalido ou já existe");
        } 
    }
    
    public double Altura { get; set; }
    public double Peso { get; set; }

    private static List<string> cpfsRegistrados = new List<string>();

    public Cliente (string _nome, DateTime _dataNasc, string _cpf, double _altura, double _peso)
    {
        Nome = _nome;
        DataNasc = _dataNasc;
        CPF = _cpf;
        Altura = _altura;
        Peso = _peso;
        cpfsRegistrados.Add(_cpf);

    }
    private bool VerificarCpfUnico(string value)
    {
        throw new NotImplementedException();
    }
    private bool ValidarCPF(string value)
    {
        throw new NotImplementedException();
    }
}
