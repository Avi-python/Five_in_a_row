using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GobangLibrary
{
    public sealed class Human : Player
    {
        public override int input()
        {
            // 會從介面上面等待輸入
            return 0;
        }
        public Human(string input) : base(input) { }
    }

}
