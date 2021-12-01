using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_DSA_cs.greedy
{
    public class Bj
    {
        public static void _2864()
        {
            List<string> inputList = Console.ReadLine().Split(' ').ToList();
            List<string> maxList = inputList.Select(x => x.Replace("5", "6")).ToList();
            List<string> minList = inputList.Select(x => x.Replace("6", "5")).ToList();
            int maxVal0 = Int32.Parse(inputList[0].Replace("5", "6"));
            int maxVal1 = Int32.Parse(inputList[1].Replace("5", "6"));
            int minVal0 = Int32.Parse(inputList[0].Replace("6", "5"));
            int minVal1 = Int32.Parse(inputList[1].Replace("6", "5"));
            Console.WriteLine((minVal0 + minVal1) + " " + (maxVal0 + maxVal1));
        }
    }
}
