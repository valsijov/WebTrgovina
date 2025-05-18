using WebTrgovinaLibrary.Enumeracija;

namespace WebTrgovinaLibrary.Klase;

public class KosuljaKlasa : Artikl
{
    private static uint _sifraKosulje = 20000;
    public VrstaKosulje Vrsta { get; set; }
    public VelicinaMajicaKosulja Velicina { get; set; }

    public KosuljaKlasa(decimal cijenaKosulje, Materijal materijal, Spol spol, VrstaKosulje vrsta, VelicinaMajicaKosulja velicina, Boja boja, ushort kolicinaKosulja)
    {
        Sifra = _sifraKosulje++;
        Cijena = cijenaKosulje;
        Materijal = materijal;
        NamijenjenoZa = spol;
        Vrsta = vrsta;
        Velicina = velicina;
        Boja = boja;
        Kolicina = kolicinaKosulja;
    }

    public override string ToString() => $"\t{Sifra} - {Vrsta,-20} | {Cijena,6} EUR | {NamijenjenoZa,8} | {Materijal,10} | {Boja,12} | {Velicina,4} | Na stanju: {Kolicina,-5} ";

}
