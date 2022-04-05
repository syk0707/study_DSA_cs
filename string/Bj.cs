using System;
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
    }
}
