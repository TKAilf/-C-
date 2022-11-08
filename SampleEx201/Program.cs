SampleEx201.Data[] d = new SampleEx201.Data[2];
SampleEx201.Data.ShowNumber();
for( int i = 0; i < d.Length; i++ ){
    d[i] = new SampleEx201.Data( i * 100 );
    SampleEx201.Data.ShowNumber();
}
