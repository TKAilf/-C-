// GC : ガーベイジコレクター 必要亡くなったメモリを処理してくれる機構のこと
// String : string と同じもの　エイリアス化されている


String[] a = new String[10000];
for( int i = 0; i < 10000; i++ ){
    a[i] = new String( 'M', 10000 );
}
Console.WriteLine( "メモリ使用量( GC発動前 )   :" + GC.GetTotalMemory(false) );
a = null;
Console.WriteLine( "メモリ使用量( 参照解除後 ) :" + GC.GetTotalMemory(false) );
GC.Collect();
Console.WriteLine( "メモリ使用量( GC発動後 )   :" + GC.GetTotalMemory(false) );
