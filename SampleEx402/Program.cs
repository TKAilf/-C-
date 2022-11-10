// Birdクラスの変数の配列を生成
SampleEx402.Bird[] b = new SampleEx402.Bird[2];
// b[0]にCrowインスタンスを生成
b[0] = new SampleEx402.Crow();
// b[1]にSparrowインスタンスを生成
b[1] = new SampleEx402.Sparrow();
for( int i = 0; i < b.Length; i++ ){
    Console.Write( b[i].Name + " : " );
    b[i].Sing();
}
