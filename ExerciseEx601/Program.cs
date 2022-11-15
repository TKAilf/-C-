List<int> list = new List<int>();
while( true ){
    int number = int.Parse( Console.ReadLine() );
    list.Add( number );
    if( 0 < number && number < 11 ){
        foreach( int n in list ){
            Console.Write( "{0} ", n );
        }
        Console.WriteLine();
        Console.WriteLine( "最大値 : {0} 最小値 : {1}", list.Max(), list.Min() );
        break;
    }else{
        Console.WriteLine( "1から10以内の整数で入力してください。" );
    }
}
// int nMax = list[0];
// int nMin = list[0];
// for( int i = 0; i < list.Count; i++ ){
//     if( nMax < list[i] ){
//         nMax = list[i];
//     }
//     if( list[i] < nMin ){
//         nMin = list[i];
//     }
// }
// Console.WriteLine( "最大値 : {0} 最小値 : {1}", nMax, nMin );


