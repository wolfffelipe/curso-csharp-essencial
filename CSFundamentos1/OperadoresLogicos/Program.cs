Console.WriteLine("Operadores Lógicos\n\n");

/*
 * && AND
 * || OR
 * ! NOT
 */

bool V = true;
bool F = false;

Console.WriteLine("--- AND ---\n\n");

Console.WriteLine($"V \t&& \tF \t: {V && F}");
Console.WriteLine($"!V \t&& \tF \t: {!V && F}");
Console.WriteLine($"V \t&& \t!F \t: {V && !F}");
Console.WriteLine($"!(V \t&& \tF) \t: {!(V && F)}");

Console.WriteLine("\n\n--- OR ---\n\n");

Console.WriteLine($"V \t|| \tF \t: {V || F}");
Console.WriteLine($"!V \t|| \tF \t: {!V || F}");
Console.WriteLine($"V \t|| \t!F \t: {V || !F}");
Console.WriteLine($"!(V \t|| \tF) \t: {!(V || F)}");