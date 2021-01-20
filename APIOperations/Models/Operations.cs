using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIOperations
{
    public class Operations
    {
        public int sum(int a, int b)
        {
            return a += b;
        }

        public double divide(int a, int b)
        {
            double c = (double)a / (double)b;
            return c;
        }

    }
}
