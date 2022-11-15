// HashSet : 重複した要素は持たないようになる配列クラス。
HashSet<int> t = new HashSet<int>();
t.Add(1);
t.Add(2);
t.Add(3);
t.Add(1);
foreach( int i in t ){
    Console.WriteLine( "{0}", i );
}
