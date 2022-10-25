using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample703
{
    internal class Person2
    {
        public void ShowAgeAndName(){
            Console.WriteLine( "名前 : {0} 年齢 : {1}", Name, Age );
        }
        public void SetAgeAndName( string name, int age ){
            Name = name;
            Age  = age;
        }
        // プロパティという概念
        // 下記のプロパティで説明すると
        // Nameというプロパティにアクセスると
        // set : 値を代入したり
        // get : 値を取得したり
        // することができる。
        // 使用例はProgram.csへ
        public string Name{
            // privateがついているので、Nameプロパティはどこからでもアクセスできるが
            // 値の変更はPerson2のクラス内でしかできない
            private set; get;
        }
        public int Age{
            set; get;
        }
    }
}
