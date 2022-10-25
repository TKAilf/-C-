Sample701.Person p1, p2;
p1 = new Sample701.Person();
p2 = new Sample701.Person();
p1.Name = "山田太郎";
p1.Age  = 19;
p2.SetAgeAndName( "佐藤花子", 23 );
p1.ShowAgeAndName();
Console.WriteLine( "名前 : {0} 年齢 : {1}", p2.Name, p2.Age );
