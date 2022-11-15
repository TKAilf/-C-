List<int> list = new List<int>();
while( true ){
    int number = int.Parse( Console.ReadLine() );
    list.Add( number );
    if( 0 < number && number < 11 ){
        list.Sort();
        list.Reverse();
        foreach( int n in list ){
            Console.Write( "{0} ", n );
        }
        break;
    }else{
        Console.WriteLine( "1から10以内の整数で入力してください。" );
    }
}
