using Microsoft.VisualBasic;

namespace Gebrauchtwagenhaenlder {
    // 2)
    // Entwickeln Sie eine Klasse "Auto" mit folgenden
    // Informationen:
    // Hersteller, Modell, Kilometerstand, Besonderheiten,
    // Baujahr
    
    // 2.1)
    // Erstellen Sie eine Methode "Ausgabe", welche alle
    // Informationen der Klasse "Auto" ausgibt.

    internal class Auto {
        string hersteller;
        string model;
        int kilometerstand;
        string besonderheiten;
        DateOnly baujahr;

        public Auto( string hersteller, string model, int kilometerstand, string besonderheiten, DateOnly baujahr ) {
            this.hersteller = hersteller;
            this.model = model;
            this.kilometerstand = kilometerstand;
            this.besonderheiten = besonderheiten;
            this.baujahr = baujahr;
        }

        public void Ausgabe() {
            Console.WriteLine($"Hersteller:\t{hersteller}\n" +
                $"Model:\t\t{model}\n" +
                $"Kilometerstand:\t{kilometerstand}\n" +
                $"Baujahr:\t{baujahr}\n" +
                $"Besonderheiten:\t{besonderheiten}");
        }
    }
}
