using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx402
{
    // Birdは抽象クラスである。
    // 抽象クラスはインスタンスを生成することができない。
    abstract internal class Bird
    {
        private String name;
        public Bird( string name ){
            this.name = name;
        }
        public String Name
        {
            get { return name; }
        }
        // 抽象メソッド : 子クラスでオーバーライドして使用するメソッド
        public abstract void Sing();
    }
}
