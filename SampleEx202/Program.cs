namespace SampleEx202
{
    class Program
    {
        private static int snum = 100;
        public int inum = 200;
        public static void foo()
        {
            Console.WriteLine( "fooメソッド(staticメソッド)" );
        }
        public void bar()
        {
            Console.WriteLine( "barメソッド(インスタンスメソッド)" );
        }
        // string[] args : argsはコンソールから呼び出されるときに追加される文字列
        // 例えば Hoge.exe abc def ghiとコンソールに打ち込むと
        // args[0] = "abc"
        // args[1] = "def"
        // args[2] = "ghi"
        // というように認識される。
        static void Main( string[] args )
        {
            Program p = new Program();
            Console.WriteLine( "pのインスタンスフィールド : inum = {0}", p.inum );
            Console.WriteLine( "Programのクラスフィールド : snum = {0}", snum );
            foo();
            p.bar();
        }
    }
}
