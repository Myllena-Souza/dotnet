// Problema 1: Configuração do Ambiente

// - Para verificar se o .NET está instalado corretamente é preciso realizar o seguinte comando no terminal: dotnet --version

// - Para verificar as versões já instalads do .NET SDK: dotnet --listar-sdks

// - Para remover determinada versão do .NET SDK: dotnet -- uninstall-sdk <versao>

// - E para atualizar o .NET para a versão mais recente: dotnet --install-dir /usr/share/dotnet

// Problema 2: Tipos de Dados

Console.WriteLine($"Problema 2: Tipos de Dados ");

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

Console.WriteLine($"Problema 3: Conversão de Tipos de Dados ");

double numDouble = 5.98;

int numInteiro = Convert.ToInt32(numDouble);
Console.WriteLine($" O inteiro é : {numInteiro}");

Console.WriteLine();

// Problema 4: Operadores Aritmétricos

Console.WriteLine($"Problema 4: Operadores Aritmétricos ");


