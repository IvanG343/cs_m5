using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_m5 {
    internal class Program {
        static void Main(string[] args) {

            //Task 1
            Console.Write("Задача 1. Введите строку текста: ");
            PrintWordsArray(SplitText(Console.ReadLine())); 

            Console.WriteLine();

            //Task 2
            Console.Write("Задача 2. Введите строку текста: ");
            Console.WriteLine(ReversWords(Console.ReadLine())); 

            Console.ReadKey();
        }

        //Task 1 & Task 2
        static string[] SplitText(string text) {
            return text.Split(' ');
        }

        //Task 1
        static void PrintWordsArray(string[] array) {
            foreach (var e in array) {
                Console.WriteLine(e);
            }
        }

        //Task 2
        static string ReversWords(string text) {
            string[] wordsArray = SplitText(text);
            string resultString = null;
            for (int i = wordsArray.Length -1; i >= 0; i--) {
                resultString += (wordsArray[i] + " ");
            }
            return resultString;
        }

    }
}
