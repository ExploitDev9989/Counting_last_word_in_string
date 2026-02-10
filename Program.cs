namespace Counting_last_word_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentance to count the # of characters in the last word : ");
            string a = Console.ReadLine();
            int length = a.Length - 1;
            int counter = 0;

            while (length >= 0 && a[length] == ' ')
            {
                length--;
            }
            while (length >= 0 && a[length] != ' ')
            {
                counter++;
                length--;
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Original sentance: {a}\n" +
                $"Total amount of letters int the last word: {counter}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
