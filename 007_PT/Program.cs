﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_PT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();
            g.ReadGraph("graph2.txt");
            g.PrintGraph();

            g.Prim(6);  // 0번 버텍스에서 시작하는 MST
        }
    }
}
