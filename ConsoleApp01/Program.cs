// See https://aka.ms/new-console-template for more information
using ConsoleApp01;
using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;


/*
int m  = 10;
Console.WriteLine(m);

long m2 = 7415836962585;
Console.WriteLine(m2);

double m3 = 3.1452;
Console.WriteLine(m3);

string nome = "Carol";
string sobrenome = "Oliveira";
Console.WriteLine(nome+" "+sobrenome);
*/


/*
bool par;
Console.WriteLine("Digite um número");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
par = true;

else
    par = false;

if (par)
Console.WriteLine(num + " é par " );

else
    Console.WriteLine(num + "é ímpar");
Console.ReadLine();
*/



/*
string strnum = Console.ReadLine();  //converter para o Brasil
double num = double.Parse(strnum);

Console.WriteLine(num.ToString());
*/


/*
int n1, n2, n3;

n1 = 7; 
n2 = 5;
n3 = 3;

if (n1 > n2)    // ou usar o ((n1>n2) && (n2>n3))
{
    if (n2 > n3)
    {
        Console.WriteLine(n1 + " é maior do que " + n2 + " e " + n3 );
    }
}
else
    if (n2 < n1)
    Console.WriteLine(n2 + "é maior do que" + n1);
else
    Console.WriteLine("Números iguais");
*/


/*
string fruta = "laranja";
if(fruta.ToUpper() == "LARANJA")
{
    Console.WriteLine(fruta);
}
else
{
    Console.WriteLine("eu quero uma laranja");
}

*/


/*
int n1, n2;

n1 = 5;
n2 = 9;

if (((n1 + n2) / 2) == 7)
    Console.WriteLine("Aluno aprovado");
else
    Console.WriteLine("Reprovado");
*/


/*
int n1, n2, n3;

n1 = 5;
n2= 9;
n3 = 6;
double media = (n1 + n2 + n3) / 3;

if ((media >= 6) && (media < 8))

    Console.WriteLine("Aluno Bom");

else
    if ((media >= 8) && (media < 9))
       Console.WriteLine("aluno Ótimo");

    else
        if (media >= 9)
         Console.WriteLine("Aluno Excelente");

        else 
         Console.WriteLine("Aluno Reprovado");
*/


/*
int num = int.Parse(Console.ReadLine());
int contador = 1;
int resultado;

while (contador < 11)
{
    resultado = num * contador;
    Console.WriteLine(num + " x "+ contador + " = " + resultado);
    contador++;
}
*/



/*
int num = int.Parse(Console.ReadLine());
int contador = 1;
int resultado;

for (int i = 1; i < 10; i++)
    {
    resultado = num * contador;
    Console.WriteLine(num + " x " + contador + " = " + resultado);
    }

*/

/*       // fatorial

int num = int.Parse(Console.ReadLine());
int contador = num;
long resultado = 1;

while (contador < 1 )         // quando chegar no 1 ele para
{
    resultado = resultado * contador;
    Console.WriteLine("o fatorial de " + num + " é " + resultado);
    contador--;
}
*/


/*


int num = int.Parse(Console.ReadLine ());
int divisor = 2;
bool resultado = true;

while (divisor < num)
{
    int resto = num % divisor ;

    if (resto == 0)
    {
        resultado = false;
        break;
    }
    divisor++;
}

if 
    (resultado == true)

    Console.WriteLine("É primo");

    else Console.WriteLine("Não é primo");

*/




/*
Console.WriteLine ("insira sua data de nascimento");
DateTime DataNasc = DateTime.Parse (Console.ReadLine()); 
int idade = ((DateTime.Now - DataNasc).Days) / 365;
Console.WriteLine("Minha idade é " + idade);
*/

/*
DateTime DataNasc = DateTime.Parse ("05/10/1994");   // idade atual
int idade = ((DateTime.Now - DataNasc).Days)/ 365;
Console.WriteLine ("Minha idade é " + idade);
*/



/*
DateTime DataNasc = DateTime.Parse("01/01/1900");

try
{
    DataNasc = DateTime.Parse(Console.ReadLine());
    int idade = ((DateTime.Now - DataNasc).Days) / 365;

    Console.WriteLine("Minha idade é " + idade);
}
catch
{
    Console.WriteLine("Data Inválida");
}
*/


/*
int n1, n2, n3;

n1 = 3;
n2 = 3; 
n3 = 3;



if ((n1 == n2) && (n1 == n3))
    Console.WriteLine("É um triângulo Equilatero");

else
       if ((n1 == n2) || (n1 == n3) || (n2 == n3))

    Console.WriteLine("É um triângulo Isosceles");

else
    Console.WriteLine("É um triângulo Escaleno");  
*/


/*

int qtdAlunos = 0;
double somaIdade = 0.0;
double mediaIdade = 0.0;
Console.WriteLine("Quantos alunos tem na sala??");
qtdAlunos = int.Parse(Console.ReadLine());

int contadordealunos = 1;

while (contadordealunos <= qtdAlunos)
{
    Console.WriteLine("Digite a idade de um aluno");
    double idade = int.Parse(Console.ReadLine());
    somaIdade = somaIdade + idade;
    contadordealunos++;

}
mediaIdade = somaIdade / qtdAlunos;

Console.WriteLine("A média de idade dos alunos é " + mediaIdade);

*/


/*
// Salário Líquido com descontos

Console.WriteLine("Digite o salário");
int salario = int.Parse(Console.ReadLine());
int INSS = 1;
int IR = 1;
int SalarioLiquid = 1;

if (salario < 1000)
{
    INSS = ((int)(salario * 0.1));
    IR = ((int)(0.2 * (salario - INSS)));
    SalarioLiquid = ((int)(salario - IR - INSS));
    Console.WriteLine(" O salário Líquido é " + SalarioLiquid);
}

if (salario >= 1000)
{
    INSS = ((int)(salario * 0.15));
    IR = ((int)(0.2 * (salario - INSS)));
    SalarioLiquid = ((int)(salario - IR - INSS));
    Console.WriteLine(" O salário Líquido é " + SalarioLiquid);
}

*/
/*

int Contador = 100;
int SomadosPares = 0;
int resto = 0;

while (Contador <= 200)

{
    SomadosPares = SomadosPares + Contador;
 
    if  (Contador <= 200)
        
        resto = (Contador % 2);
        if (resto == 0)
           Contador+=2;
 }

Console.WriteLine("A soma dos pares no intervalo de 100 a 200 é " + SomadosPares);

*/


/*
// soma dos pares de 100 a 200 

int SomadosPares=0;

for (int par = 100; par <= 200; par++)

{
    if (par % 2 ==0)

        SomadosPares = SomadosPares + par;
    
}
Console.WriteLine("A soma dos pares no intervalo de 100 a 200 é " + SomadosPares);

*/




//Fazer um algoritmo que calcule e escreva a soma dos 10 primeiros termos da série:
//S = (480 / 10) - (475 / 11) + (470 / 12) - (465 / 13) +

/*
int Numerador = 480;
float Divisao = 0;
float Divisao2 = 0;

for (int Denominador = 10; Denominador <= 20; Denominador++)
{
    Numerador = Numerador - 5;

    if (Denominador % 2 ==0)
    Divisao = Divisao + (Numerador / Denominador);

    else
        Divisao2 = Divisao2 - (Numerador / Denominador);
    
}

Console.WriteLine("A Somatória da série é: " + ( Divisao + Divisao2));


*/



/*
// Fazer um algoritmo que calcule e escreva a soma dos 10 primeiros termos da série:
//S = (1! / 1) - (2! / 3) + (3! / 7) - (4! / 15) + (5! / 31) - ...

float Numerador = 1;
float Divisao = 0;
float Divisao2 = 0;

for (float Contador = Numerador; Contador < 10; Contador++ )
{

    if (Numerador % 2 == 0)
    {
        Divisao = Divisao - ((Numerador * Contador) / ((2 * Numerador) + 1));
        Numerador++;
    }



    if (Numerador % 2 != 0)
    {
        Divisao2 = Divisao2 + ((Numerador * Contador) / ((2 * Numerador) + 1));
        Numerador++;
    }

}

Console.WriteLine(" O resultado da série fatorial é " + (Divisao + Divisao2));


*/



/*
Pessoa pes = new Pessoa();
pes.CorDoCabelo = "ruivo";
pes.Nome = "Carol";
pes.DataNasc = DateTime.Parse("05/10/1994");
pes.CorDosOlhos = "castanho";
pes.PintarCabelo();

Console.WriteLine(pes.CorDoCabelo);

*/


// funçoes

/*
long fatorial (int num)
{
    long fat = 1;
    for (int i = 1; i <= num; i++)
    {
        fat = fat * i;
    }
    return fat;
}

Console.WriteLine(fatorial(5));

*/

/*

long fatorial (int num)  // (parametro)   // empilha e pega o último valor
{
    if ((num == 0) || (num == 1))
        return 1;
    
    else
            return num * fatorial(num - 1);

}
Console.WriteLine(fatorial(5));

*/

/*
long fibonnaci(int num)
{
    if ((num == 1) || (num == 2))
        return 1;
    else
        return fibonnaci(num - 1) + fibonnaci(num - 2);
}
Console.WriteLine(fibonnaci(6));
*/

/*   // só mostra a idade
Pessoa pes = new Pessoa(78269854255, "Carol", DateTime.Parse("05/10/1994"), ("#000"));
Console.WriteLine (pes.CalcularIdade());
*/



/* // atualiza o salario
Funcionario func = new Funcionario(78269854255, "Carol", DateTime.Parse("05/10/1994"), "#000");
func.Contrata(3000, DateTime.Now);
func.AtualizarSalario(4000);
Console.WriteLine(func.salario);
*/

/*
Veiculo veic = new Veiculo("Fiat", "prata", 2018, 10000, 50);
veic.AtualizarVelocidade(100);
Console.WriteLine(veic.Velocidade);
veic.AnodoVeiculo();
Console.WriteLine(veic.Preco);
*/





