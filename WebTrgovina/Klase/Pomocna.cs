namespace WebTrgovina.Klase;

public static class Pomocna
{
    public static T OdaberiEnum<T>(string poruka) where T : struct, Enum
    {
        while(true)
        {
            Console.Clear();
            Console.WriteLine("\t" + poruka);
            var vrijednosti = Enum.GetValues(typeof(T));

            int i = 0;
            foreach (var vrijednost in vrijednosti)
            {
                Console.WriteLine($"\t{i} - {vrijednost}");
                i++;                
            }

            Console.Write("\tVaš odabir: ");
            string odabir = ""+Console.ReadLine();

            if(int.TryParse(odabir, out int broj) && broj >=0 && broj < vrijednosti.Length)
            {
                return (T)vrijednosti.GetValue(broj)!;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tNeispravan unos. Pokušaj ponovno.");
            Console.ResetColor();

        }
    }

    public static decimal UnesiCijenu(string poruka)
    {
        while(true)
        {
            Console.Clear();
            ZaIspis.IspisiZaglavlje();
            Console.Write("\t"+poruka);
            string unos = "" + Console.ReadLine();
            
            if(decimal.TryParse(unos, out decimal vrijednost))
            {
                return vrijednost;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Neispravan decimalni broj za cijenu artikla. Pokušaj ponovno.");
            Console.ResetColor();
        }
    }

    public static ushort UnesiKolicinu(string poruka)
    {
        while (true)
        {
            Console.Clear();
            ZaIspis.IspisiZaglavlje();
            Console.Write("\t" + poruka);
            string unos = "" + Console.ReadLine();

            if (ushort.TryParse(unos, out ushort kolicina))
            {
                return kolicina;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Neispravan broj za količinu artikala na stanju. Pokušaj ponovno.");
            Console.ResetColor();
        }
    }
    public static byte UnesiVelicinuHlaca(string poruka)
    {
        while (true)
        {
            Console.Clear();
            ZaIspis.IspisiZaglavlje();
            Console.Write("\t" + poruka);
            string unos = "" + Console.ReadLine();

            if (byte.TryParse(unos, out byte velicina))
            {
                return velicina;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Neispravan broj za veličinu hlača. Pokušaj ponovno.");
            Console.ResetColor();
        }
    }

}
