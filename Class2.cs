using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllDelegate
{
    public class Class2
    {
        private Func<int, bool> _calcdeligate;
        private Class1 _class1 = new Class1();
        public Func<int, int, int> _pow1;
        private int _savedPow;

        public Func<int, bool> Calc(Func<int, int, int> func, int a, int b)
        {
            func = _class1.Pow;
            func = _class1.Pow;
            _savedPow = func.Invoke(a, b);
            return _calcdeligate = Result;
        }

        public bool Result(int x)
        {
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
