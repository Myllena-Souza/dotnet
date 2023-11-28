namespace Namespace;
public class Class
{
    List<Cliente> clientes = new List<Cliente>();
    List<Treinador> treinadores = new List<Treinador>();

    public void Execultar(){
        Cliente Client1 = new Cliente ("Myllena", new DateTime (1996,01,23), "05982859540", 1.68, 62);
        Cliente Client2 = new Cliente ("João", new DateTime (1996,02,21), "0598285738", 1.55, 65);
        Cliente Client3 = new Cliente ("Carla", new DateTime (1995,06,10), "14567829845", 1.65, 58);
        clientes.Add((Client1));
        clientes.Add((Client1));
        clientes.Add((Client1));

        Treinador Treinador1 = new Treinador ("Paula", new DateTime (1996,02,23), "05982859540","959594948");
        Treinador Treinador2 = new Treinador ("Carlos", new DateTime (1978,03,24), "05987894563","894839674");
        Treinador Treinador3 = new Treinador ("Antonio", new DateTime (1956,04,28), "01234567893","873425167");
        this.treinadores.Add((Treinador1));
        treinadores.Add((Treinador2));
        treinadores.Add((Treinador3));
    }
    private void ListarTreinadorPorIdade(){
        Console.WriteLine("Digite a idade mínima do treinador: ");
        int imin = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a idade máxima do treinador: ");
        int imax = int.Parse(Console.ReadLine()!);

        foreach (var treinador in treinadores){
            if (DateTime.Now.Year-treinador.DataNasci.Year >= imin && DateTime.Now.Year-treinador.DataNasci.Year <= imax){
                Console.WriteLine ("Treinador: " + treinador.Nome);
                Console.WriteLine ("Data de Nascimento: " + treinador.DataNasci);
                Console.WriteLine ("CPF: " + treinador.CPF);
                Console.WriteLine ("CREF: " + treinador.CREF);

            }
        }

    }
    private void ClientesIdadeEntreDoisValores(){
        Console.WriteLine("Digite a idade minima do cliente: ");
        int imin = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Digite a idade minima do cliente: ");
        int imax = int.Parse(Console.ReadLine()!);
        
        foreach (var cliente in clientes){
            if (DateTime.Now.Year - cliente.DataNasc.Year >= imin && DateTime.Now.Year - cliente.DataNasc.Year <= imax)
            {
                Console.WriteLine("Cliente: " + cliente.Nome);
                Console.WriteLine("Data de nascimento: " + cliente.DataNasc);
                Console.WriteLine("CPF: " + cliente.CPF);
                Console.WriteLine("Altura: " + cliente.Altura);
                Console.WriteLine("Peso: " + cliente.Peso);
            }
        }

    }


    private void ClienteImc(){
        
    }
    private void ClienteOrdemAlfabetica(){
        
    }
    private void ClienteVelhoParaNovo(){
        
    }
    private void ClienteTreinadoresAniversMesInformado(){
        
    }

}
