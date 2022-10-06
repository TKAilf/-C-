// See https://aka.ms/new-console-template for more information
// ジャグ配列 : 不揃いの配列
int[][] a = new int[][] { new int[]{0, 1}, new int[]{2}, new int[]{3, 4, 5, 6} };
for( int m = 0; m < a.Length; m++ ){
    for( int n = 0; n < a[m].Length; n++ ){
        Console.Write( a[m][n] + " " );
    }
    Console.WriteLine();
}
