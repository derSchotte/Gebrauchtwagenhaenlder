namespace Gebrauchtwagenhaenlder.Klassen
{
    //3)
    // Entwicklen Sie eine Klasse "Rechnung" mit folgenden
    // Informationen:
    // Kunde, Auto, Datum, Preis, die Anzahl aller Rechnungen

    // TIP: Die Anzahl der Rechnungen wäre ein guter Kandidat
    // für ein statisches Feld.

    //3.1)
    // Erstellen Sie eine Methode "Ausgabe", welche alle
    // Informationen der Klasse "Rechnung" ausgibt.

    internal class Rechnung
    {
        Kunde kunde;
        Auto auto;
        DateOnly datum;
        decimal preis;
        int rechnungsNummer;

        public static List<Rechnung> rechnungen = new List<Rechnung> {
            new( new( "Peter", "Lustig", "Musterstraße", "84/2", 12345, "Musterstadt", "peter.lustig@lachen.de" ),
                    new( "Sunzuka", "p1-200", 24, "Neuwagen, Klima, ABS, ESP, Sitzheizung", new( 2022, 01, 01 ) ),
                    new( 2022, 11, 15 ), 89999m, 1 ),

            new(new("Steffie", "Traurig", "Raufboldstraße", "2b", 34543, "Spasshausen", "s.traurig@web.de"),
                    new("BSW","K4", 283943,"Alter Mistwagen, Klappert, Unfälle mit ner Kuh, Klima ja, aber geht nicht",new(1888,05,05)),
                    new(2020,04,01),24.95m,2),

            new(new("Fritz", "Kind", "Dorfweg", "69", 39874, "Dorfingen", "fritz.kind@eigenbau.de"),
                    new("SauWee","Fols", 283943,"Alter Mistwagen, Klappert, Unfälle mit ner Kuh, Klima ja, aber geht nicht",new(2002,03,15)),
                    new(2020,04,01),2500m,3),

            new(new("Hans", "Müller", "Werner-Bolding-straße", "125/5", 67543, "Niederburg", ""),
                    new("Lamporgani","cloud", 2834,"Bisl gefahren, aber dafür schnell, klappert etwas am ende",new(2001,08,15)),
                    new(2021,02,11),244500.95m,4),

            new(new("Claudia", "Falte", "Egg-Street", "222b", 12392, "Filten", "c.falte@fast-cleaner.de"),
                    new("Ausi","A100", 24,"Neuwagen, Klima, ABS, ESP, Sitzheizung, Selbstfahrend, KI gesteuert",new(2020,09,24)),
                    new(2022,07,11),84456.95m,5),
        };


        public Rechnung(Kunde kunde, Auto auto, DateOnly datum, decimal preis, int rechnungsNummer)
        {
            this.kunde = kunde;
            this.auto = auto;
            this.datum = datum;
            this.preis = preis;
            this.rechnungsNummer = rechnungsNummer;
        }

        public void Ausgabe()
        {
            Console.WriteLine($"RechnungsNr:\t{rechnungsNummer}");
            kunde.Ausgabe();
            Console.WriteLine();
            auto.Ausgabe();
            Console.WriteLine($"\nDatum:\t\t{datum}\n" +
                $"Preis:\t\t{preis} EUR\n");
        }
    }
}
