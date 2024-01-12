internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Tipos string, object e dynamic");

        string curso = "Curso Essencial";
        string nome = "Felipe";
        //StringBuilder é melhor caso tenha alterações (será visto depois)

        object nota = 10;
        object valor = 8.55m;
        object outronome = "Maria";

        dynamic nota2 = 10;
        dynamic valor2 = 8.55m;
        dynamic outronome2 = "Maria";

        nome = "Felipe Wolff";

        Console.WriteLine(curso);
        Console.WriteLine(nome);

        Console.WriteLine(nota);
        Console.WriteLine(valor);
        Console.WriteLine(outronome);

        Console.WriteLine(nota2);
        Console.WriteLine(valor2);
        Console.WriteLine(outronome2);

        Console.ReadLine();
    }
}