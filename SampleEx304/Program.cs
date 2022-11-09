// C#は暗黙のうちにObjectクラスをすべて継承するようになっている。
// Objectクラスの中に、ToString()等のメソッドが存在し、使用することができるようになっている。
// VisualStadioでs.   と入力すると様々なメソッドが表示される。
// ToString() : 現在の名前空間.クラス名が返ってくる。

namespace SampleEx304
{
    class Program
    {
        public void Foo()
        {
            Console.WriteLine( "Foo" );
        }
        static void Main( string[] args )
        {
            Program s = new Program();
            Console.WriteLine( s.ToString() );
        }
    }
}
