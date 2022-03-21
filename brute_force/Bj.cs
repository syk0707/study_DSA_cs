using System;
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
    }
}