namespace WebTrgovinaKupci.Klase;

using System.Security.Cryptography.X509Certificates;
using WebTrgovinaLibrary.Klase;

public class Narudzba
{
    private static uint _id = 1;
    public uint IdNarudzbe { get; set; }
    public uint IdKupca { get; set; }

    public List<NaruceniArtikl> NaruceneStavke = [];

    public Narudzba(uint idKupca, List<NaruceniArtikl> listaNarucenihStavki)
    {
        IdNarudzbe = _id++;
        IdKupca = idKupca;
        NaruceneStavke = listaNarucenihStavki;
    }
}
