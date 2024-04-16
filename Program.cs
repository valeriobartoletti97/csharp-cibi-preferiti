namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string[] FavouriteFood =
            {
                "Pizza",
                "Carbonara",
                "Tiramisu",
                "Sushi",
                "Fiorentina",
                "Gelato",
                "Pasta al forno"
            };
            Console.WriteLine($"I miei piatti preferiti sono {FavouriteFood.Length}");
            for (int i = 0; i < FavouriteFood.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {FavouriteFood[i]}");
            }
            Console.WriteLine($"Il mio cibo preferito è la {FavouriteFood[0]}");
            Console.WriteLine($"Il mio cibo preferito ma non troppo è la {FavouriteFood[FavouriteFood.Length - 1]}");
            if (FavouriteFood.Length % 2 == 0)
            {
                int median = FavouriteFood.Length / 2;
                Console.WriteLine($"I cibi mediani sono {FavouriteFood[median]} e {FavouriteFood[median + 1]} ");
            }
            else
            {
                int median = FavouriteFood.Length / 2;
                Console.WriteLine($"Il cibo mediano è {FavouriteFood[median]}");
            }
        }
    }
}