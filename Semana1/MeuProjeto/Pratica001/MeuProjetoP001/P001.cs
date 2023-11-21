// Problema 1: Configuração do Ambiente

// - Para verificar se o .NET está instalado corretamente é preciso realizar o seguinte comando no terminal: dotnet --version

// - Para verificar as versões já instalads do .NET SDK: dotnet --listar-sdks

// - Para remover determinada versão do .NET SDK: dotnet -- uninstall-sdk <versao>

// - E para atualizar o .NET para a versão mais recente: dotnet --install-dir /usr/share/dotnet

// Problema 2: Tipos de Dados


Console.WriteLine($"##### Problema 2: Tipos de Dados. ##### ");

int bexigasAzul = 13;
int bexigasVermelha = 35;

int somaAzulVermelha = bexigasAzul + bexigasVermelha;
Console.WriteLine($" A soma de bexigas Azul e bexigas vermelhas é: {somaAzulVermelha}");

decimal precoLaranja = 3.85m;
decimal laranjasVendidas = 9;

decimal totalVenda = precoLaranja * laranjasVendidas;
Console.WriteLine($" O total da venda é: {totalVenda}");

float pi = 3.14f;
float a = 2f;

float resultadoDiv = pi / a;
Console.WriteLine($" O resultado da divisão é: {resultadoDiv}");

long gatos = 19L;
long cachorros = 10L;

long animais = gatos - cachorros;
Console.WriteLine($" O quantidade de animais é: {animais}");

double aceleracao = 150;
double massa = 50.45;

double forca = massa * aceleracao;
Console.WriteLine($" A força aplicada é: {forca}");

Console.WriteLine();

// Problema 3: Conversão de Tipos de Dados

Console.WriteLine($" ##### Problema 3: Conversão de Tipos de Dados. #####");

double numDouble = 5.98;

int numInteiro = Convert.ToInt32(numDouble);
Console.WriteLine($" O inteiro é : {numInteiro}");

Console.WriteLine();

// Problema 4: Operadores Aritmétricos

Console.WriteLine($" ##### Problema 4: Operadores Aritmétricos ##### ");

int x = 10;
int y = 3;

int adicao = x + y;
int subtracao = x - y;
int multiplicacao = x * y;
int divisao = (y != 0) ? x / y : 0;

Console.WriteLine($" Adição:  {adicao}" );
Console.WriteLine($" Adição:  {subtracao}" );
Console.WriteLine($" Adição:  {multiplicacao}" );
Console.WriteLine($" Adição:  {divisao}" );

Console.WriteLine();

//Problema 5: Operadores de Comparação

Console.WriteLine($" ##### Problema 5: Operadores de Comparação. #####");

int A = 5;
int B = 8;

bool aMaiorQueB = A > B;

if (aMaiorQueB){
    Console.WriteLine($" 'A' é maior que 'B'. ");
}
else
{
    Console.WriteLine($" 'A' não é maior que 'B'. ");
}

Console.WriteLine();

// Problema 6: Operadores de Igualdade

Console.WriteLine($" ##### Problema 6: Operadores de Igualdade. ##### ");

string str1 = "Hello";
string str2 = "Word";

bool saoIguais = string.Equals(str1, str2);

if (saoIguais)
{
    Console.WriteLine($" As Strings são iguais! ");
}
else{
    Console.WriteLine($"As Strings não são iguais! ");
}

Console.WriteLine();

// Problema 7: Operadores Lógicos

Console.WriteLine($" ##### Problema 7: Operadores Lógicos ##### ");

bool condicao1 = true;
bool condicao2 = false;

bool saoVerdadeiras = condicao1 && condicao2;

if (saoVerdadeiras)
{
    Console.WriteLine($"As duas condições são verdadeiras. ");
}
else
{
    Console.WriteLine($"Pelo menos uma das duas condições não é verdadeira. ");
}

Console.WriteLine();

// Problema 8: Desafio de Mistura de Operadores.

Console.WriteLine($"Problema 8: Desafio de Mistura de Operadores.");

int num1 = 7;
int num2 = 3;
int num3 = 10;

bool num1EhMaiorQueNum2 = num1 > num2;

bool num3EhIgualSomaNum1Num2 = num3 == (num1 + num2);

if (num1EhMaiorQueNum2)
{
    Console.WriteLine($"num1 é maior que num2. ");
}
else
{
    Console.WriteLine($"num1 não é maior que num2.");
}

if (num3EhIgualSomaNum1Num2)
{
    Console.WriteLine($"num3 é igual a num1 + num2. ");
}
else
{
    Console.WriteLine($"num3 não é igual a num1 + num2. ");
}
Console.WriteLine();
