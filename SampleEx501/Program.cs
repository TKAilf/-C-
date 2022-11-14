SampleEx501.CellPhone cp = new SampleEx501.CellPhone( "hoge@email.com", "090-1234-5678" );
cp.Call( "011-123-4567" );
cp.SendMail( "fuga@email.com" );
// interface IPhoneでキャストすると
// IPhoneのメソッドのみ使用できるインスタンスを作成できる。
SampleEx501.IPhone phone = (SampleEx501.IPhone)cp;
phone.Call( "011-987-6543" );
// phone.SendMail( "foo@email.com" );
// interface IEmailでキャストすると
// IEmailのメソッドのみ使用できるインスタンスを作成できる。
SampleEx501.IEmail mail = (SampleEx501.IEmail)cp;
mail.SendMail( "bar@email.com" );
// mail.Call( "011-222-3333" );
