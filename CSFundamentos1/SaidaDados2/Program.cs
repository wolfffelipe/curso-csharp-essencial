Console.WriteLine("Saída de Dados 2 : Usando Sequência de Escapes\n");

string local = "c:\\dados\\poesias";
string frase = "Ele falou: \"Não fui eu\"";

Console.WriteLine(local);
Console.WriteLine(frase);

string pizza = "\nPizza\nde\ncalabresa";
string bolo = "\nBolo\tde\tchocolate";
string pao = "\nPao\vde\vforma";

Console.WriteLine(pizza);
Console.WriteLine(bolo);
Console.WriteLine(pao);

int? resposta = null;

Console.WriteLine("Digite \"1\" para tocar um som e \"0\" para não tocar: ");
resposta = Convert.ToInt32(Console.ReadLine());

if  (resposta == 1)
{
    Console.WriteLine("\a");
}
else if (resposta == 0)
{
    Console.WriteLine("Sem som por aqui");
}
else
{
    Console.WriteLine("Ok, nem 1 e nem 0");
}