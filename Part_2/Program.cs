namespace Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Метод разделения строки на слова");
            string sentence = SentenceInput();
            string reversedSentence = ReversWords(sentence);
            Console.WriteLine(reversedSentence);
        }

        static string SentenceInput()
        {
            Console.WriteLine("Введите фразу:");
            string sentence = Console.ReadLine();
            return sentence == null ? "" : sentence;
        }

        static string[] ArrayWordsReturn(string sentence)
        {
            string[] wordsArray = sentence.Split(' ');
            Console.WriteLine("\n Результат вывода:");
            return wordsArray;
        }

        static string ReversWords(string sentence)
        {
            string[] words = ArrayWordsReturn(sentence);
            string reversedWords = "";
            for (int i = words.Length-1; i >= 0; i--)
            {
                reversedWords += words[i] + " ";
            }
            return reversedWords;
        }
    }
}
