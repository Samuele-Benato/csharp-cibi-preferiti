namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] favoriteFood = { "Gelato", "Sushi", "Pizza", "Pasta", "Hamburger" };

            Console.WriteLine($"Lunghezza della classifica: {favoriteFood.Length}");

            Console.WriteLine("La mia classifica:");

            for (int i = 0; i < favoriteFood.Length; i++)
            {
                Console.WriteLine($"{(i + 1)} - {favoriteFood[i]}");
            }

            Console.WriteLine($"Il mio cibo top:{favoriteFood[0]}");

            Console.WriteLine($"Il mio cibo meno preferito: {favoriteFood[favoriteFood.Length - 1]}");
        }
    }
}
