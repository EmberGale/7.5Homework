namespace Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Метод разделения строки на слова");
            string sentence = SentenceInput();
            string[] words = ArrayWordsReturn(sentence);
            printWords(words);
        }

        static string SentenceInput()
        {
            Console.WriteLine("Введите фразу:");
            string sentence = Console.ReadLine();
            return sentence == null ? "" : sentence;
        }

        static string[] ArrayWordsReturn(string sentence)
        {
            string[] wordArray = sentence.Split(' ');
            Console.WriteLine("\n Результат вывода:");
            return wordArray;
        }

        static void printWords(string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
