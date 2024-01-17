Console.WriteLine("Precedência de Operadores\n\n");

var x = 10 - 2 * 3;
var y = (10 - 2) * 3;

Console.WriteLine($"10 - 2 * 3 = {x}");
Console.WriteLine($"(10 - 2) * 3 = {y}");

bool b = !(9 != 8) && (5 >= 7 || 8 >= 6);

Console.WriteLine(b);

int var1 = 5, var2 = 6, var3 = 4;

int r = --var1 * var2 - ++var3;

Console.WriteLine(r);

Console.ReadKey();

//  Ordem de precedência
//  =, *=, /=, %=, +=, -=
//  ++, --
//  *, /, %, +, -
//  <, >, <=, =>, ==, !=
//  !, &&, ||
