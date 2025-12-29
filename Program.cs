
using dotenv.net;

class Program
{
    static void Main()
    {

        DotEnv.Load(new DotEnvOptions(probeForEnv: true));

        string? tekst = Environment.GetEnvironmentVariable("TEKST");

        if (string.IsNullOrWhiteSpace(tekst))
        {
            Console.WriteLine("Brak wartości TEKST w pliku .env");
            return;
        }

        SzyfrCezara szyfr = new SzyfrCezara();
        WyciaganieEmaila emailer = new WyciaganieEmaila();
        WykrywaniePolskiego detektor = new WykrywaniePolskiego();

        List<string> odszyfrowania = new List<string>();

        Console.WriteLine("------ Wykonuję brute-force ------\n");

        for (int p = 0; p < 26; p++)
        {
            string wynik = szyfr.Odszyfruj(tekst, p);
            odszyfrowania.Add(wynik);
            Console.WriteLine($"[{p}] {wynik}");
            Console.WriteLine("-----------------------------------");
        }

        Console.WriteLine("\n------ Sprawdzam jezyk przez Google API ------");

        foreach (var wynik in odszyfrowania)
        {
            if (detektor.CzyPolski(wynik))
            {
                Console.WriteLine($"\n=== Wykryto polski tekst ===\n{wynik}");

                string email = emailer.PobierzEmail(wynik);

                Console.WriteLine("\nEmail:");
                Console.WriteLine(email);


                using (StreamWriter sw = new StreamWriter("wynik.txt"))
                {
                    sw.WriteLine("=== Odszyfrowana wiadomosc ===");
                    sw.WriteLine(wynik);

                }

                Console.WriteLine("\nWynik zapisano do: wynik.txt");
                return;
            }
        }

        Console.WriteLine("\nNie znaleziono tekstu PL.");
    }
}
// Punkt startowy programu. Wczytuje dane z .env, wykonuje bruteForce szyfru Cezara,
// wykrywa polski tekst, wyciąga email i zapisuje wynik do pliku.
