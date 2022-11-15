using Gebrauchtwagenhaenlder.Klassen;

namespace Gebrauchtwagenhaenlder
{
    internal static class Menu {
        public static void MainMenu() {
            int eingabe;

            Console.WriteLine("Welche Rechnung wollen sie sich anschauen?");
            Console.WriteLine($"RechnungNr: [1] - [{Rechnung.rechnungen.Count()}]");
            Console.Write( "Eingabe: " );
            eingabe = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Rechnung.rechnungen[ eingabe - 1 ].Ausgabe();
        }
    }
}
