namespace csharp_cibi_preferiti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inizializzazione dell'array con i miei cibi preferiti
            string[] favoriteFood = { "Gelato", "Sushi", "Pizza", "Pasta", "Hamburger" };

            // Stampa della lunghezza della classifica
            Console.WriteLine($"Lunghezza della classifica: {favoriteFood.Length}");

            // Stampa della classifica con posizione
            Console.WriteLine("La mia classifica:");

            for (int i = 0; i < favoriteFood.Length; i++)
            {
                Console.WriteLine($"{(i + 1)} - {favoriteFood[i]}");
            }

            // Stampa del cibo preferito (prima posizione della classifica)
            Console.WriteLine($"Il mio cibo preferito: {favoriteFood[0]}");

            // Inizializzazione del cibo di mezza classifica
            int middlePosition = favoriteFood.Length / 2;

            if (favoriteFood.Length % 2 == 0) // Se la lunghezza è pari
            {
                // Stampa del cibo di metà classifica
                Console.WriteLine($"Il cibo di mezza classifica: {favoriteFood[middlePosition - 1]} e {favoriteFood[middlePosition]}");
            }
            else // Se la lunghezza è dispari
            {
                // Stampa del cibo di metà classifica
                Console.WriteLine($"Il cibo di mezza classifica: {favoriteFood[middlePosition]}");
            }

            // Stampa del cibo meno preferito (ultima posizione della classifica)
            Console.WriteLine($"Il mio cibo meno preferito: {favoriteFood[favoriteFood.Length - 1]}");
        }
    }
}
