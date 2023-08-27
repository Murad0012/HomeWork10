using System.Diagnostics.Tracing;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "Hello World";
            string input = word.ToLower();
            int vowelsCount = 0;
            int consonatsCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'o' || input[i] == 'u' || input[i] == 'i' || input[i] == 'e' || input[i] == 'ı' || input[i] == 'ə' || input[i] == 'ö' || input[i] == 'ü')
                {
                    vowelsCount++;
                }
                else if (input[i] != ' ')
                {
                    consonatsCount++;
                }
            }
            Console.WriteLine("Vowels : " + vowelsCount);
            Console.WriteLine("Consonats : " + consonatsCount);
        }
    }
}