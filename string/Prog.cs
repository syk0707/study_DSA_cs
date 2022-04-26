using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace study_DSA_cs.@string
{
    public class Prog
    {
        public static int[] _92334(string[] id_list, string[] report, int k)
        {
            List<int> answer = new List<int>();
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            Dictionary<string, int> resultDictionary = new Dictionary<string, int>();
            List<string> stopPeople = new List<string>();

            foreach (var id in id_list)
            {
                dic[id] = new List<string>();
                resultDictionary[id] = 0;
            }

            foreach (var eachReport in report)
            {
                var item = eachReport.Split(' ');
                dic[item[0]].Add(item[1]);
            }

            foreach (var dicItem in dic)
            {
                foreach (var name in dicItem.Value.Distinct())
                {
                    resultDictionary[name] += 1;
                }
            }

            foreach (var reportNum in resultDictionary)
            {
                if(reportNum.Value >= k)
                    stopPeople.Add(reportNum.Key);
            }

            foreach (var dicItem in dic)
            {
                var num = 0;
                foreach (var stopPerson in stopPeople)
                {
                    if (dicItem.Value.FindIndex(x => string.Equals(x, stopPerson)) >= 0)
                        num++;
                }
                answer.Add(num);
            }

            return answer.ToArray();
        }
    }
}
