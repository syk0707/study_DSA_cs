using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace study_DSA_cs.sort
{
    public class Prog
    {
        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutations(list, length - 1)
                .SelectMany(t => list,
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        public static IEnumerable<IEnumerable<T>> GetCombinationsRepeat<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetCombinationsRepeat(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) >= 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        public static IEnumerable<IEnumerable<T>> GetCombinations<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetCombinations(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

        public static void _42746()
        {
            int[] numbers = new int[5] { 3, 30, 34, 5, 9};
            string answer = "";
            int maxLen = 1000;
            StringBuilder sb = new StringBuilder();
            Dictionary<int, string> numDic = new Dictionary<int, string>();

            for (int i = 0; i < numbers.Length; ++i)
            {
                string numStr = numbers[i].ToString();
                while (numStr.Length < maxLen)
                {
                    numStr = numStr + numStr;
                }
                if (numStr.Length > maxLen)
                {
                    numStr = numStr.Substring(0, maxLen);
                }
                numDic.Add(i, numStr);
            }
            var resultDic = numDic.OrderByDescending(x => x.Value);
            foreach (var keyValue in resultDic)
            {
                sb.Append(numbers[keyValue.Key]);
            }
            if (sb[0] == '0')
            {
                sb.Clear();
                sb.Append("0");
            }
            answer = sb.ToString();
        }

        public static void _12977()
        {
            int[] nums = new int[5] { 1, 2, 7, 6, 4 };
            //var sortNum = nums.OrderBy(num => num).ToList();
            //int maxNum = sortNum[nums.Length - 1];
            var caseList = GetCombinations<int>(nums, 3);
            //Console.WriteLine(JsonSerializer.Serialize(sortNum));
            int answer = 0;
            foreach(var caseItem in caseList)
            {
                int calNum = caseItem.Sum();
                bool isDivideNum = false;
                for (var divideNum = 2; divideNum < calNum; divideNum++)
                {
                    if (calNum % divideNum == 0)
                    {
                        isDivideNum = true;
                        break;
                    }
                }
                if (!isDivideNum)
                    answer++;
            }
            Console.WriteLine(answer);
        }
    }
}
