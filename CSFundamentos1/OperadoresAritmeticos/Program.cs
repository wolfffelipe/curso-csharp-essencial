Console.WriteLine("OPERADORES ARITMÉTICOS\n");

Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"x + y = { x + y }");
Console.WriteLine($"x - y = { x - y }");
Console.WriteLine($"x * y = { x * y }");
Console.WriteLine($"x / y = { x / y }");
Console.WriteLine($"x % y = { x % y }");

double divisao = (double) x / y;

Console.WriteLine($"x / y = {divisao} (desta vez com double)");

Console.WriteLine("\n\nCLASSE MATH\n");

Console.WriteLine($"Raiz quadrada de x = \t\t {Math.Sqrt(x)}");
Console.WriteLine($"Potência de x elevado a y = \t {Math.Pow(x,y)}");
Console.WriteLine($"Valor mínimo entre x e y = \t {Math.Min(x,y)}");
Console.WriteLine($"Valor máximo entre x e y = \t {Math.Max(x,y)}");
Console.WriteLine($"Cosseno de x = \t\t\t {Math.Cos(x)}");
Console.WriteLine($"Seno de x = \t\t\t {Math.Sin(x)}");
Console.WriteLine($"Exponencial de x = \t\t {Math.Exp(x)}");