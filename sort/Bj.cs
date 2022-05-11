using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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

        public static void _10816()
        {
            var totCardIdx = Int32.Parse(Console.ReadLine());
            Dictionary<string, int> cardDic = new Dictionary<string, int>();
            var cardNumArr = Console.ReadLine().Split(' ');
            foreach (var cardNum in cardNumArr)
            {
                if (cardDic.ContainsKey(cardNum))
                {
                    cardDic[cardNum] += 1;
                }
                else
                {
                    cardDic[cardNum] = 1;
                }
            }
            var totCardNumIdx = Int32.Parse(Console.ReadLine());
            var checkCardNumArr = Console.ReadLine().Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (var checkCardNum in checkCardNumArr)
            {
                if (cardDic.ContainsKey(checkCardNum))
                {
                    sb.Append(cardDic[checkCardNum]);
                }
                else
                {
                    sb.Append(0);
                }
            }
            Console.Write(sb.ToString());
        }
    }
}
