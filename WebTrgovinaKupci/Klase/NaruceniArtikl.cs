namespace WebTrgovinaKupci.Klase;

public class NaruceniArtikl
{
    public uint SifraArtikla {  get; set; }
    public int Kolicina { get; set; }

    public NaruceniArtikl(uint sifraArtikla, int kolicina)
    {
        SifraArtikla = sifraArtikla;
        Kolicina = kolicina;
    }
}
