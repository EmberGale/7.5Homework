using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5Homework
{
    internal class _2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Метод разделения строки на слова");
            string sentence = SentenceInput();
            string[] words = ArrayWordsReturn(sentence);
            PrintWords(words);
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

        static string ReversWords(string[] words)
        {
            string reversedWords = "";
            for (int i = words.Length; i>=0; i--)
            {
                reversedWords += i + " ";
            }
            return reversedWords;
        }

        static void PrintWords(string[] words)
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
