using System;
using System.Collections.Generic;
using System.Text;

namespace study_DSA_cs.@string
{
    public class Bj
    {
        public Bj()
        {
        }

        public static void _5598()
        {
            string inputVal = Console.ReadLine();
            byte[] inputBytes = Encoding.ASCII.GetBytes(inputVal);
            foreach(var item in inputBytes){
                var num = Int32.Parse(item.ToString());
                if (num <= 67)
                {
                    num = num + 26;
                }
                Console.Write(Convert.ToChar(num - 3));
            }
            Console.ReadLine();
        }

        public static void _9324()
        {
            var totIdx = Int32.Parse(Console.ReadLine());
            for(var idx = 0; idx < totIdx; idx++)
            {
                var str = Console.ReadLine();
                var checkDic = new Dictionary<char, int>();
                bool isReal = true;
                for(var charIdx = 0; charIdx < str.Length; charIdx++)
                {
                    var eachChar = str[charIdx];
                    if (checkDic.ContainsKey(eachChar))
                    {
                        checkDic[eachChar] += 1;
                        if (checkDic[eachChar] % 3 == 0)
                        {
                            if(charIdx + 1 == str.Length || str[charIdx + 1] != eachChar)
                            {
                                isReal = false;
                                break;
                            }
                            else
                            {
                                charIdx++;
                            }
                        }
                    }
                    else
                    {
                        checkDic[eachChar] = 1;
                    }
                }
                if (isReal)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("FAKE");
                }
            }
        }
    }
}
