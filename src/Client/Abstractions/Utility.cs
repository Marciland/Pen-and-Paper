namespace dsa5.Abstractions
{

    public class Utility
    {

        public static string ListToString(List<string> list, int breakAfter)
        {
            string completeString = string.Empty;

            if (list == null) return null;

            if (list.Count == 0) return "Keine";

            int linebreakCounter = 0;
            foreach (string item in list)
            {
                completeString += $"{item}, ";
                linebreakCounter++;
                if (linebreakCounter % breakAfter == 0)
                {
                    completeString += "\n";
                }
            }

            if (completeString.EndsWith("\n")) completeString = completeString.Remove(completeString.Length - 3);
            else completeString = completeString.Remove(completeString.Length - 2);

            return completeString;
        }

    }

}
