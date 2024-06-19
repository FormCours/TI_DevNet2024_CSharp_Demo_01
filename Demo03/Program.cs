Console.WriteLine("Demo - Tableau (Array)");
Console.WriteLine("**********************\n");
{
    const int MAX_ELEMENT = 100;
    string[] names = new string[MAX_ELEMENT];

    Console.WriteLine($"Combien de personnes allez vous encoder (De 1 à {MAX_ELEMENT}) :");
    int nbElem;
    do
    {
        Console.Write("> ");
        nbElem = int.Parse(Console.ReadLine()!);
    }
    while (nbElem < 1 || nbElem > MAX_ELEMENT);
    Console.WriteLine();

    Console.WriteLine("Ajouter le nom des personnes :");
    for (int i = 0; i < nbElem; i++)
    {
        // Saisie
        Console.Write("> ");
        string input = Console.ReadLine()!;

        // Ajout dans le tableau
        names[i] = input;
    }
    Console.WriteLine();

    Console.WriteLine("Affichage des données : ");
    // Résultat attendu (Dans l'ordre d'encodage) :
    // Noms encodés : Riri > Fifi > Loulou > Della > 

    Console.Write("Noms encodés : ");
    for (int i = 0; i < nbElem; i++)
    {
        string name = names[i];

        Console.Write("{0} > ", name);
    }

}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


//*************************************************************************************************
Console.WriteLine("Demo - Collection");
Console.WriteLine("*****************\n");
{
    const int MAX_ELEMENT = 100;
    List<string> names = new List<string>();

    Console.WriteLine($"Combien de personnes allez vous encoder (De 1 à {MAX_ELEMENT}) :");
    int nbElem;
    do
    {
        Console.Write("> ");
        nbElem = int.Parse(Console.ReadLine()!);
    }
    while (nbElem < 1 || nbElem > MAX_ELEMENT);
    Console.WriteLine();

    Console.WriteLine("Ajouter le nom des personnes :");
    for (int i = 0; i < nbElem; i++)
    {
        // Saisie
        Console.Write("> ");
        string input = Console.ReadLine()!;

        // Ajout dans la liste
        names.Add(input);
    }
    Console.WriteLine();

    Console.WriteLine("Affichage des données : ");
    // Résultat attendu (Dans l'ordre d'encodage) :
    // Noms encodés : Riri > Fifi > Loulou > Della > 

    Console.Write("Noms encodés : ");
    foreach(string name in names)
    {
        Console.Write("{0} > ", name);
    }
    Console.WriteLine();

    Console.Write($"Autre solution : {string.Join(" > ", names)}");
}
Console.WriteLine();
