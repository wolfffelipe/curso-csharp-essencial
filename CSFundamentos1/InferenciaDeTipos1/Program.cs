Console.WriteLine("Inferência de tipos\n");

int idade = 25;
string nome = "Maria";
decimal salario = 2500.00m;

Console.WriteLine($"{nome} tem {idade} anos e ganha {salario}");
Console.WriteLine(salario.ToString("c"));

var idade2 = 25;
var nome2 = "Maria";
var salario2 = 2500.00m;

/* ERROS:
var titulo;
var titulo = null;
var titulo, descricao, outro;
*/

Console.WriteLine();

Console.WriteLine($"{nome2} tem {idade2} anos e ganha {salario2}");
Console.WriteLine(salario2.ToString("c"));



var teste = new Teste();
teste.MeuMetodo();

Console.ReadKey();

class Teste
{
    public void MeuMetodo() {
        Console.WriteLine("Meu método");
    }
}