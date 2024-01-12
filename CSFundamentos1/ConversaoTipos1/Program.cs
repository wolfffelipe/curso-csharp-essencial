Console.WriteLine("Conversão de tipos\n");

// CONVERSÃO IMPLÍCITA (bytes menos para bytes maiores é possível)
int varInt = 2145678;
long varLong = varInt;
float varFloat = varInt;
double varDouble = varInt;
decimal varDecimal = varInt;

Console.WriteLine(varInt);
Console.WriteLine(varLong);
Console.WriteLine(varFloat);
Console.WriteLine(varDouble);
Console.WriteLine(varDecimal);

//CONVERSÃO EXPLÍCITA (int)double <- chamado de CAST
double varDouble2 = 12.345;     // 8 bytes
int varInt2 = (int)varDouble2;    // 4 bytes

Console.WriteLine(varInt2);

int num1 = 10;
int num2 = 4;
//float resultado = (float)num1 / (float)num2; // 2.5
float resultado = (float) num1 / num2; // <- ou

Console.WriteLine(resultado);

Console.ReadLine();