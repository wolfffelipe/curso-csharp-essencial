Console.WriteLine("Tipos de referências anuláveis\n\n");

//string nome = null;
//Console.WriteLine(nome);
//Console.WriteLine(nome.ToUpper()); // Erro

string? nome = null;
Console.WriteLine(nome?.ToUpper());

string sobrenome = "";
Console.WriteLine(sobrenome?.ToUpper());

Console.ReadKey();