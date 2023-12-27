using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5Homework
{
    internal class _1
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
