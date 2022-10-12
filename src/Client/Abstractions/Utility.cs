namespace Client.Abstractions
{

    public class Utility
    {

        public static string ListToString(List<string> list, int breakAfter)
        {
            string completeString = string.Empty;

            if (list == null) return null;

            if (list.Count == 0) return "Keine";

            int counter = 0;
            foreach (string item in list)
            {
                completeString += $"{item}, ";
                counter++;
                if (counter % breakAfter == 0)
                {
                    completeString += "\n";
                }
            }

            completeString = completeString.EndsWith("\n") ? completeString.Remove(completeString.Length - 3) : completeString.Remove(completeString.Length - 2);

            return completeString;
        }

    }

}
