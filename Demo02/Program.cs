const int NB_COUNT = 5;


Console.WriteLine("For -> 'Pour' en PseudoCode");
for(int i = 0; i < NB_COUNT; i++)
{
    Console.WriteLine($" - for {i}");
}

Console.WriteLine("While -> 'Tant que' ");
int count1 = 0;
while(count1 < NB_COUNT)
{
    Console.WriteLine($" - while {count1}");
    count1++;
}

Console.WriteLine("Do .. While -> 'Faire .. tant que'" );
int count2 = 0;
do
{
    Console.WriteLine($" - do..while {count2}");
    count2++;
}
while(count2 < NB_COUNT);


