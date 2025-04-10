namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] tablica = new int[50 + 1];
            for (int i = 0; i < 50; i++)
                tablica[i] = rnd.Next(1, 101);

            Console.Write("Podaj szukaną liczbę: ");
            int szukana = int.Parse(Console.ReadLine());

            int indeks = PrzeszukajZWartownikiem(tablica, szukana);

            Console.WriteLine("Zawartość tablicy:");
            for (int i = 0; i < tablica.Length - 1; i++)
                Console.Write(tablica[i] + ", ");

            if (indeks == -1)
                Console.WriteLine("\nNie znaleziono liczby w tablicy.");
            else
                Console.WriteLine($"\nZnaleziono liczbę {szukana} na pozycji {indeks}.");


        }

        static int PrzeszukajZWartownikiem(int[] tablica, int x)
        {
            int n = tablica.Length - 1;
            tablica[n] = x;

            int i = 0;
            while (tablica[i] != x)
                i++;

            if (i == n)
                return -1;
            else
                return i;
        }
    }
}