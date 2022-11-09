using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx303
{
    internal class Parent
    {
        // virtual : オーバーライドの準備
        public virtual void Foo(){
            Console.WriteLine( "親クラスのFoo()メソッド" );
        }
    }
}
