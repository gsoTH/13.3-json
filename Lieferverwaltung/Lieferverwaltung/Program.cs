namespace Lieferverwaltung
{
    class Program
    {
         
        static void Main(string[] args)
        {
            List<Lieferung> lieferungen = new List<Lieferung>();
            
            BeispielobjekteAnlegen(lieferungen);
            ErzeugeJSON(lieferungen);
        }

        static void BeispielobjekteAnlegen(List<Lieferung> originaleListe)
        {
            originaleListe.Add(new Lieferung(
                new DateOnly(2024, 06,22)
                , "HHX05NNW0ZP"
                , "86309"
            ));
            
            originaleListe.Add(new Lieferung(
                new DateOnly(2024, 09, 4)
                , "GSV18EDC4BR"
                , "91139"
            ));
            
            originaleListe.Add(new Lieferung(
                new DateOnly(2023, 04, 8)
                , "CQX55KMY5RW"
                , "07708"
            ));
        }

        static void ErzeugeJSON(List<Lieferung> lieferungen)
        {
            throw new NotImplementedException();
            // TODO: Datei erzeugen
            // TODO: Anzahl der Objekte in Datei eintragen
            // TODO: Alle Objekte in Datei auflisten
        }
    }
}
