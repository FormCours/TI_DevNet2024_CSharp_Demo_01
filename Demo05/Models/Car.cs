namespace Demo05.Models
{
    public struct Car
    {
        public string Brand;
        public string Model;
        public int Power;
        public string Number;

        // Procedure (Méthode qui ne renvoi rien)
        public void Start()
        {
            Console.WriteLine($"La voiture \"{Number}\" démarre");
        }

        // Fonction (Méthode qui renvoi une donnée)
        public string GetIdentificator()
        {
            return $"{Brand} {Model} ({Number})";
        }
    }
}
