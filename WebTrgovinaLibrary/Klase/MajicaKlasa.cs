using WebTrgovinaLibrary.Enumeracija;

namespace WebTrgovinaLibrary.Klase;

public class MajicaKlasa : Artikl
{
    private static uint _sifraMajice = 10000;
    public VrsteMajica Vrsta { get; set; }
    public VelicinaMajicaKosulja Velicina {  get; set; }

    public MajicaKlasa(decimal cijenaMajice, Materijal materijal, Spol spol, VrsteMajica vrsta, VelicinaMajicaKosulja velicina, Boja boja, ushort kolicinaMajica)
    {
        Sifra = _sifraMajice++;
        Cijena = cijenaMajice;
        Materijal = materijal;
        NamijenjenoZa = spol;
        Vrsta = vrsta;
        Velicina = velicina;
        Boja = boja;
        Kolicina = kolicinaMajica;
    }

    public override string ToString() => $"\t{Sifra} - {Vrsta,-20} | {Cijena,6} EUR | {NamijenjenoZa,8} | {Materijal,10} | {Boja,12} | {Velicina,4} | Na stanju: {Kolicina,-5} ";

}
