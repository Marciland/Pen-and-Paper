namespace dsa5.Dataclasses;

public class Level
{
    public string name;
    public int APTotal;
    public int APAvailable;
    public int APSpent;
    public int maxAttribute;
    public int maxSkill;
    public int maxCombatSkill;
    public int maxAttributeTotal;
    public int maxSpells;
    public int maxForeignSpells;

    public override string ToString()
    {
        return $"{name} ({APTotal}AP)";
    }

    public static List<Level> GetLevels() 
    {
        return new List<Level>
        {
            new Level { name = "Unerfahren",       APTotal = 900,  APAvailable = 900,  APSpent = 0, maxAttribute = 12, maxSkill = 10, maxCombatSkill = 8,  maxAttributeTotal = 95,  maxSpells = 8,  maxForeignSpells = 0 },
            new Level { name = "Durchschnittlich", APTotal = 1000, APAvailable = 1000, APSpent = 0, maxAttribute = 13, maxSkill = 10, maxCombatSkill = 10, maxAttributeTotal = 98,  maxSpells = 10, maxForeignSpells = 1 },
            new Level { name = "Erfahren",         APTotal = 1100, APAvailable = 1100, APSpent = 0, maxAttribute = 14, maxSkill = 10, maxCombatSkill = 12, maxAttributeTotal = 100, maxSpells = 12, maxForeignSpells = 2 },
            new Level { name = "Kompetent",        APTotal = 1200, APAvailable = 1200, APSpent = 0, maxAttribute = 15, maxSkill = 13, maxCombatSkill = 14, maxAttributeTotal = 102, maxSpells = 14, maxForeignSpells = 3 },
            new Level { name = "Meisterlich",      APTotal = 1400, APAvailable = 1400, APSpent = 0, maxAttribute = 16, maxSkill = 16, maxCombatSkill = 16, maxAttributeTotal = 105, maxSpells = 16, maxForeignSpells = 4 },
            new Level { name = "Brilliant",        APTotal = 1700, APAvailable = 1700, APSpent = 0, maxAttribute = 17, maxSkill = 19, maxCombatSkill = 18, maxAttributeTotal = 109, maxSpells = 18, maxForeignSpells = 5 },
            new Level { name = "Legendär",         APTotal = 2100, APAvailable = 2100, APSpent = 0, maxAttribute = 18, maxSkill = 20, maxCombatSkill = 20, maxAttributeTotal = 114, maxSpells = 20, maxForeignSpells = 6 }
        };
    }

}