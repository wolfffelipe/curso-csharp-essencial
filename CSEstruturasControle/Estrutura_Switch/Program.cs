Console.WriteLine("SWITCH\n");

var menu = 0;
double num1, num2;

Console.WriteLine("Digite dois números:");
num1 = Convert.ToDouble(Console.ReadLine());
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nEscolha uma opção");
Console.Write("1. Somar\n2. Subtrair\n3. Multiplicar\n4. Dividir\n0. Sair\n");
menu = Convert.ToInt32(Console.ReadLine());

//switch (numero % 2) -- se 0 é par e se 1 é ímpar
switch(menu)
{
    case 0:
        break;
    case 1:
        Console.WriteLine($"\nSoma: {num1 + num2}");
        break;
    case 2:
        Console.WriteLine($"\nSubtração: {num1 - num2}");
        break;
    case 3:
        Console.WriteLine($"\nMultiplicação: {num1 * num2}");
        break;
    case 4:
        Console.WriteLine($"\nDivisão: {num1 / num2}");
        break;
    default: Console.WriteLine("\nMenu não existe");
        break;
}

Console.WriteLine("\n\nFim do processamento!");
Console.ReadKey();