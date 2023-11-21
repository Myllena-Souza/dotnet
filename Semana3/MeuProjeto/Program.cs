
/*#region 
using System.Data;
using System.IO.Compression;

var tuple3 = (id: 10,nome: "Myllena", born: new DateTime(1996, 1, 23));
Console.WriteLine($"tuple 3: {tuple3.id}, {tuple3.nome}, {tuple3.born}");

List<(int id, string nome, DateTime born)> list = new();
list.Add(tuple3);
list.Add((11, "João", new DateTime(2019, 1, 12)));
list.ForEach(x => Console.WriteLine($"Tuple 4: {x.id},{x.name}, {x.born.ToShortDatesString()}"));

#endregion
*/

#region 
using System.Security.Cryptography;

Console.WriteLine($"{CalcAge("Myllena", new DateTime(1996, 1, 23))}");

// CALCULANDO IDADE 
(string, int)CalcAge(string nome, DateTime BirthDate){

    //SUBTRAINDO O ANO ATUAL DO ANO DE NASCIMENTO
    var age = DateTime.Today.Year - BirthDate.Year;

    // VERIFICANDO O DIA DE NASCIMENTO
    if (DateTime.Today.DayOfYear < BirthDate.DayOfYear);
        age--;
        
    return (nome,age);
}

#endregion

