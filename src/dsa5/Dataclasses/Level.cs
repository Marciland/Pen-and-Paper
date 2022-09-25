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
        return name;
    }
}