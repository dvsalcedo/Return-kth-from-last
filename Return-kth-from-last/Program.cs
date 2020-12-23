using System;
using System.Collections;

namespace Return_kth_from_last
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var kthfound = 0;
            LinkedLists linklist = new LinkedLists();
            linklist.append(1);
            linklist.append(2);
            linklist.append(3);
            linklist.append(4);
            linklist.append(5);
            linklist.append(6);
            linklist.append(7);
            linklist.append(8);

            linklist.print();
            kthfound = FindKthFromLast(linklist, 5);
            System.Console.WriteLine("Result: " + kthfound);
        }

        static int FindKthFromLast(LinkedLists linklist, int kthelement)
        {
            var nodeSlow = linklist.First();
            var nodeFast = linklist.First();

            if(kthelement <= 0)
                return -1;

            for (int i=1 ; i < kthelement ; i++){
                if(nodeFast.next != null)
                    nodeFast = nodeFast.next;
                else
                    return -1;
            }

            while(nodeFast != null){
                if(nodeFast.next == null){
                    return nodeSlow.value;
                }else {
                    nodeFast = nodeFast.next;
                    nodeSlow = nodeSlow.next;
                }
            }

            return -1;

        }
    }
}
