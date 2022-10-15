namespace Client.Dataclasses
{
    public class Culture
    {

        public int Type; // 0 = menschliche Kultur, 1 = elfische Kultur, 2 = zwergische Kultur
        public string Name;
        public int Ap;
        public string Language;
        public List<string> SocialStatus;
        public List<string> Skills;

        public override string ToString()
        {
            return Name;
        }

        public static List<Culture> GetCultures()
        {
            return new List<Culture>
            {
                new(){ Type = 0, Name = "Andergaster", Ap = 20, Language = "Garethi",                SocialStatus = new List<string> { "Adel", "Unfrei"}, Skills = new List<string> { "Holzbearbeitung +2", "Orientierung +1", "Pflanzenkunde +1", "Sagen & Legenden +1", "Tierkunde +1", "Wildnisleben +2" } },
                new(){ Type = 0, Name = "Aranier",     Ap = 26, Language = "Tulamidya oder Garethi", SocialStatus = new List<string> { "Adel", "Unfrei"}, Skills = new List<string> { "Betören +1", "Brett- & Glücksspiel +1", "Gassenwissen +2", "Handel +2", "Menschenkenntnis +1", "Rechnen +1", "Sagen & Legenden +1", "Stoffbearbeitung +1", "Überreden +2" } },
                new(){ Type = 0, Name = "Bornländer",  Ap = 18, Language = "Garethi",                SocialStatus = new List<string> { "Adel", "Unfrei"}, Skills = new List<string> { "Fährtensuchen +1", "Holzbearbeitung +2", "Lebensmittelbearbeitung +1", "Orientierung +1", "Pflanzenkunde +1", "Wildnisleben +1", "Zechen +2" } }
            };
        }

    }

}
