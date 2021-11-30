using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace study_DSA_cs.implementation
{
    public class Baekjoon
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
    }
}
