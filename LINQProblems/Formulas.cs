using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    public class Formulas
    {
        public string key = "th";
        public List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics"};

        
        static IEnumerable<string> CheckForKey(List<string> words)
        {
            foreach (string word in words)
            {
                Console.WriteLine(word);
                //if(words = "th")
                //{
                //    yield return word;
                //}
                yield return word;
            }
        }
    }
}
