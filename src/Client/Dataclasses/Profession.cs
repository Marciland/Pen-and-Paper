namespace Client.Dataclasses
{
    public class Profession
    {
        public string name;
        public int ap;
        public string preconditions;
        public bool preconditionsMet;
        public List<string> specialSkills;
        public List<string> combatSkills;
        public List<string> skills;
        public List<string> spells;

        public override string ToString()
        {
            return $"{name} ({ap}AP)";
        }

        public static List<Profession> GetProfessions()
        {
            return new List<Profession>
            {
                new() { name = "Bardin", ap = 150, preconditions = "Keine", preconditionsMet = true, specialSkills = new List<string> { "*Sprachen und Schriften für insgesamt 16 AP*", "Fertigkeitsspezialisierung Musizieren" }, combatSkills = new List<string> { "Dolche +8", "Raufen +8" }, skills = new List<string> { "Singen +7", "Tanzen +2", "Bekehren & Überzeugen +2", "Betören +2", "Etikette +4", "Gassenwissen +4", "Menschenkenntnis +5", "Überreden +5", "Wildnisleben +2", "Geographie +4", "Geschichtswissen +4", "Götter & Kulte +4", "Rechnen +3", "Rechtskunde +2", "Sagen & Legenden +5", "Holzbearbeitung +3", "Musizieren +7" }, spells = new List<string> { "Keine" } }
            };
        }

    }

}
