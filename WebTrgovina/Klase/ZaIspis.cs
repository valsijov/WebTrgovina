using WebTrgovinaKupci.Klase;
using WebTrgovinaLibrary.Klase;

namespace WebTrgovina.Klase;

public static class ZaIspis
{
    public static void IspisiZaglavlje()
    {
        Console.Clear();
        Console.WriteLine("\t[  WEB SHOP  ]");
    }
    public static void IspisiMenu()
    {
        Console.WriteLine("\t+-----------------------------------------------------------+\n" +
                          "\t|     Odaberite opciju:                                     |\n" +
                          "\t|     1 - Unos novog artikla                                |\n" +
                          "\t|     2 - Prikaži sve artikle                               |\n" +
                          "\t|     3 - Filtrirani prikaz                                 |\n" +
                          "\t|     4 - Prikaži narudžbe                                  |\n" +
                          "\t|     0 - Izlaz iz aplikacije                               |\n" +
                          "\t+-----------------------------------------------------------+\n");
        Console.Write("\tVaš odabir: ");
    }
    public static void IspisiSveArtikle(List<Artikl> odjeca)
    {
        foreach (var artikl in odjeca.OrderBy(a => a.Sifra))
        {
            Console.WriteLine(artikl);            
        }
    }
    public static void IspisiUspjesnoDodanArtikl(Artikl artikl)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\tNovi artikl uspješno dodan.");
        Console.WriteLine(artikl);
        Console.ResetColor();
    }

    public static void FiltrirajIspis(List<Artikl> odjeca)
    {
        ZaIspis.IspisiZaglavlje();
        Console.WriteLine("\tOdaberite opciju po kojoj želite filtrirati ispis:\n" +
                          "\t1 - majice\n" +
                          "\t2 - košulje\n" +
                          "\t3 - hlače");
        Console.Write("\tVaš odabir: ");
        string odabir = ""+Console.ReadLine();
        if(odabir == "1")
        {
            foreach (var artikl in odjeca.OfType<MajicaKlasa>().OrderBy(a => a.Sifra))
            {
                Console.WriteLine(artikl);                
            }
        }
        else if (odabir == "2")
        {
            foreach (var artikl in odjeca.OfType<KosuljaKlasa>())
            {
                Console.WriteLine(artikl);
            }
        }
        else if (odabir == "3")
        {
            foreach (var artikl in odjeca.OfType<HlaceKlasa>())
            {
                Console.WriteLine(artikl);
            }
        }
        else
        {
            Console.WriteLine("Pogrešan unos.");
        }
    }
    // NISAM ZAVRŠIO ISPIS NARUDŽBE
    public static void IspisiNarudzbu(List<Kupac> kupci, List<Narudzba> narudzbe, List<Artikl> odjeca)
    {
        foreach (var narudzba in narudzbe)
        {
            var kupac = kupci.FirstOrDefault(k => k.Id == narudzba.IdKupca);
            if (kupac != null)
            {
                Console.WriteLine($"\tKupac: {kupac.Ime} {kupac.Prezime}\tAdresa: {kupac.Adresa}");
                Console.WriteLine($"\tNarudžba br. {narudzba.IdNarudzbe}");

                foreach (var stavka in narudzba.NaruceneStavke)
                {
                    var narucenaOdjeca = odjeca.FirstOrDefault(k => k.Sifra == stavka.SifraArtikla);
                    if (narucenaOdjeca != null)
                    {
                        Console.WriteLine(narucenaOdjeca);
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine($"Kupac s ID {narudzba.IdKupca} nije pronađen!");
            }
        }
    }

}
