namespace Client.Dataclasses
{
    // Since perks and flaws share the same attributes they are combined into a single class.
    public class PerkFlaw
    {
        public string Name;
        public int Level;
        public string Description;
        public string Precondition;
        public int Ap;

        private static readonly List<PerkFlaw> AllPerks = new ()
        {
            new PerkFlaw(){ Name = "Adel", Level = 1, Description = "Der Held ist angesehen, genießt die Privilegien des Adels und kann vom Meister Erleichterungen zugesprochen bekommen, wenn er gegenüber Rangniedrigeren agiert. Siehe GRW.338", Precondition = "Kultur muss über einen passenden Adel verfügen.", Ap = 5 },
            new PerkFlaw(){ Name = "Adel", Level = 2, Description = "Der Held ist angesehen, genießt die Privilegien des Adels und kann vom Meister Erleichterungen zugesprochen bekommen, wenn er gegenüber Rangniedrigeren agiert. Siehe GRW.338", Precondition = "Kultur muss über einen passenden Adel verfügen.", Ap = 10 },
            new PerkFlaw(){ Name = "Adel", Level = 3, Description = "Der Held ist angesehen, genießt die Privilegien des Adels und kann vom Meister Erleichterungen zugesprochen bekommen, wenn er gegenüber Rangniedrigeren agiert. Siehe GRW.338", Precondition = "Kultur muss über einen passenden Adel verfügen.", Ap = 15 },
            new PerkFlaw(){ Name = "TestFor80", Level = 0, Description = "bla", Precondition = "blaa", Ap = 80 },
            new PerkFlaw(){ Name = "Zauberer", Level = 0, Description = "Der Zauberer erhält als Astralenergie-Grundwert 20 AsP. Der Vorteil beinhaltet nicht die Sonderfertigkeit Tradition. Jeder Zauberer muss mit einer Tradition starten. Dieser Vorteil lässt sich im späteren Verlauf nicht mehr erwerben.", Precondition = "keine", Ap = 25 },
            new PerkFlaw(){ Name = "Zweistimmiger Gesang", Level = 0, Description = "", Precondition = "Spezies, Kultur oder Profession muss den Vorteil beinhalten oder empfehlen.", Ap = 5 }
        };

        private static readonly List<PerkFlaw> AllFlaws = new()
        {
            new PerkFlaw(){ Name = "Arm", Level = 1, Description = "Durch den Nachteil Arm erhält ein Held bei der Erstellung 250 Silbertaler weniger pro Stufe.", Precondition = "kein Vorteil Reich", Ap = 1},
            new PerkFlaw(){ Name = "Arm", Level = 2, Description = "Durch den Nachteil Arm erhält ein Held bei der Erstellung 250 Silbertaler weniger pro Stufe.", Precondition = "kein Vorteil Reich", Ap = 2},
            new PerkFlaw(){ Name = "Arm", Level = 3, Description = "Durch den Nachteil Arm erhält ein Held bei der Erstellung 250 Silbertaler weniger pro Stufe.", Precondition = "kein Vorteil Reich", Ap = 3}
        };

        public override string ToString()
        {
            return $"{Name} ({Ap}AP)";
        }

        public static List<PerkFlaw> GetAllPerks()
        {
            return AllPerks;
        }

        public static PerkFlaw GetPerk(string name, int level = 0)
        {
            if (level != 0)
            {
                //TBD
            }
            return AllPerks.FirstOrDefault(perk => perk.Name == name);
        }

        public static List<PerkFlaw> GetAllFlaws()
        {
            return AllFlaws;
        }

    }

}
