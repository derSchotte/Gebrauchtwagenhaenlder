using Microsoft.VisualBasic;

namespace Gebrauchtwagenhaenlder.Klassen
{
    // 1)
    // Entwickeln Sie eine Klasse "Kunde" mit folgenden
    // Informationen:
    // Name, Adresse, Telefonnummer, Email

    // 1.1)
    // Erstellen Sie eine Methode "Ausgabe", welche alle
    // Informationen der Klasse "Kunde" ausgibt.

    internal class Kunde
    {
        string vorname;
        string nachname;
        string strassenName;
        string hausNummer;
        int plz;
        string ort;
        string email;

        public Kunde(string vorname, string nachname, string strassenName, string hausNummer, int plz, string ort, string email)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.strassenName = strassenName;
            this.hausNummer = hausNummer;
            this.plz = plz;
            this.ort = ort;
            this.email = email;
        }

        public void Ausgabe()
        {
            Console.WriteLine($"Vorname:\t{vorname} {nachname}\n" +
                $"Anschrift:\t{strassenName} {hausNummer}\n" +
                $"\t\t{plz} {ort}\n" +
                $"EMail:\t\t{email}");
        }
    }
}
