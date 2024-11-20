using System;

public class Pass
{
    public string Kategori { get; set; }
    public DateTime Tid { get; set; }
    public int AntalPlatser { get; set; }

    public Pass(string kategori, DateTime tid, int antalPlatser)
    {
        Kategori = kategori;
        Tid = tid;
        AntalPlatser = antalPlatser;
    }
}
