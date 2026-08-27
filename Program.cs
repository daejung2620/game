using System;
using System.Formats.Asn1;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cast.CastInt();
        }
    }

    internal class Cast() 
    { 
        public static void CastInt() 
        { 

            string val = "33";
            string val1 = "3.14";

            int ret = 0;
            float ret1 = 0;

            ret = int.Parse(val);
            Console.WriteLine(ret); //정수

            ret1 = float.Parse(val);
            Console.WriteLine(ret); //실수2

            double ret2 = double.Parse(val1);
            Console.WriteLine(ret2); // 실수2


            Console.WriteLine(""); //변환 전용 함수

            ret = Convert.ToInt32(val);
            ret1 = Convert.ToSingle(val1);
            Console.WriteLine("{0:F4}",ret1);
        }
    }

    internal class ObType
    {
        public static void Boxing()
        {
            object box = 50;
            Console.WriteLine("{0}",box);

            int unboxed = (int)box;
            Console.WriteLine("{0}",unboxed);

            unboxed += 5;
            Console.WriteLine("{0}", unboxed);
        }
    }

    internal class Statements
    {
        public static void Ternary() 
        {
            int num = -3;
            int abs;

            abs = (num > 0) ? num : num * (-1);
            Console.WriteLine(num + "절대 value " + abs);
        }
    }

    internal class gugudan
    {
        public static void loopwhile()
        {
            int count = 0;
            Console.WriteLine("{0}",count);
            while (count < 5)
            {
                Console.WriteLine("반복" + count);
                count++;
            }
            Console.WriteLine("완료");
        }
    }
}
