namespace Valid_Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ValidName("H. Wells"));
            Console.WriteLine(ValidName("H. G. Wells"));
            Console.WriteLine(ValidName("Herbert G. Wells"));
            Console.WriteLine(ValidName("Herbert George Wells"));
            Console.WriteLine(ValidName("Herbert"));
            Console.WriteLine(ValidName("H Wells"));
            Console.WriteLine(ValidName("h. Wells"));
            Console.WriteLine(ValidName("H. George Wells"));
            Console.WriteLine(ValidName("H. G. W."));
            Console.WriteLine(ValidName("Herb. G. Wells"));
        }

        public static bool ValidName(string name)
        {
            string[] nameParts = name.Split(' ');

            // Check if there is only one word
            if (nameParts.Length == 1)
            {
                return false;
            }

            foreach (string namePart in nameParts)
            {
                // Check if the length of the initial is 1
                if (namePart.Length == 1)
                {
                    return false;
                }
                
                // Check if it is initial and without uppercase letter
                if (namePart.Length == 2 && !char.IsUpper(namePart[0]))
                {
                    return false;
                }
                
                // Check if it is initial and without .
                if (namePart.Length == 2 && namePart[1] != '.')
                {
                    return false;
                }
                
                // Check if it is word and it is capitalized
                if (namePart.Length > 2 && char.IsUpper(namePart[0]))
                {
                    // Check if it contains .
                    if (namePart.Contains("."))
                    {
                        return false;
                    }
                }

                // Check if it is word and it is not capitalized
                if (namePart.Length > 2 && !char.IsUpper(namePart[0]))
                {
                    return false;
                }
            }

            // Check the last name is a word
            if (nameParts[nameParts.Length - 1].Length == 2)
            {
                return false;
            }

            if (nameParts.Length == 3)
            {
                // Check that first and middle name are not both initials
                if (nameParts[0].Length == 2 && nameParts[1].Length > 2)
                {
                    return false;
                }
            }

            return true;
        }

    }
}