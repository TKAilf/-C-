using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx103
{
    internal class Dummy
    {
        public Dummy(){
            Console.WriteLine( "コンストラクタ" );
        }

        ~Dummy(){
            Console.WriteLine( "デストラクタ" );
        }
    }
}
