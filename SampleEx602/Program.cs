List<string> a = new List<string>();
a.Add( "Taro" );
a.Add( "Hanako" );
a.Add( "Jiro" );
a.Add( "Kaoru" );
a.Add( "Taro" );
// 配列の要素で始めに見つけ出したものを指定して削除
a.Remove( "Taro" );
// 配列のインデックスを指定して削除
a.RemoveAt( 1 );
foreach( string s in a ){
    Console.WriteLine( s );
}
