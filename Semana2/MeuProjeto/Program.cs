// EXEMPLO 1 DA AULA //
string [] people = {"Maria","João", "José", "Ana"};

foreach(string person in people) // rastrea por toda coleção de pessoas.
{
    Console.WriteLine(person);
}

//EXEMPO 2 DA AULA//

for (int i=0; i<=30; i++)
{
    if(i%3==0) //verificando se i é divisivel por 3, para isso o resultado tem que ser 0
    Console.WriteLine("O valor " +i+ " eh divisivel por 3");

    if(i%4==0)
    Console.WriteLine("O valor " +i+ " eh divisivel por 4");
      
}

#region Fibonacci

int fib1 = 0;
int fib2 = 1;
int fib3;   

Console.WriteLine("fib1");
Console.WriteLine("fib2");

for (fib3 = fib2+fib1; fib3 <= 100;){
//ou while (fib <= 100)

    Console.WriteLine(fib3);
    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib2 + fib1;
}

#endregion