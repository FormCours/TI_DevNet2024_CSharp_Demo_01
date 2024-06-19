// ↓ Rend accessible les types du namespace
using Demo04.Models;

Car c1;
c1.Brand = "Audi";
c1.Model = "A3";
c1.nbDoor = 3;
c1.Power = 90;
c1.Color = "Noir";

Console.WriteLine(c1.Brand + " " + c1.Model);