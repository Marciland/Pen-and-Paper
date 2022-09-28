namespace dsa5.Dataclasses
{
    public class Profession
    {
        public string name;
        public int AP;
        public string preconditions;
        public bool preconditionsMet;
        public List<SpecialSkill> specialSkills;
        public List<string> combatSkills;
        public List<string> skills;
        public List<Spell> spells;
        public List<Profession> variants;

        public override string ToString()
        {
            return $"{name} ({AP}AP)";
        }

        public static List<Profession> GetProfessions()
        {
            return new()
            {
                new Profession{}
            };
        }

    }

}
