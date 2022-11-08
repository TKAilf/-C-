using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx202
{
    internal class Numeric
    {
        static public int Max( int a, int b )
        {
            if( b - a < 0 ){
                return a;
            }else{
                return b;
            }
        }
    }
}
