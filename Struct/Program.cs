namespace Structs
{
    struct Game
    {
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;
        public Game(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }
        public override string ToString()
        {
            return $"Name: {name}\nDeveloper: {developer}\nRating: {rating}\nRelease Date: {releaseDate}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game("The Legend of Zelda: Breath of the Wild", "Nintendo", 9.5, "March 3, 2017");

            Console.WriteLine(game1.ToString());
        }
    }
}