namespace Client.Dataclasses
{
    public class Species
    {
        public int Type; // 0 = Mensch/Halbelf, 1 = Elf, 2 = Zwerg (used for figuring out if culture is valid)
        public string Name;
        public int Ap;
        public int Le;
        public int Sk;
        public int Zk;
        public int Gs;
        public string Attributes;
        public List<PerkFlaw> Perks;

        public override string ToString()
        {
            return $"{Name} ({Ap}AP)";
        }

        public static List<Species> GetSpecies()
        {
            return new List<Species>
            {
                new(){ Type = 0, Name = "Mensch",  Ap = 0,  Le = 5, Sk = -5, Zk = -5, Gs = 8, Attributes = "eine beliebige Eigenschaft +1", Perks = new List<PerkFlaw>() },
                new(){ Type = 1, Name = "Elf",     Ap = 18, Le = 2, Sk = -4, Zk = -6, Gs = 8, Attributes = "IN und GE +1, KL oder KK -2",   Perks = new List<PerkFlaw> { new() { Name = "Zauberer", Level = 0, Description = "Der Zauberer erhält als Astralenergie-Grundwert 20 AsP. Der Vorteil beinhaltet nicht die Sonderfertigkeit Tradition. Jeder Zauberer muss mit einer Tradition starten. Dieser Vorteil lässt sich im späteren Verlauf nicht mehr erwerben.", Precondition = "keine", Ap = 25 },
                                                                                                                                                                         new() { Name = "Zweistimmiger Gesang", Level = 0, Description = "", Precondition = "Spezies, Kultur oder Profession muss den Vorteil beinhalten oder empfehlen.", Ap = 5 } } },
                new(){ Type = 0, Name = "Halbelf", Ap = 0,  Le = 5, Sk = -4, Zk = -6, Gs = 8, Attributes = "eine beliebige Eigenschaft +1", Perks = new List<PerkFlaw>() },
                new(){ Type = 2, Name = "Zwerg",   Ap = 61, Le = 8, Sk = -4, Zk = -4, Gs = 6, Attributes = "KO und KK +1, CH oder GE -2",   Perks = new List<PerkFlaw>() }
            };
        }

    }

}
