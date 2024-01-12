Console.WriteLine("Datetime");

DateTime dataAtual = DateTime.Now;
DateTime dataEspec = new DateTime(1991, 05, 06);
DateTime dataEspecHr = new DateTime(1991, 05, 06, 10, 0, 0);

Console.WriteLine(dataAtual);
Console.WriteLine(dataEspec);
Console.WriteLine(dataEspecHr);

// Estrair informações da data atual

Console.WriteLine();

Console.WriteLine(dataAtual.Year);
Console.WriteLine(dataAtual.Month);
Console.WriteLine(dataAtual.Day);
Console.WriteLine(dataAtual.Hour);
Console.WriteLine(dataAtual.Minute);
Console.WriteLine(dataAtual.Second);
Console.WriteLine(dataAtual.Millisecond);
Console.WriteLine(dataAtual.DayOfWeek);
Console.WriteLine(dataAtual.DayOfYear);

Console.WriteLine();

Console.WriteLine(dataAtual.AddDays(30));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddHours(2));
Console.WriteLine(dataAtual.AddYears(5));

Console.WriteLine();

Console.WriteLine(dataAtual.ToLongDateString());
Console.WriteLine(dataAtual.ToShortDateString());
Console.WriteLine(dataAtual.ToLongTimeString());
Console.WriteLine(dataAtual.ToShortTimeString());