﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx301
{
    internal class Calculator
    {
        protected int num1;
        protected int num2;
        public int Num1{
            set { num1 = value; }
            get { return num1; }
        }
        public int Num2{
            set { num2 = value; }
            get { return num2; }
        }
        public void add(){
            Console.WriteLine( "{0} + {1} = {2}", num1, num2, num1 + num2 );
        }
        public void sub(){
            Console.WriteLine( "{0} - {1} = {2}", num1, num2, num1 - num2 );
        }
    }
}
