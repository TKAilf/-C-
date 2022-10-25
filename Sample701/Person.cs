using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample701
{
    internal class Person
    {
        private string name = "";
        private int age     = 0;
        public void ShowAgeAndName(){
            Console.WriteLine( "名前 : {0} 年齢 : {1}", name, age );
        }
        public void SetAgeAndName( string name, int age ){
            this.name = name;
            this.age  = age;
        }
        // プロパティという概念
        // 下記のプロパティで説明すると
        // Nameというプロパティにアクセスると
        // set : 値を代入したり
        // get : 値を取得したり
        // することができる。
        // 使用例はProgram.csへ
        public string Name{
            set { name = value; }
            get { return name; }
        }
        public int Age{
            set { age = value; }
            get { return age; }
        }
    }
}
