using System.Collections.Generic;

public class Användare
{
    public string Namn { get; set; }
    public List<Pass> BokadePass { get; set; } = new List<Pass>();
}
