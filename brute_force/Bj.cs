using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Summary description for Bj
/// </summary>
namespace study_DSA_cs.brute_force
{
    public class Bj
    {
        public Bj()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static void _4641()
        {
            while (true)
            {
                var case_str = Console.ReadLine();
                if (case_str == "-1") break;
                var case_arr = case_str.Split(' ');
                var case_num_arr = case_arr.Select(s => int.Parse(s)).ToDictionary(key => key, value => value);
                int tot_num = 0;
                foreach (var case_dic in case_num_arr)
                {
                    if (case_dic.Key == 0) continue;
                    if (case_num_arr.ContainsKey(case_dic.Key * 2))
                    {
                        tot_num++;
                    }
                }
                Console.WriteLine(tot_num);
            }
        }

        public static void _1816()
        {
            var totIdx = Int32.Parse(Console.ReadLine());
            for (var idx = 0; idx < totIdx; idx++)
            {
                var checkNum = long.Parse(Console.ReadLine());
                var list = getFactorizationList(checkNum);
                if (list.Count > 0)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }
            }
        }

        static List<long> getFactorizationList(long number)
        {
            List<long> primes = new List<long>();

            for (long i = 2; i <= Math.Pow(10, 6);)
            {
                if (number % i == 0)
                {
                    primes.Add(i);
                    break;
                }
                else
                {
                    i++;
                }
            }

            return primes;
        }
    }
}