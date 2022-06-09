using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDelegate
{
    public class Class2
    {
        private Class1 _class1 = new Class1();
        private int _savedPow;
        public Func<int, bool> _calcdeligate;
        public Class2()
        {
            Calc(_class1.Pow, 6, 3);
        }

        public Func<int, bool> Calc(Func<int, int, int> func, int a, int b)
        {
            _savedPow = func.Invoke(a, b);
            _calcdeligate = Result;
            return _calcdeligate.Invoke;

        }

        public bool Result(int x)
        {
            Random random = new Random();
            x = random.Next(1, 100);
            if (_savedPow % x == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
