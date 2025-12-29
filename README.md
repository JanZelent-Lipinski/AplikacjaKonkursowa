Jest to aplikacja zgodna z wymaganiami zawartymi w poleceniu zadania.
Aplikacja jest napisana w c# i wykorzysuje API Google do rozpoznawania języka.
Postanowiłem zostawić plik .env poza plikiem .gitignore ponieważ myslę, że łatwiej będzie Państwu przetestować aplikację. Wystarczy tylko wkleić tam klucz API który przesyłam Państwu mailem.
Mając już plik .env postanowiłem sparametryzować również tekst, który tłumaczymy.

Wszystkie klasy starałem się utrzymać tak proste jak to tylko możliwe.
Dbając o czytelność kodu postanowiłem rozbić funkcjonalności na osobne klasy zgodnie z (SRP)

Instrukcja:

Wymagane: .NET SDK

Projekt korzysta z NuGet packages:

- Google.Apis.Translate.v2
- dotenv.net

Po pobraniu repo:
!!!!!Proszę wkleić klucz API, który przekazałem Państwu mailem do pliku .env!!!!!

Uruchomić:

- dotnet restore
- dotnet run
