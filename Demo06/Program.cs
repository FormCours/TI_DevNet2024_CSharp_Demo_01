using Demo06.CustomEnums;

// Déclarer une variable du type de l'enum
PieceEnum p1 = PieceEnum.Reine;

// Parcourir les valeurs de l'enum
Console.WriteLine("Valeur 1");
foreach (int val in Enum.GetValues(typeof(PieceEnum)) )
{
    Console.WriteLine($" - {val} / {(PieceEnum)val}");
}
Console.WriteLine();

Console.WriteLine("Valeur 2");
foreach (int val in Enum.GetValues<PieceEnum>() )
{
    Console.WriteLine($" - {val} / {(PieceEnum)val}");
}
Console.WriteLine();

// Parcourir les noms de l'enum
Console.WriteLine("Nom 1");
foreach (string name in Enum.GetNames(typeof(PieceEnum)) )
{
    Console.WriteLine($" - {name}");
}
Console.WriteLine();

Console.WriteLine("Nom 2");
foreach (string name in Enum.GetNames<PieceEnum>() )
{
    Console.WriteLine($" - {name}");
}
Console.WriteLine();
