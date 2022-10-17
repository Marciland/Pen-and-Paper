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

        public override string ToString()
        {
            return $"{Name} ({Ap}AP)";
        }

        public static List<PerkFlaw> GetPerks()
        {
            return new List<PerkFlaw>()
            {
                new (){ Name = "Adel", Level = 1, Description = "Der Held ist angesehen, genießt die Privilegien des Adels und kann vom Meister Erleichterungen zugesprochen bekommen, wenn er gegenüber Rangniedrigeren agiert. Siehe GRW.338", Precondition = "Kultur muss über einen passenden Adel verfügen.", Ap = 5 },
                new (){ Name = "Adel", Level = 2, Description = "Der Held ist angesehen, genießt die Privilegien des Adels und kann vom Meister Erleichterungen zugesprochen bekommen, wenn er gegenüber Rangniedrigeren agiert. Siehe GRW.338", Precondition = "Kultur muss über einen passenden Adel verfügen.", Ap = 10 },
                new (){ Name = "Adel", Level = 3, Description = "Der Held ist angesehen, genießt die Privilegien des Adels und kann vom Meister Erleichterungen zugesprochen bekommen, wenn er gegenüber Rangniedrigeren agiert. Siehe GRW.338", Precondition = "Kultur muss über einen passenden Adel verfügen.", Ap = 15 }
            };
        }

        public static List<PerkFlaw> GetFlaws()
        {
            return new List<PerkFlaw>()
            {
                new (){ Name = "Arm", Level = 1, Description = "Durch den Nachteil Arm erhält ein Held bei der Erstellung 250 Silbertaler weniger pro Stufe.", Precondition = "kein Vorteil Reich", Ap = 1},
                new (){ Name = "Arm", Level = 2, Description = "Durch den Nachteil Arm erhält ein Held bei der Erstellung 250 Silbertaler weniger pro Stufe.", Precondition = "kein Vorteil Reich", Ap = 2},
                new (){ Name = "Arm", Level = 3, Description = "Durch den Nachteil Arm erhält ein Held bei der Erstellung 250 Silbertaler weniger pro Stufe.", Precondition = "kein Vorteil Reich", Ap = 3}
            };
        }

    }

}
