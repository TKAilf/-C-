using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx302
{
    internal class Super
    {
        private int param = 0;
        public Super(){
            Console.WriteLine( "Superのコンストラクタ(引数なし)" );
        }
        public Super( int param ){
            Console.WriteLine( "Superのコンストラクタ(引数 : param = {0})", param );
            this.param = param;
        }
        ~Super(){
            Console.WriteLine( "Superのデストラクタ" );
        }
        public void showParam(){
            Console.WriteLine( "param = {0}", param );
        }
    }
}
