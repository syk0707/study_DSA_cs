using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study_DSA_cs.sort
{
    public class Programmers
    {
        public static void _42746()
        {
            int[] numbers = new int[5];
            numbers[0] = 3;
            numbers[1] = 30;
            numbers[2] = 34;
            numbers[3] = 5;
            numbers[4] = 9;
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
    }
}
