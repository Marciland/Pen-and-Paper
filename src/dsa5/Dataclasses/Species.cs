namespace dsa5.Dataclasses
{
    public class Species
    {
        public int type; // 0 = Mensch/Halbelf, 1 = Elf, 2 = Zwerg (used for figuring out if culture is valid)
        public string name;
        public int AP;
        public int LE;
        public int SK;
        public int ZK;
        public int GS;
        public string attributes;
        public List<Perk> perks;

        public override string ToString()
        {
            return $"{name} ({AP}AP)";
        }

        public static List<Species> GetSpecies()
        {
            return new List<Species>
            {
                new Species(){ type = 0, name = "Mensch",  AP = 0,  LE = 5, SK = -5, ZK = -5, GS = 8, attributes = "eine beliebige Eigenschaft +1", perks = new () },
                new Species(){ type = 1, name = "Elf",     AP = 18, LE = 2, SK = -4, ZK = -6, GS = 8, attributes = "IN und GE +1, KL oder KK -2", perks = new (){ new Perk() { name = "Zauberer"}, new Perk() { name = "Zweistimmiger Gesang"} } },
                new Species(){ type = 0, name = "Halbelf", AP = 0,  LE = 5, SK = -4, ZK = -6, GS = 8, attributes = "eine beliebige Eigenschaft +1", perks = new () },
                new Species(){ type = 2, name = "Zwerg",   AP = 61, LE = 8, SK = -4, ZK = -4, GS = 6, attributes = "KO und KK +1, CH oder GE -2", perks = new () }
            };
        }

    }

}
