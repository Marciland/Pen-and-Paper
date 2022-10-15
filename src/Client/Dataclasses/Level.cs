namespace Client.Dataclasses;

public class Level
{
    public string Name;
    public int ApTotal;
    public int ApAvailable;
    public int ApSpent;
    public int MaxAttribute;
    public int MaxSkill;
    public int MaxCombatSkill;
    public int MaxAttributeTotal;
    public int MaxSpells;
    public int MaxForeignSpells;

    public override string ToString()
    {
        return $"{Name} ({ApTotal}AP)";
    }

    public static List<Level> GetLevels()
    {
        return new List<Level>
        {
            new() { Name = "Unerfahren",       ApTotal = 900,  ApAvailable = 900,  ApSpent = 0, MaxAttribute = 12, MaxSkill = 10, MaxCombatSkill = 8,  MaxAttributeTotal = 95,  MaxSpells = 8,  MaxForeignSpells = 0 },
            new() { Name = "Durchschnittlich", ApTotal = 1000, ApAvailable = 1000, ApSpent = 0, MaxAttribute = 13, MaxSkill = 10, MaxCombatSkill = 10, MaxAttributeTotal = 98,  MaxSpells = 10, MaxForeignSpells = 1 },
            new() { Name = "Erfahren",         ApTotal = 1100, ApAvailable = 1100, ApSpent = 0, MaxAttribute = 14, MaxSkill = 10, MaxCombatSkill = 12, MaxAttributeTotal = 100, MaxSpells = 12, MaxForeignSpells = 2 },
            new() { Name = "Kompetent",        ApTotal = 1200, ApAvailable = 1200, ApSpent = 0, MaxAttribute = 15, MaxSkill = 13, MaxCombatSkill = 14, MaxAttributeTotal = 102, MaxSpells = 14, MaxForeignSpells = 3 },
            new() { Name = "Meisterlich",      ApTotal = 1400, ApAvailable = 1400, ApSpent = 0, MaxAttribute = 16, MaxSkill = 16, MaxCombatSkill = 16, MaxAttributeTotal = 105, MaxSpells = 16, MaxForeignSpells = 4 },
            new() { Name = "Brilliant",        ApTotal = 1700, ApAvailable = 1700, ApSpent = 0, MaxAttribute = 17, MaxSkill = 19, MaxCombatSkill = 18, MaxAttributeTotal = 109, MaxSpells = 18, MaxForeignSpells = 5 },
            new() { Name = "Legendär",         ApTotal = 2100, ApAvailable = 2100, ApSpent = 0, MaxAttribute = 18, MaxSkill = 20, MaxCombatSkill = 20, MaxAttributeTotal = 114, MaxSpells = 20, MaxForeignSpells = 6 }
        };
    }

}
