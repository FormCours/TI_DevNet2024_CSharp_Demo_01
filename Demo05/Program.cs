
using Demo05.Models;
using System.Net;

Car car1;
car1.Brand = "Lada";
car1.Model = "2107";
car1.Power = 59;
car1.Number = "42 Bis";


string t = car1.GetIdentificator();
Console.WriteLine("Voiture : " + t);

car1.Start();



MathHelper mh = new MathHelper();


mh.Multi(24, 5);
