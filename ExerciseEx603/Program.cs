Dictionary<string, string> dic = new Dictionary<string, string>();
dic["January"] = "1月";
dic["Feburary"] = "2月";
dic["March"] = "3月";
dic["April"] = "4月";
dic["May"] = "5月";
dic["Jun"] = "6月";
dic["July"] = "7月";
dic["August"] = "8月";
dic["September"] = "9月";
dic["Actober"] = "10月";
dic["Novenber"] = "11月";
dic["December"] = "12月";
bool flag = false;
while( true ){
    string s = Console.ReadLine();
    foreach( string key in dic.Keys ){
        if( s == key ){
            Console.WriteLine( "英語の{0}は、日本語で{1}です。", s, dic[s] );
            flag = true;
            break;
        }
    }
    if( flag != true ){
        Console.WriteLine( "正しく入力してください。" );
    }else{
        break;
    }
}
