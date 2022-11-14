ExerciseEx501.Data d = new ExerciseEx501.Data();
// ExerciseEx501.IReadData rd  = ( ExerciseEx501.IReadData )d;
// ExerciseEx501.IWriteData rw = ( ExerciseEx501.IWriteData )d;
// キャストは省略できる。
ExerciseEx501.IReadData rd  = d;
ExerciseEx501.IWriteData rw = d;
rw.Write(1);
int num = rd.Read();
Console.WriteLine( "data={0}", num );
