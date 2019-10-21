using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //First problem
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            //where
            var queryedWords = words.Where(s => s.Contains("th")).ToList();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            //for (int i = 0; i < queryedWords.Count; i++)
            //{
            //    Console.WriteLine(queryedWords[i]);
            //}
            //Console.ReadLine();



            //Second Problem
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var results = names.Distinct();
            foreach (string value in results)
            {
                Console.WriteLine(value);
                
            }
            Console.ReadLine();
            //var queryedNames = names.Where(n => n.Distinct(names))
        }
    }
}
