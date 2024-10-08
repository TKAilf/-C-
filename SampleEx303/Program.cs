﻿SampleEx303.Parent p = new SampleEx303.Parent();
// cはParentクラスとして振る舞う。
SampleEx303.Parent c = new SampleEx303.Child();
p.Foo();
c.Foo();

// このような書き方をすることで、 p, c を同等の型として
// 集めておくことができる。(配列に突っ込むことができる)
// この状態で、p, cを通常のクラスとして使用したい場合を考えてオーバーライドが存在する。

// 例 : 鳥クラスを大量に集めた配列クラス鳥[]がある際に、
// 実際に突っ込んでいるのは鳥クラスを継承したカラスクラスや雀クラス等である。
// このカラスクラスや雀クラスに、鳴く()というメソッドを利用したいと考えている際に有用である。
