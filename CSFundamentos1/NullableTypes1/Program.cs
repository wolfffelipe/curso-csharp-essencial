Console.WriteLine("Nullable Types");

int valor = 100;
//int valor2 = null;

// nullables...
Nullable<int> a = null;
Nullable<double> b = null;
Nullable<bool> c = null;
// ou...
int? x = null;
int? y = 1;
int? z = null;

// Operador de Coalescência Nula ??
// Se x é null atribui 0, senão atribui x
int w = x ?? 0; 
int k = y ?? 0;

// outro exemplo...
int? num1 = 4;
int? num2 = 3; // sem ? não funcionaria
int? num3 = num1 * num2; // sem ? não funcionaria

Console.WriteLine(valor);
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(x.HasValue);
Console.WriteLine(y.HasValue);
Console.WriteLine(z.HasValue);
Console.WriteLine(w);
Console.WriteLine($"num3 = {num3.Value}");
Console.WriteLine("num3 = " + num3.Value);

Console.ReadKey();
