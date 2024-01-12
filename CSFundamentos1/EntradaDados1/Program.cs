Console.WriteLine("Entrada de dados 1\n");

/* READLINE */
Console.WriteLine("\nInforme o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Informe idade:");
int idade = Convert.ToInt32(Console.ReadLine()); //readline só aceita string, por isso deve-se converter

Console.WriteLine($"Nome: {nome} e {idade} anos\n");

/* READ (um caractere) */
Console.WriteLine("Irá retornar o código ASCI do primeiro caractere digitado:");
int nota = Console.Read();

Console.WriteLine($"ASCI {nota}");

/* READKEY (pausa de tela) */
Console.ReadKey();
