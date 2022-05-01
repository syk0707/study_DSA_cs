using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace study_DSA_cs.math
{
    public class Bj
    {
        public static long getLCM(long a, long b)
        {
            long num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (long i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }
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

        public static void _13241()
        {
            var inputArr = Console.ReadLine().Split(' ');
            var firstNum = Int64.Parse(inputArr[0]);
            var secondNum = Int64.Parse(inputArr[1]);
            Console.WriteLine(getLCM(firstNum, secondNum));
        }

        public static void _2576()
        {
            var inputArr = new List<int>();
            IEnumerable<int> ranges = Enumerable.Range(1, 7);
            foreach(var range in ranges)
            {
                var num = Int32.Parse(Console.ReadLine());
                if (num % 2 == 1)
                    inputArr.Add(num);
            }
            if (inputArr.Count == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                inputArr.Sort();
                Console.WriteLine(inputArr.Sum());
                Console.WriteLine(inputArr[0]);
            }
        }
    }
}
