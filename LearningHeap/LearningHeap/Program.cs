﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapByArray heap = new HeapByArray(20);
            heap.Insert(3);
            heap.Insert(2);
            heap.Insert(1);
            heap.Insert(15);
            heap.Insert(5);
            heap.Insert(4);
            heap.Insert(45);
            heap.Delete(2);

            Console.Read();
        }
    }
}
