using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// interfaceとは抽象クラスしかないクラスのこと。
// 抽象クラスしかないため、abstractを付ける必要がない。
namespace SampleEx501
{
    interface IEmail
    {
        void SendMail( string address );
    }
}
