// See https://aka.ms/new-console-template for more information
int[] n = new int[10];
Random random = new Random();
for( int i = 0; i < n.Length; i++ ){
    n[i] = random.Next( 1, 101 );
}
int sum, min, max;
sum = 0;
min = 100;
max = 0;
for( int j = 0; j < n.Length; j++ ){
    Console.Write( n[j] + " " );
    sum += n[j];
    if( n[j] < min ){
        min = n[j];
    }
    if( max < n[j] ){
        max = n[j];
    }
}
Console.WriteLine();
Console.WriteLine( "合計値:" + sum );
double avg = 0.0;
avg = sum / (double)n.Length;
Console.WriteLine( "平均値:" + avg );
Console.WriteLine( "最小値:" + min );
Console.WriteLine( "最大値:" + max );
