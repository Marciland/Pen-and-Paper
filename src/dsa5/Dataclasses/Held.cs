namespace dsa5.Dataclasses;

public class Held
{
    public string Name { get; set; }
    public AllgemeineWerte AllgemeineWerte { get; set; }
    public Erfahrungsgrad Erfahrungsgrad { get; set; }
    public BasisAttribute BasisAttribute { get; set; }
    public List<ZauberRitual> ZauberRituale { get; set; }
}