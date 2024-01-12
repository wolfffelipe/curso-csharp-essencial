Console.WriteLine("Conversão de String");

int a = 123;
double b = 12.34;
decimal c = 12.456m;
bool d = true;

/* TO STRING */
string s1 = a.ToString();
string s2 = b.ToString();
string s3 = c.ToString();

Console.WriteLine(s1);
Console.WriteLine(s2);
Console.WriteLine(s3);

Console.WriteLine(Convert.ToString(a));
Console.WriteLine(Convert.ToString(d));

/* 
OUTROS... (Convert.)
---------
ToBoolean
ToChar
ToInt16
ToInt32
ToString
*/

/* OVERFLOW EXCEPTION */

int grande = 100000;
Console.WriteLine(Convert.ToByte(grande));

Console.ReadLine();
