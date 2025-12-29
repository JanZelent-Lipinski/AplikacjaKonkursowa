public class SzyfrCezara
{
    public string Odszyfruj(string tekst, int przesuniecie)
    {
        string wynik = "";
        tekst = tekst.ToUpper();

        foreach (char znak in tekst)
        {
            if (znak >= 65 && znak <= 90)
            {
                int kod = znak + przesuniecie;


                if (kod > 90) kod -= 26;
                if (kod < 65) kod += 26;

                wynik += (char)kod;
            }
            else
            {
                wynik += znak;
            }
        }

        return wynik;
    }
}
