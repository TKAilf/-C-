namespace ExerciseEx203
{
    class Program
    {
        static void Main( string[] args )
        {
            Console.Write( "値を入力してください : " );
            int nWork = int.Parse( Console.ReadLine() );
            if( nWork >= 0 ){
                // nWorkの平方根をnWrokに代入
                double r = Math.Sqrt( nWork );
                Console.WriteLine( "{0}の平方根は{1}です", nWork, r );
            }else{
                Console.WriteLine( "正の数を入力してください" );
            }
        }
    }
}
