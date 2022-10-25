Sample703.Person2 p = new Sample703.Person2();
p.SetAgeAndName( "山田太郎", 26 );
// 年齢の変更はpublicのため可能
p.Age = 32;
// 名前の変更はprivateのため不可能
// p.Name = "はなおかはなこ"
Console.WriteLine( "名前 : {0} 年齢 : {1}", p.Name, p.Age );
