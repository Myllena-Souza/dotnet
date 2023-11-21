
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

/*#region 
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
*/
/*#region 
string[] people = { "Myllena", "Carla", "Maria"};

char letter = 'M'; 
System.Console.WriteLine($"Pessoas : {string.Join(", ", people)}");

//PEDINDO PRA MOSTRAR O NOME DAS PESSOAS QUE COMEÇA COM A LETRA M
Console.WriteLine($"Pessoas com o nome iniciado com '{letter}': {string.Join(", ", people.Where(x => x.StartsWith(letter)))}");
#endregion
*/

#region 
List<int> list = new() {1, 2, 4, 5,};
//pegando elemento da lista e multiplicando por ele mesmo
var squaredList = list.Select(x => x * x);
//imprimindo a lista original e lista atualizada
Console.WriteLine($"Lista Original: {string.Join(", ", list)!}");
Console.WriteLine($"Lista atualizada : {string.Join(", ", squaredList)}");
var summedList = list.Select((x,index) => x + squaredList.ElementAt(index));
// esta somando a lista atualizada com a lista original
Console.WriteLine($"Summed List: {string.Join(", ", summedList)}");

//
var listMultipleOfThree = list.Where(x => x % 3 == 0).ToList();
listMultipleOfThree.AddRange(squaredList.Where(x => x % 3 == 0).ToList());
listMultipleOfThree.AddRange(summedList.Where(x => x % 3 == 0).ToList());
Console.WriteLine($"Lista Multiplicada por três: {string.Join(", ", listMultipleOfThree)}");
Console.WriteLine($"Lista Multiplicada por três: {string.Join(", ", listMultipleOfThree.Order())}");

#endregion