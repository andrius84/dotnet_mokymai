namespace Paskaita_9_extensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            Console.WriteLine($"Ar skaicius {number} teigimas: {number.IsPositiveOrNegative()}");

            Console.WriteLine($"Ar skaicius {number} lyginis: {number.IsEven()}");

            int number2 = 10;
            Console.WriteLine($"Ar skaicius {number} didesnis uz {number2}: {number.IsNumberBiggerThan(number2)}");

            string sentence = "Labas Rytas";
            Console.WriteLine($"Ar sakinyje {sentence} yra tarpu: {sentence.IsThereSpace()}");

            string fullname = "Vardenis Pav";
            string yearOfBirth = "1990";
            string domain = "com";
            Console.WriteLine($"Email: {fullname.FormatEmail(yearOfBirth, domain)}");

            List<string> words = new List<string> { "obuolys", "bananas", "kriause" };
            string searchWord = "bananas";
            Console.WriteLine($"Rasta: {words.FindAndReturnIfEqual("bananas")}");

            List<string> words2 = new List<string> { "kriause", "bananas", "kriause", "slyva", "kriause", "obuolys", "kriause", "citrina", "kriause" };
            List<string> everyOtherWord = words2.EveryOtherWord();
            foreach (var word in everyOtherWord)
            {
                Console.Write($"{word} ");
            }

        }
    }
}
