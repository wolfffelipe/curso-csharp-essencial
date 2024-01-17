Console.WriteLine("Operadores Relacionais\n\n");

int x = 10;
int y = 20;
bool resultado = x == y;
string a = "curso";
string b = "Curso";


Console.WriteLine($"\n------> x = {x} e y = {y}\n");

Console.WriteLine($"x == y : {x==y}");
Console.WriteLine($"x != y : {x!=y}");
Console.WriteLine($"x < y : {x<y}");
Console.WriteLine($"x <= y : {x<=y}");
Console.WriteLine($"x > y : {x>y}");
Console.WriteLine($"x >= y : {x>=y}");
Console.WriteLine($"Resultado x == y : {resultado}");

Console.WriteLine($"\n\n------> a = {a} e b = {b}");

Console.WriteLine($"\na == b : {a == b}"); // == é o único que pode ser utilizado com strings
Console.WriteLine($"a.Equals(b) : {a.Equals(b)}"); // com Equals

