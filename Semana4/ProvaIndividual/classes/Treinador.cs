using System.Diagnostics.Contracts;
using System.IO.Pipes;

namespace Namespace;

public class Treinador
{
    public string Nome { get; set; }
    public DateTime DataNasci { get; set; }
    private string cpf;
    public string CPF
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
    private string cref;
    public string CREF
    {
        get { return cref; }
        set
        {
            if (VerificarCrefUnico(value))
                cref = value;
            else
                throw new ArgumentException ("CREF já existente");
        }
    }

    private static List<string> cpfsRegistrados = new List<string>();
    private static List<string> crefsRegistrados = new List<string>();
    public Treinador (string _nome, DateTime _dataNasci, string _cpf, string _cref)
    {
        Nome = _nome;
        DataNasci = _dataNasci;
        CPF = _cpf;
        CREF = _cref;
        cpfsRegistrados.Add(_cpf);
        crefsRegistrados.Add(_cref);
    }
    private bool ValidarCPF(string _cpf)
    {
        return cpf.Length == 11;
    }
    private bool VerificarCpfUnico(string _cpf)
    {
        return !cpfsRegistrados.Contains(cpf);
    }
    private bool VerificarCrefUnico(string value)
    {
        throw new NotImplementedException();
    }
}
