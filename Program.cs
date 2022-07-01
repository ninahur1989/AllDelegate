using System;

namespace AllDelegate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Class2 class2 = new Class2();

            void Show(bool a)
            {
                Console.WriteLine(a);
            }

            Show(class2.Calc(class2._pow1, 3, 4)(3));
        }
    }
}
