namespace Client.Dataclasses
{
    public class Culture
    {

        public int type; // 0 = menschliche Kultur, 1 = elfische Kultur, 2 = zwergische Kultur
        public string name;
        public int ap;
        public string language;
        public List<string> socialStatus;
        public List<string> skills;

        public override string ToString()
        {
            return name;
        }

        public static List<Culture> GetCultures()
        {
            return new List<Culture>
            {
                new(){ type = 0, name = "Andergaster", ap = 20, language = "Garethi",                socialStatus = new List<string> { "Adel", "Unfrei"}, skills = new List<string> { "Holzbearbeitung +2", "Orientierung +1", "Pflanzenkunde +1", "Sagen & Legenden +1", "Tierkunde +1", "Wildnisleben +2" } },
                new(){ type = 0, name = "Aranier",     ap = 26, language = "Tulamidya oder Garethi", socialStatus = new List<string> { "Adel", "Unfrei"}, skills = new List<string> { "Betören +1", "Brett- & Glücksspiel +1", "Gassenwissen +2", "Handel +2", "Menschenkenntnis +1", "Rechnen +1", "Sagen & Legenden +1", "Stoffbearbeitung +1", "Überreden +2" } },
                new(){ type = 0, name = "Bornländer",  ap = 18, language = "Garethi",                socialStatus = new List<string> { "Adel", "Unfrei"}, skills = new List<string> { "Fährtensuchen +1", "Holzbearbeitung +2", "Lebensmittelbearbeitung +1", "Orientierung +1", "Pflanzenkunde +1", "Wildnisleben +1", "Zechen +2" } }
            };
        }

    }

}
