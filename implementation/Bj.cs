using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace study_DSA_cs.implementation
{
    public class Bj
    {
        public static void _1032()
        {
            int totNum = Int32.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            List<char> compareList = new List<char>();
            //string listStr = JsonSerializer.Serialize(list);
            //List<string> test = JsonSerializer.Deserialize<List<string>>(listStr);
            for (int i = 0; i < totNum; i++)
            {
                string str = Console.ReadLine();
                list.Add(str);
                List<char> eachList = str.ToCharArray().ToList();
                if (i == 0) compareList = eachList;
                else
                {
                    for (int j = 0; j < compareList.Count; j++)
                    {
                        if (eachList[j] != compareList[j]) compareList[j] = '?';
                    }
                }
            }
            Console.WriteLine(string.Join("", compareList));
        }

        public static void _2441()
        {
            var inputNum = Console.ReadLine();
            if (Int32.TryParse(inputNum, out int totNum))
            {
                for (var i = totNum; i > 0; i--)
                {
                    Console.Write(new string(' ', totNum - i));
                    Console.WriteLine(new string('*', i));
                }
            }

        }

        public static void _23746()
        {
            var totIdx = Console.ReadLine();
            if (Int32.TryParse(totIdx, out int totNum))
            {
                Dictionary<string, string> caseDic = new Dictionary<string, string>();
                for (var i = 0; i < totNum; i++)
                {
                    var input_arr = Console.ReadLine().Split(" ");
                    caseDic[input_arr[1]] = input_arr[0];
                }

                var caseStr = Console.ReadLine();
                string convertStr = string.Empty;
                foreach (var caseChar in caseStr)
                {
                    convertStr += caseDic[caseChar.ToString()];
                }

                var caseIdxArr = Console.ReadLine().Split(" ");
                Console.WriteLine(convertStr.Substring(Int32.Parse(caseIdxArr[0]) - 1, Int32.Parse(caseIdxArr[1]) - Int32.Parse(caseIdxArr[0]) + 1));
                Console.ReadLine();
            }
        }
    }
}
