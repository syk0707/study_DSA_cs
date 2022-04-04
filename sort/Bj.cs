using System;
using System.Collections.Generic;
using System.Linq;

namespace study_DSA_cs.sort
{
    public class Bj
    {
        public static void _15702()
        {
            var caseArr = Console.ReadLine().Split(' ');
            var scoreArr = Console.ReadLine().Split(' ');
            var studentDic = new Dictionary<int, int>();
            for (var i = 0; i < Int32.Parse(caseArr[1]); i++)
            {
                var eachArr = Console.ReadLine().Split(' ');
                var score = 0;
                for (var j = 1; j < eachArr.Length; j++)
                {
                    if (eachArr[j] == "O")
                    {
                        score += Int32.Parse(scoreArr[j - 1]);
                    }
                }
                studentDic[Int32.Parse(eachArr[0])] = score;
            }

            var sortDic = from entry in studentDic orderby entry.Value descending, entry.Key ascending select entry;
            
            Console.WriteLine($"{sortDic.First().Key} {sortDic.First().Value}");
        }
    }
}
