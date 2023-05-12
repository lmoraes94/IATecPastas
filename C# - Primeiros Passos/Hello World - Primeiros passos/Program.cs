// See https://aka.ms/new-console-template for more informations
string name = "Leonardo";
int idade = 29; // ate 10 digitos
bool Maiordeidade = true;
decimal altura = 1.81M;
float moeda2 = 20.05F;
double moeda3 = 20.07D;
long numero = 1902892108234323523; //até 19 digitos
char caracter = 'a'; //não usar aspas duplas


string numeroaleatorio = "10";
int stringEmNumero =  int.Parse(numeroaleatorio); //Parse é uma função para conversão de tipos de dados

Console.WriteLine(stringEmNumero);
Console.WriteLine("Olá, meu nome é " + name + ", tenho " + idade + " anos e tenho " + altura + "M de altura");
