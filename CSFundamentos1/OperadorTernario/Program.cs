Console.WriteLine("##### Operador UNIÁRIO\n");

int positivo = 1;
int resultado;
resultado = -positivo;
Console.WriteLine($"Negativo: {resultado}");


Console.WriteLine("\n##### Operador TERNÁRIO\n");

Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToDouble(Console.ReadLine());
var result_temp = temp > 27 ? "quente" : "normal";

var result_temp2 =  temp >= 27 ? "quente" :
                    temp <= 15 ? "frio" : /* : ... : ... : ... */ "normal";

Console.WriteLine($"O tempo está {result_temp}");
Console.WriteLine($"O tempo está {result_temp2}");

Console.ReadKey();

