using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDelegate
{
    public class Class1
    {
        public Action<bool> _listShow;
        public Class1(Action<bool> action)
        {
            _listShow = action;
        }
        public Class1()
        {
        }
        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}
