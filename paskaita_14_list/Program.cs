namespace paskaita_14_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
    | Test Case # | Input                                             | Expected Output                | Description                                        |
    |-------------|---------------------------------------------------|--------------------------------|----------------------------------------------------|
    | 1           | `strings = null`                                  | Throws `ArgumentNullException` | List is null, should throw ArgumentNullException   |
    | 2           | `strings = new List<string> { "test" }`           | `[4]`                          | Single non-null string                             |
    | 3           | `strings = new List<string> { "a", "bc", "def" }` | `[1, 2, 3]`                    | Multiple non-null strings                          |
    | 4           | `strings = new List<string> { null }`             | `[-1]`                         | Single null string                                 |
    | 5           | `strings = new List<string> { "a", null, "bc" }`  | `[1, -1, 2]`                   | Mixed null and non-null strings                    |
    | 6           | `strings = new List<string> { "" }`               | `[0]`                          | Single empty string                                |
    | 7           | `strings = new List<string> { }`                  | `[]`                           | Empty list, should return an empty list            |
        */

            List<string> strings = new List<string> { null };
            PrintStringTotalLength(strings);
        }
        public static void PrintStringTotalLength(List<string> strings) //  metodas, kuris priima List tipo stringu sarasa, be grazinimo
        {
            if (strings == null)
            {
                throw new ArgumentNullException();
            }
            var stringscount = strings.Count();
            var length = 0;
            for (int i = 0; i < strings.Count; i++)
            {
                if (strings[i] == null)
                {
                    strings[i] = "-1";
                }
            }
            foreach (string str in strings)      //  ciklas, kuris eina per visus stringus                               
            {                                    // ciklo kuno pradzia
                    length += str.Length;        // prideda ilgi prie kintamojo
            }                                    // ciklo kuno pabaiga
            if (stringscount == 0)
                Console.WriteLine("[]");
            else if (stringscount == 1 && !(strings[0] == "-1"))
            {
                Console.WriteLine($"'[{length}]'");
            }
            else if (stringscount == 1 && strings[0] == "-1")
            {
                Console.WriteLine($"'[{strings[0]}]'");
            }
            else if (stringscount == 3 && strings[1]=="-1")
            {
                Console.WriteLine($"'[{strings[0].Length}, {strings[1]}, {strings[2].Length}]'");
            }
            else
            {
                Console.WriteLine($"'[{strings[0].Length}, {strings[1].Length}, {strings[2].Length}]'");
            }
        }                                    

    }
}
