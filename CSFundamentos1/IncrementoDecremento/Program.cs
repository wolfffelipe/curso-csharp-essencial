int x = 10;


Console.WriteLine("\n\n###Incremento ++###\n");
x++;
Console.WriteLine(x);


Console.WriteLine("\n\n###Decremento --###\n");
x--;
Console.WriteLine(x);


Console.WriteLine("\n\n###Pos Incremento y++###\n"); //mesma coisa com decremento
int y = 0;
int resultado = y++ + 10; // = 10
Console.WriteLine($"Resultado: {resultado} | y: {y}");


Console.WriteLine("\n\n###Pre Incremento ++y###\n"); //mesma coisa com decremento
y = 0;
resultado = ++y + 10; // = 11
Console.WriteLine($"Resultado: {resultado} | y: {y}");


Console.ReadKey();