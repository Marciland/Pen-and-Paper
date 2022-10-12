namespace dsa5.Dataclasses
{
    public class Culture
    {

        public int type; // 0 = Menschliche Kultur, 1 = Elfische Kultur, 2 = Zwergische Kultur
        public string name;
        public int AP;
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
                new Culture(){ type = 0, name = "Andergaster", AP = 20, language = "Garethi",                socialStatus = new (){ "Adel", "Unfrei"}, skills = new(){ "Holzbearbeitung +2", "Orientierung +1", "Pflanzenkunde +1", "Sagen & Legenden +1", "Tierkunde +1", "Wildnisleben +2" } },
                new Culture(){ type = 0, name = "Aranier",     AP = 26, language = "Tulamidya oder Garethi", socialStatus = new (){ "Adel", "Unfrei"}, skills = new(){ "Betören +1", "Brett- & Glücksspiel +1", "Gassenwissen +2", "Handel +2", "Menschenkenntnis +1", "Rechnen +1", "Sagen & Legenden +1", "Stoffbearbeitung +1", "Überreden +2" } },
                new Culture(){ type = 0, name = "Bornländer",  AP = 18, language = "Garethi",                socialStatus = new (){ "Adel", "Unfrei"}, skills = new(){ "Fährtensuchen +1", "Holzbearbeitung +2", "Lebensmittelbearbeitung +1", "Orientierung +1", "Pflanzenkunde +1", "Wildnisleben +1", "Zechen +2" } }
            };
        }

    }

}
