using System;

namespace AI
{
    internal class Program
    {
        static void show_Data()
        {
            Console.WriteLine("외부 데이터 없이 자체 작동");
        }

        static int devide(int x, int y)
        {   
            if (y != 0)
            {
                int retval;
                retval = x / y;
                Console.WriteLine("{0} {1}을 나눈 값 : {2}", x, y, retval);
                return retval;
            }
            else
            {
                Console.WriteLine("0으로 못나눔");
                return 0;
            }
        }

        static void Main(string[] args)
        {
            show_Data();
            devide(7, 3);
            devide(0, 3);
            devide(7, 0);
        }
    }
}
