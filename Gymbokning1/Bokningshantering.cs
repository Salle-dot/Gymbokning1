using System;
using System.Collections.Generic;

public class Bokningshantering
{
    private List<Pass> passLista;

    public Bokningshantering()
    {
        passLista = new List<Pass>
        {
            new Pass("Yoga", DateTime.Now.AddHours(1), 10),
            new Pass("Zumba", DateTime.Now.AddHours(2), 8)
        };
    }

    public List<Pass> HämtaTillgängligaPass()
    {
        return passLista;
    }

    public bool BokaPass(string kategori, DateTime tid)
    {
        var pass = passLista.Find(p => p.Kategori == kategori && p.Tid == tid);
        if (pass != null && pass.AntalPlatser > 0)
        {
            pass.AntalPlatser--;
            return true; // Bokningen lyckades
        }
        return false; // Bokningen misslyckades
    }

    public bool AvbokaPass(string kategori, DateTime tid)
    {
        var pass = passLista.Find(p => p.Kategori == kategori && p.Tid == tid);
        if (pass != null)
        {
            pass.AntalPlatser++;
            return true; // Avbokningen lyckades
        }
        return false; // Avbokningen misslyckades
    }
}
