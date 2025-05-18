namespace WebTrgovinaKupci.Klase;

public class Kupac
{
    private static uint _id = 0;
    public uint Id { get; private set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string Email { get; set; }
    public string Adresa { get; set; }

    public Kupac (string ime, string prezime, string email, string adresa)
    {
        Id = _id++;
        Ime = ime;
        Prezime = prezime;
        Email = email;
        Adresa = adresa;
    }

    public override string ToString() => $"{Ime} {Prezime}, Email: {Email}, Adresa: {Adresa}";
}
