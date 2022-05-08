using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace study_DSA_cs.heap
{
	public class Bj
	{
		private static List<int> HeapList = new List<int>();

		public static void MaxHeapAdd(int value)
        {
			HeapList.Add(value);

			int i = HeapList.Count - 1;
			while (i > 0)
            {
				int parent = (i - 1) / 2;
				if (HeapList[parent] < HeapList[i]) // MinHeap에선 반대
                {
					Swap(parent, i);
					i = parent;
                }
                else
                {
					break;
                }
            }
        }

        public static void MinHeapAdd(int value)
        {
            HeapList.Add(value);

            int i = HeapList.Count - 1;
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (HeapList[parent] > HeapList[i]) // MinHeap에선 반대
                {
                    Swap(parent, i);
                    i = parent;
                }
                else
                {
                    break;
                }
            }
        }

        public static int MaxHeapRemoveOne()
        {
			if (HeapList.Count == 0)
				return 0;

			int root = HeapList[0];

            // move last to first 
            // and remove last one
            HeapList[0] = HeapList[HeapList.Count - 1];
            HeapList.RemoveAt(HeapList.Count - 1);

            // bubble down
            int i = 0;
            int last = HeapList.Count - 1;
            while (i < last)
            {
                // get left child index
                int child = i * 2 + 1;

                // use right child if it is bigger                
                if (child < last &&
                    HeapList[child] < HeapList[child + 1]) // MinHeap에선 반대
                    child = child + 1;

                // if parent is bigger or equal, stop
                if (child > last ||
                   HeapList[i] >= HeapList[child]) // MinHeap에선 반대
                    break;

                // swap parent/child
                Swap(i, child);
                i = child;
            }

            return root;
        }

        public static int MinHeapRemoveOne()
        {
            if (HeapList.Count == 0)
                return 0;

            int root = HeapList[0];

            // move last to first 
            // and remove last one
            HeapList[0] = HeapList[HeapList.Count - 1];
            HeapList.RemoveAt(HeapList.Count - 1);

            // bubble down
            int i = 0;
            int last = HeapList.Count - 1;
            while (i < last)
            {
                // get left child index
                int child = i * 2 + 1;

                // use right child if it is bigger                
                if (child < last &&
                    HeapList[child] > HeapList[child + 1]) // MinHeap에선 반대
                    child = child + 1;

                // if parent is bigger or equal, stop
                if (child > last ||
                   HeapList[i] <= HeapList[child]) // MinHeap에선 반대
                    break;

                // swap parent/child
                Swap(i, child);
                i = child;
            }

            return root;
        }

        private static void Swap(int i, int j)
        {
			int t = HeapList[i];
			HeapList[i] = HeapList[j];
			HeapList[j] = t;
        }

        public static void _1927()
        {
            int totIdx = Int32.Parse(Console.ReadLine());
            SortedList list = new SortedList();

            foreach (var idx in Enumerable.Range(1, totIdx))
            {
                int num = Int32.Parse(Console.ReadLine());
                if (num == 0)
                {
                    if (list.Count > 0)
                    {
                        Console.WriteLine(list.GetKey(0));
                        list.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }

                }
                else
                {
                    list.Add(num, num);
                }
            }
        }
	}
}

