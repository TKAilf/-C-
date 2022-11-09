using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEx101
{
    internal class Person
    {
        // public Person(){
        //     Console.WriteLine( "引数なしコンストラクタ" );
        // }
        public Person() : this( "名無し", 0 ){
            Console.WriteLine( "引数なしコンストラクタ" );
        }
        public Person( string name, int age ){
            Name = name;
            Age = age;
            Console.WriteLine( "引数ありコンストラクタ name : {0} age : {1}", name, age );
        }
        public void ShowAgeAndName(){
            Console.WriteLine( "名前 : {0} 年齢 : {1}", Name, Age );
        }
        public string Name
        {
            set; get;
        }
        public int Age
        {
            set; get;
        }
    }
}
