using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace study_DSA_cs.queue
{
    public class Bj
    {
        public static void _18258()
        {
            var totNum = Int32.Parse(Console.ReadLine());
            int lastValue = 0;
            Queue<int> q = new Queue<int>();
            StringBuilder sb = new StringBuilder();
            foreach (var idx in Enumerable.Range(1, totNum))
            {
                var inputType = Console.ReadLine().Split(' ');
                switch (inputType[0])
                {
                    case "push":
                        lastValue = Int32.Parse(inputType[1]);
                        q.Enqueue(lastValue);
                        break;
                    case "pop":
                        if (q.Count > 0)
                        {
                            sb.AppendLine(q.Dequeue().ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                    case "size":
                        sb.AppendLine(q.Count.ToString());
                        break;
                    case "empty":
                        if (q.Count > 0)
                        {
                            sb.AppendLine("0");
                        }
                        else
                        {
                            sb.AppendLine("1");
                        }
                        break;
                    case "front":
                        if (q.Count > 0)
                        {
                            sb.AppendLine(q.Peek().ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                    case "back":
                        if (q.Count > 0)
                        {
                            sb.AppendLine(lastValue.ToString());
                        }
                        else
                        {
                            sb.AppendLine("-1");
                        }
                        break;
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
