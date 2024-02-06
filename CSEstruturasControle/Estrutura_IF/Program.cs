Console.WriteLine("Estrutura IF\n\n");

//var resposta2 = Convert.ToBoolean(Console.ReadLine());
//resposta = resposta.ToLower();
/*
if (resposta2){
    Console.WriteLine("Cliente é especial");
}else{
    Console.WriteLine("Cliente não é especial");
}
*/


/* Variáveis */

double saldo = 1000;


/* Saque e saldo */

Console.WriteLine($"Saldo da conta: R$ {saldo}");
Console.WriteLine("Digite um valor para sacar: ");
double saque = Convert.ToDouble(Console.ReadLine());

if (saque > saldo){
    Console.WriteLine("Saldo insuficiente");
}else{
    saldo = saldo - saque;
}

Console.WriteLine($"Seu saldo atual é de R$ {saldo}");


/* Comparando números */

Console.WriteLine("\n\nDigite um número inteiro:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite outro número inteiro:");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"{num1} é maior que {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num1} é menor que {num2}");
}
else
{
    Console.WriteLine($"{num1} é igual a {num2}");
}
