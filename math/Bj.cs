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

        public static void _5086()
        {
            while (true)
            {
                var input_num = Console.ReadLine();
                if (input_num == "0 0") break;
                var input_array = input_num.Split(' ');
                var first_num = Int32.Parse(input_array[0]);
                var second_num = Int32.Parse(input_array[1]);
                if (first_num > second_num && first_num % second_num == 0)
                {
                    Console.WriteLine("multiple");
                }
                else if (second_num > first_num && second_num % first_num == 0)
                {
                    Console.WriteLine("factor");
                }
                else
                {
                    Console.WriteLine("neither");
                }
            }
        }

        public static void _14916()
        {
            var numStr = Console.ReadLine();
            if (Int32.TryParse(numStr, out int num))
            {
                var quotient = num % 5;
                if (num == 1 || num == 3)
                {
                    Console.WriteLine(-1);
                }
                else if (quotient % 2 == 0)
                {
                    Console.WriteLine(Math.Truncate((double)num / 5) + Math.Truncate((double)quotient / 2));
                }
                else
                {
                    Console.WriteLine(Math.Truncate((double)num / 5) - 1 + Math.Truncate((double)(quotient + 5) / 2));
                }
            }
        }
    }
}
