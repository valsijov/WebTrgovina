using WebTrgovinaLibrary.Enumeracija;

namespace WebTrgovinaLibrary.Klase;

public abstract class Artikl
{
    public uint Sifra { get; protected set; }
    public decimal Cijena { get; set; }
    public ushort Kolicina { get; set; }
    public Materijal Materijal { get; set; }
    public Spol NamijenjenoZa {  get; set; }
    public Boja Boja { get; set; }
}
