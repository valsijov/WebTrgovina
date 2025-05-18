using WebTrgovinaLibrary.Klase;
using static WebTrgovinaLibrary.Enumeracija.Materijal;
using static WebTrgovinaLibrary.Enumeracija.Spol;
using static WebTrgovinaLibrary.Enumeracija.VrsteMajica;
using static WebTrgovinaLibrary.Enumeracija.VelicinaMajicaKosulja;
using static WebTrgovinaLibrary.Enumeracija.Boja;
using static WebTrgovinaLibrary.Enumeracija.VrsteHlaca;
using static WebTrgovinaLibrary.Enumeracija.VrstaKosulje;
using WebTrgovina.Klase;
using WebTrgovinaKupci.Klase;

#region Lista artikova
List<Artikl> odjeca =  new List<Artikl>();
odjeca.Add(new MajicaKlasa(3.49m, Pamuk, Zene, MajicaKratkiRukav, XS, Narandzasta, 20));
odjeca.Add(new HlaceKlasa(9.99m, Pamuk, Muskarci, KratkeHlace, 36, Plava, 58));
odjeca.Add(new MajicaKlasa(4.49m, Polyester, Muskarci, MajicaKratkiRukav, L, Zelena, 10));
odjeca.Add(new MajicaKlasa(5.49m, Pamuk, Djeca, MajicaKratkiRukav, XS, Sareno, 7));
odjeca.Add(new HlaceKlasa(12.99m, Pamuk, Zene, Hlace, 34, Crna, 48));
odjeca.Add(new MajicaKlasa(7.49m, Pamuk, Zene, MajicaKratkiRukav, XS, Bijela, 16));
odjeca.Add(new MajicaKlasa(12.39m, Svila, Zene, MajicaKratkiRukav, S, Bijela, 20));
odjeca.Add(new HlaceKlasa(19.99m, Pamuk, Muskarci, Hlace, 38, Crna, 50));
odjeca.Add(new KosuljaKlasa(14.99m, Pamuk, Muskarci, KosuljaKratkiRukav, XL, Zelena, 15));
odjeca.Add(new MajicaKlasa(5.49m, Pamuk, Djeca, MajicaKratkiRukav, S, Crvena, 17));
odjeca.Add(new HlaceKlasa(12.99m, Pamuk, Zene, Hlace, 40, Bez, 48));
odjeca.Add(new MajicaKlasa(17.49m, Pamuk, Zene, RebrastaMajica, S, Roza, 26));
#endregion

#region Lista kupaca
var kupci = new List<Kupac>();
kupci.Add(new Kupac("Marko", "Marković", "marko.markovi@example.com", "Vukovarska 147b, Zagreb"));
kupci.Add(new Kupac("Pero", "Perić", "pero.peric@example.com", "Osječka 7, Vukovar"));
kupci.Add(new Kupac("Ivana","Ivanić","ivana.ivanic@example.com", "Bogdanovačka 21, Vukovar"));
kupci.Add(new Kupac("Marta", "Martić", "marta.martic@example.com", "Vukovarska 98, Osijek"));
#endregion

#region Narudzbe
var narudzbe = new List<Narudzba>();
narudzbe.Add(new Narudzba(0, [new(10001, 2), new(30001, 3)]));
narudzbe.Add(new Narudzba(3, [new(30001, 1), new(20000, 1)]));
#endregion




bool nastavi = true;
byte promasaj = 0;

ZaIspis.IspisiZaglavlje();
while (nastavi)
{
    ZaIspis.IspisiMenu();
    string odabir = ""+ Console.ReadLine();
    switch (odabir)
    {
        // OPCIJA 1 - Unos novog artikla
        case "1":
            promasaj = 0;
            ZaIspis.IspisiZaglavlje();
            ZaUnos.DodajArtikl(odjeca);
            break;

        // OPCIJA 2 - ispis svih artiklova odjeće
        case "2":
            promasaj = 0;
            ZaIspis.IspisiZaglavlje();
            Console.WriteLine("\n\tIspis svih artiklova odjeće:");
            ZaIspis.IspisiSveArtikle(odjeca);
            Console.WriteLine();
            break;

        //OPCIJA 3 - filtrirani prikaz odjeće
        case "3":
            promasaj = 0;
            ZaIspis.FiltrirajIspis(odjeca);
            break;

        //OPCIJA 4 - prikazuje kupce i narudzbu odjeće
        case "4":
            promasaj = 0;
            ZaIspis.IspisiZaglavlje();
            ZaIspis.IspisiNarudzbu(kupci, narudzbe, odjeca);
            break;

        //OPCIJA 0 - IZLAZ IZ APLIKACIJE
        case "0":
            nastavi = false;
            ZaIspis.IspisiZaglavlje();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tIzašli ste iz aplikacije.");
            Console.ResetColor();
            break;

        //DEFAULT - izlaz iz aplikacije u slučaju tri uzastopna promašaja
        default:
            promasaj++;
            if (promasaj == 3)
            {
                ZaIspis.IspisiZaglavlje();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tUčestali odabir nepoznate opcije prekida izvršavanje aplikacije.\n");
                Console.ResetColor();
                nastavi = false;
                break;
            }
            ZaIspis.IspisiZaglavlje();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tNepoznata opcija, pokušajte ponovno.");
            Console.ResetColor();
            break;
    }
}
Console.ReadKey();