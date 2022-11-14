SampleEx502.Dummy d = new SampleEx502.Dummy();
SampleEx502.IFunc1 i1 = (SampleEx502.IFunc1)d;
SampleEx502.IFunc2 i2 = (SampleEx502.IFunc2)d;
i1.Func1();
i1.Func2();
// 同じメソッド名で、引数も同じものであっても別の関数として使用できる。
// 抽象クラスとinterfaceの違いである。
i2.Func2();
i2.Func3();
