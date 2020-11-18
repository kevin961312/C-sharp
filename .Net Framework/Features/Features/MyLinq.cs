﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    public static class MyLinq
    {
        public static int Count<T>(IEnumerable<T> sequence)
        {
            int _count = 0;
            foreach(var item in sequence)
            {
                _count++;
            }
            return _count;
        }
    }
}
