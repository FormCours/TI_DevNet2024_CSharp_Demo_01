// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Text;

Console.WriteLine("Hello, World!");


//var test = 2_147_483_650l;

//Console.WriteLine($"Valeur : {test} / Type : {test.GetType()}");



//double v1 = 0.1;
//double v2 = 0.2;
//double v3 = 0.3;

//bool comp = v1 + v2 == v3;
//Console.WriteLine(comp);
//Console.WriteLine(v1 + v2);
//Console.WriteLine(v3);


//// => Voici un "Oiseau" !

//string demo = @"Voici un ""Oiseau"" !";

//string path1 = "C:\\Users\\studentdot0600\\source\\repos\\Demo_Net";
//string path2 = @"C:\Users\studentdot0600\source\repos\Demo_Net";



// Démo StringBuilder

const int NB_COUNT = 100_000;

Stopwatch sw1 = new Stopwatch();
Stopwatch sw2 = new Stopwatch();

// Concat « str1 + str2 »
sw1.Start();
int count1 = 0;
string w1 = "Start -> ";
while (count1 < NB_COUNT)
{
    w1 = w1 + " Next, ";
    count1++;
}
sw1.Stop();

// Concat « StringBuidler »
sw2.Start();
int count2 = 0;
StringBuilder sb = new StringBuilder("Start -> ");
while (count2 < NB_COUNT)
{
    sb.Append(" Next, ");
    count2++;
}
string w2 = sb.ToString();
sw2.Stop();



Console.WriteLine($"Concat \"classique\" : {sw1.ElapsedMilliseconds}ms");
Console.WriteLine($"Concat StringBuilder : {sw2.ElapsedMilliseconds}ms");


