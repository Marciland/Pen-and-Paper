namespace Client.Dataclasses;

public class Level
{
    public string name;
    public int apTotal;
    public int apAvailable;
    public int apSpent;
    public int maxAttribute;
    public int maxSkill;
    public int maxCombatSkill;
    public int maxAttributeTotal;
    public int maxSpells;
    public int maxForeignSpells;

    public override string ToString()
    {
        return $"{name} ({apTotal}AP)";
    }

    public static List<Level> GetLevels()
    {
        return new List<Level>
        {
            new() { name = "Unerfahren",       apTotal = 900,  apAvailable = 900,  apSpent = 0, maxAttribute = 12, maxSkill = 10, maxCombatSkill = 8,  maxAttributeTotal = 95,  maxSpells = 8,  maxForeignSpells = 0 },
            new() { name = "Durchschnittlich", apTotal = 1000, apAvailable = 1000, apSpent = 0, maxAttribute = 13, maxSkill = 10, maxCombatSkill = 10, maxAttributeTotal = 98,  maxSpells = 10, maxForeignSpells = 1 },
            new() { name = "Erfahren",         apTotal = 1100, apAvailable = 1100, apSpent = 0, maxAttribute = 14, maxSkill = 10, maxCombatSkill = 12, maxAttributeTotal = 100, maxSpells = 12, maxForeignSpells = 2 },
            new() { name = "Kompetent",        apTotal = 1200, apAvailable = 1200, apSpent = 0, maxAttribute = 15, maxSkill = 13, maxCombatSkill = 14, maxAttributeTotal = 102, maxSpells = 14, maxForeignSpells = 3 },
            new() { name = "Meisterlich",      apTotal = 1400, apAvailable = 1400, apSpent = 0, maxAttribute = 16, maxSkill = 16, maxCombatSkill = 16, maxAttributeTotal = 105, maxSpells = 16, maxForeignSpells = 4 },
            new() { name = "Brilliant",        apTotal = 1700, apAvailable = 1700, apSpent = 0, maxAttribute = 17, maxSkill = 19, maxCombatSkill = 18, maxAttributeTotal = 109, maxSpells = 18, maxForeignSpells = 5 },
            new() { name = "Legendär",         apTotal = 2100, apAvailable = 2100, apSpent = 0, maxAttribute = 18, maxSkill = 20, maxCombatSkill = 20, maxAttributeTotal = 114, maxSpells = 20, maxForeignSpells = 6 }
        };
    }

}
