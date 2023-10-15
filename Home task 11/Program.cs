namespace Home_task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FormatProsessi();

        }

        public static void FormatProsessi()
        {
            Console.WriteLine("Cumleni daxil edin : ");
            string inputİnSentence = Console.ReadLine();
            string correctSentence = CorrectFormat(inputİnSentence);
            Console.WriteLine();
            Console.WriteLine("Duzgun formatda olan  cumle: " + correctSentence);
        }

        public static string CorrectFormat(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0)
                {
                    string firstLetter = words[i][0].ToString().ToUpper();
                    string otherLetters = words[i].Substring(1).ToLower();
                    words[i] = firstLetter + otherLetters;
                }
            }

            string correctSentence = string.Join(" ", words);
            return correctSentence;
        }

    }
}