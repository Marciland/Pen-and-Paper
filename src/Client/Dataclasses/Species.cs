namespace Client.Dataclasses
{
    public class Species
    {
        public int type; // 0 = Mensch/Halbelf, 1 = Elf, 2 = Zwerg (used for figuring out if culture is valid)
        public string name;
        public int ap;
        public int le;
        public int sk;
        public int zk;
        public int gs;
        public string attributes;
        public List<Perk> perks;

        public override string ToString()
        {
            return $"{name} ({ap}AP)";
        }

        public static List<Species> GetSpecies()
        {
            return new List<Species>
            {
                new(){ type = 0, name = "Mensch",  ap = 0,  le = 5, sk = -5, zk = -5, gs = 8, attributes = "eine beliebige Eigenschaft +1", perks = new List<Perk>() },
                new(){ type = 1, name = "Elf",     ap = 18, le = 2, sk = -4, zk = -6, gs = 8, attributes = "IN und GE +1, KL oder KK -2", perks = new List<Perk> { new() { name = "Zauberer"}, new() { name = "Zweistimmiger Gesang"} } },
                new(){ type = 0, name = "Halbelf", ap = 0,  le = 5, sk = -4, zk = -6, gs = 8, attributes = "eine beliebige Eigenschaft +1", perks = new List<Perk>() },
                new(){ type = 2, name = "Zwerg",   ap = 61, le = 8, sk = -4, zk = -4, gs = 6, attributes = "KO und KK +1, CH oder GE -2", perks = new List<Perk>() }
            };
        }

    }

}
