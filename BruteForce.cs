public class BruteForce
{
    public void Uruchom(string tekst)
    {
        SzyfrCezara szyfr = new SzyfrCezara();

        for (int p = 0; p < 26; p++)
        {
            string wynik = szyfr.Odszyfruj(tekst, p);
            Console.WriteLine($"Przesuniecie {p}: {wynik}");
            Console.WriteLine("-----------------------------------  ");
        }
    }
}
// Ta klasa wykorzystuje metodę Odszyfruj z naszej klasy SzyfrCezara i zastosowuje ją dla
// możliwych przesunięć i wyświetla wyniki.