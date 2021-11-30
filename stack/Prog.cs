using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_DSA_cs.stack
{
    public class Prog
    {
        public static void _42587()
        {
            int[] priorities = new int[6] { 1, 1, 9, 1, 1, 1 };
            int location = 0;
            int answer = 0;
            Dictionary<int, int> keyValues = new Dictionary<int, int>();
            for(var i = 0; i < priorities.Length; i++)
            {
                keyValues[i] = -1;
            }
            int maxValue = priorities.Max();
            while (priorities[location] != 0)
            {
                for (var j = 0; j < priorities.Length; j++)
                {
                    if (priorities[j] == maxValue)
                    {
                        answer++;
                        priorities[j] = 0;
                        if (j == location)
                            break;
                        maxValue = priorities.Max();
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
