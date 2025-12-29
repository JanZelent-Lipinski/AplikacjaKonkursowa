using System.Text.RegularExpressions;

public class WyciaganieEmaila
{
    public string PobierzEmail(string tekst)
    {
        var wzorzec = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        var match = Regex.Match(tekst, wzorzec);

        if (match.Success)
            return match.Value;

        return "Nie znaleziono adresu email.";
    }
}
//Ta klasa rozpoznaje email w podanym tekście za pomocą wyrażeń regularnych.