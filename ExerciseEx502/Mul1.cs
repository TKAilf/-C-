using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx502
{
    internal class Mul1 : IMul
    {
        private int num1;
        private int num2;
        public Mul1( int num1, int num2 )
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public int Calc()
        {
            return num1 * num2;
        }
    }
}
