using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx303
{
    internal class Child : Parent
    {
        // オーバーライドすることの明示
        public override void Foo(){
            Console.WriteLine( "子クラスのFoo()メソッド" );
        }
    }
}
