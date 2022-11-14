using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx501
{
    internal class Data : IWriteData, IReadData
    {
        private int num;
        public void Write( int num )
        {
            this.num = num;
        }
        public int Read()
        {
            return num;
        }
    }
}
