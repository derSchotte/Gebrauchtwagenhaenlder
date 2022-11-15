namespace Gebrauchtwagenhaenlder {
    internal static class Menu {
        public static void MainMenu() {
            int eingabe;

            Console.WriteLine("Welche Rechnung wollen sie sich anschauen?");
            Console.WriteLine($"[1] - [{Rechnung.rechnungen.Count()}]");
            eingabe = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Rechnung.rechnungen[ eingabe ].Ausgabe();
            ;
        }
    }
}
