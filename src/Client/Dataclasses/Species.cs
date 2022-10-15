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
        public List<Perk> Perks;

        public override string ToString()
        {
            return $"{Name} ({Ap}AP)";
        }

        public static List<Species> GetSpecies()
        {
            return new List<Species>
            {
                new(){ Type = 0, Name = "Mensch",  Ap = 0,  Le = 5, Sk = -5, Zk = -5, Gs = 8, Attributes = "eine beliebige Eigenschaft +1", Perks = new List<Perk>() },
                new(){ Type = 1, Name = "Elf",     Ap = 18, Le = 2, Sk = -4, Zk = -6, Gs = 8, Attributes = "IN und GE +1, KL oder KK -2", Perks = new List<Perk> { new() { name = "Zauberer"}, new() { name = "Zweistimmiger Gesang"} } },
                new(){ Type = 0, Name = "Halbelf", Ap = 0,  Le = 5, Sk = -4, Zk = -6, Gs = 8, Attributes = "eine beliebige Eigenschaft +1", Perks = new List<Perk>() },
                new(){ Type = 2, Name = "Zwerg",   Ap = 61, Le = 8, Sk = -4, Zk = -4, Gs = 6, Attributes = "KO und KK +1, CH oder GE -2", Perks = new List<Perk>() }
            };
        }

    }

}
