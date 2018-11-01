using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Road
   
    {
        public int node1;
        public int node2;

        public float width;
        public float length;

        public float trust;
        public Road(int n1, int n2, float leng, float wid, float tru)
        {
            node1 = n1;
            node2 = n2;
            width = wid;
            trust = tru;
            length = leng;
        }

        public void print()
        {
            System.Console.WriteLine(node1 + " " + node2 + " " + width + " " + length + " " + trust);
        }

    }

    
