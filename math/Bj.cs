using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study_DSA_cs.math
{
    public class Bj
    {
        public static void _11816()
        {
            string testNum = Console.ReadLine();
            // 16진수
            if (testNum.IndexOf("0x") == 0)
            {
                Console.WriteLine(Convert.ToInt32(testNum, 16));
            }
            // 8진수
            else if (testNum.IndexOf("0") == 0)
            {
                Console.WriteLine(Convert.ToInt32(testNum, 8));
            }
            // 10진수
            else
            {
                Console.WriteLine(testNum);
            }
        }
    }
}
