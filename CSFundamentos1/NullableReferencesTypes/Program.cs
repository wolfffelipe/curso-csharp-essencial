Console.WriteLine("Tipos de referências anuláveis\n\n");

//string nome = null;
//Console.WriteLine(nome);
//Console.WriteLine(nome.ToUpper()); // Erro

string? nome = null;
Console.WriteLine(nome?.ToUpper()); // ?. <- Null Conditional Operator

string sobrenome = "";
Console.WriteLine(sobrenome?.ToUpper());

Console.ReadKey();