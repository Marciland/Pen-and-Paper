namespace Client.Dataclasses
{
    public class Profession
    {
        public string Name;
        public int Ap;
        public string Preconditions;
        public bool PreconditionsMet;
        public List<string> SpecialSkills;
        public List<string> CombatSkills;
        public List<string> Skills;
        public List<string> Spells;

        public override string ToString()
        {
            return $"{Name} ({Ap}AP)";
        }

        public static List<Profession> GetProfessions()
        {
            return new List<Profession>
            {
                new() { Name = "Bardin", Ap = 150, Preconditions = "Keine", PreconditionsMet = true, SpecialSkills = new List<string> { "*Sprachen und Schriften für insgesamt 16 AP*", "Fertigkeitsspezialisierung Musizieren" }, CombatSkills = new List<string> { "Dolche +8", "Raufen +8" }, Skills = new List<string> { "Singen +7", "Tanzen +2", "Bekehren & Überzeugen +2", "Betören +2", "Etikette +4", "Gassenwissen +4", "Menschenkenntnis +5", "Überreden +5", "Wildnisleben +2", "Geographie +4", "Geschichtswissen +4", "Götter & Kulte +4", "Rechnen +3", "Rechtskunde +2", "Sagen & Legenden +5", "Holzbearbeitung +3", "Musizieren +7" }, Spells = new List<string> { "Keine" } }
            };
        }

    }

}
