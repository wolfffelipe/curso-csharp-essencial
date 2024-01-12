Console.WriteLine("Saída de dados : Formatação!");

int idade = 32;
string nome = "Felipe";

Console.WriteLine("\n--- WRITE LINE ---");
Console.WriteLine(nome);
Console.WriteLine(idade);

Console.WriteLine("\n--- WRITE ---");
Console.Write(nome);
Console.Write(idade);

Console.WriteLine();

//CONCATENAÇÃO (+)
Console.WriteLine("\n--- CONCATENAÇÃO (+) ---");
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos\n");

//INTERPOLAÇÃO DE STRINGS ($) ({}) (mais atual)
Console.WriteLine("\n--- INTERPOLAÇÃO ($ e {variavel}) ---");
Console.WriteLine($"{nome} tem {idade} anos");

//PLACE HOLDERS (antigo)
Console.WriteLine("\n--- PLACE HOLDER ({0}, variavel) ---");
Console.WriteLine("{0} tem {1} anos", nome, idade);


Console.ReadLine();