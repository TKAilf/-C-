﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx502
{
    internal class Dummy : IFunc1, IFunc2
    {
        public void Func1()
        {
            Console.WriteLine( "Func1" );
        }
        public void Func2()
        {
            Console.WriteLine( "Func2" );
        }
        public void Func3()
        {
            Console.WriteLine( "Func3" );
        }
    }
}
