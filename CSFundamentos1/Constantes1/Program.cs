Console.WriteLine("Constantes\n\n");
Console.WriteLine("Frequentemente usado em cálculos financeiros\n\n");

const int ANO_ATUAL = 2024;
const int QTD_DIA_SEMANA = 7, QUINZENA = 15;

Console.WriteLine($"Ano {ANO_ATUAL} / Dias na semana {QTD_DIA_SEMANA} / Quinzena {QUINZENA}\n\n");

double raio, perimetro, area;
const double PI = 3.14;

Console.WriteLine("Informe o raio do circulo: ");
raio = Convert.ToDouble(Console.ReadLine());

perimetro = 2 * PI * raio;
area = PI * raio * raio;

Console.WriteLine($"\n\n###Com constante###\n");
Console.WriteLine($"Perimetro: {perimetro}");
Console.WriteLine($"Area: {area}");

perimetro = 2 * Math.PI * raio;
area = Math.PI * Math.Pow(raio,2);

Console.WriteLine($"\n\n###Com Math###\n");
Console.WriteLine($"Perimetro: {perimetro}");
Console.WriteLine($"Area: {area}");

Console.ReadKey();