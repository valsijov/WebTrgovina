using WebTrgovinaLibrary.Enumeracija;

namespace WebTrgovinaLibrary.Klase;

public class HlaceKlasa : Artikl
{
    private static uint _sifraHlace = 30000;
    public VrsteHlaca Vrsta {  get; set; }
    public byte Velicina { get; set; }
    public HlaceKlasa(decimal cijenaHlaca, Materijal materijal, Spol spol, VrsteHlaca vrsta, byte velicina, Boja boja, ushort kolicinaHlaca)
    {
        Sifra = _sifraHlace++;
        Cijena = cijenaHlaca;
        Materijal = materijal;
        NamijenjenoZa = spol;
        Vrsta = vrsta;
        Velicina = velicina;
        Boja = boja;
        Kolicina = kolicinaHlaca;
    }
    public override string ToString() => $"\t{Sifra} - {Vrsta, -20} | {Cijena, 6} EUR | {NamijenjenoZa, 8} | {Materijal, 10} | {Boja, 12} | {Velicina, 4} | Na stanju: {Kolicina, -5} ";
}
