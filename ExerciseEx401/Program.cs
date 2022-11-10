// Birdクラスの変数の配列を生成
ExerciseEx401.Bird[] b = new ExerciseEx401.Bird[3];
// b[0]にCrowインスタンスを生成
b[0] = new ExerciseEx401.Crow();
// b[1]にSparrowインスタンスを生成
b[1] = new ExerciseEx401.Sparrow();
b[2] = new ExerciseEx401.Chicken();
for( int i = 0; i < b.Length; i++ ){
    Console.Write( b[i].Name + " : " );
    b[i].Sing();
}
