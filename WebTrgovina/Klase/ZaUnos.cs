using WebTrgovinaLibrary.Enumeracija;
using WebTrgovinaLibrary.Klase;

namespace WebTrgovina.Klase;

public static class ZaUnos
{
    public static void DodajArtikl(List<Artikl> odjeca)
    {
        ZaIspis.IspisiZaglavlje();
        Console.WriteLine("\tUnos artikla:\n\t1 - majica\n\t2 - hlača\n\t3 - košulja");
        Console.Write("\tVaš odabir: ");
        string odabir = ""+Console.ReadLine();

        switch (odabir)
        {
            case "1":
                decimal cijenaMajice = Pomocna.UnesiCijenu("Unesite cijenu majice: ");
                var materijalMajice = Pomocna.OdaberiEnum<Materijal>("Odaberite materijal: ");
                var spolMajice = Pomocna.OdaberiEnum<Spol>("Namijenjeno za: ");
                var vrstaMajice = Pomocna.OdaberiEnum<VrsteMajica>("Odaberite vrstu majice: ");
                var velicinaMajice = Pomocna.OdaberiEnum<VelicinaMajicaKosulja>("Odaberi veličinu: ");
                var bojaMajice = Pomocna.OdaberiEnum<Boja>("Boja majice: ");
                var kolicinaMajice = Pomocna.UnesiKolicinu("Koliko artikla ima na stanju: ");
                odjeca.Add(new MajicaKlasa(cijenaMajice, materijalMajice, spolMajice, vrstaMajice, velicinaMajice, bojaMajice, kolicinaMajice));
                ZaIspis.IspisiUspjesnoDodanArtikl(odjeca.Last());
                break;

            case "2":
                decimal cijenaHlaca = Pomocna.UnesiCijenu("Unesite cijenu hlaca: ");
                var materijalHlaca = Pomocna.OdaberiEnum<Materijal>("Odaberite materijal: ");
                var spolHlaca = Pomocna.OdaberiEnum<Spol>("Namijenjeno za: ");
                var vrstaHlaca = Pomocna.OdaberiEnum<VrsteHlaca>("Odaberite vrstu hlača: ");
                var velicinaHlaca = Pomocna.UnesiVelicinuHlaca("Unesite veličinu hlača: ");
                var bojaHlaca = Pomocna.OdaberiEnum<Boja>("Boja hlača: ");
                var kolicinaHlaca = Pomocna.UnesiKolicinu("Koliko artikla ima na stanju: ");
                odjeca.Add(new HlaceKlasa(cijenaHlaca, materijalHlaca, spolHlaca, vrstaHlaca, velicinaHlaca, bojaHlaca, kolicinaHlaca));
                ZaIspis.IspisiUspjesnoDodanArtikl(odjeca.Last());               
                break;

            case "3":
                decimal cijenaKosulje = Pomocna.UnesiCijenu("Unesite cijenu košulje: ");
                var materijalKosulje = Pomocna.OdaberiEnum<Materijal>("Odaberite materijal: ");
                var spolKosulje = Pomocna.OdaberiEnum<Spol>("Namijenjeno za: ");
                var vrstaKosulje = Pomocna.OdaberiEnum<VrstaKosulje>("Odaberite vrstu košulje: ");
                var velicinaKosulje = Pomocna.OdaberiEnum<VelicinaMajicaKosulja>("Odaberi veličinu: ");
                var bojaKosulje = Pomocna.OdaberiEnum<Boja>("Boja košulje: ");
                var kolicinaKosulja = Pomocna.UnesiKolicinu("Koliko artikla ima na stanju: ");
                odjeca.Add(new KosuljaKlasa(cijenaKosulje, materijalKosulje, spolKosulje, vrstaKosulje, velicinaKosulje, bojaKosulje, kolicinaKosulja));
                ZaIspis.IspisiUspjesnoDodanArtikl(odjeca.Last());
                break;

            default:
                Console.WriteLine("\tPogrešan odabir artikla za unos.");
                break;
        }
    }
}
