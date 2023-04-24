namespace Sort_Based_on_Last_Name
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> sorted = SortContacts(new List<string>() { "John Locke", "Thomas Aquinas", "David Hume", "Rene Descartes" }, "DESC");
            foreach (string s in sorted)
            {
                Console.WriteLine(s);
            }
        }

        public static List<string> SortContacts(List<string> names, string sortOrder)
        {
            // Check the names list
            // If it is null or have no elements return an empty list
            if (names == null || names.Count == 0)
            {
                return new List<string>();
            }

            // Check whether it is ASC or DESC
            if (sortOrder.Equals("ASC"))
            {
                // Split the word and order by the last name and make it as a list and return
                return names.OrderBy(name => name.Split(' ').Last()).ToList();
            } else
            {
                // Split the word and order it descending by the last name and make it as a list and return
                return names.OrderByDescending(name => name.Split(' ').Last()).ToList();
            }
        }
    }
}