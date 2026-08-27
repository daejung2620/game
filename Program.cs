using System;
using System.Formats.Asn1;

namespace TEST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name;
            //name = "black";
            //Console.WriteLine(name);
            //string ret = Console.ReadLine();
            //Console.WriteLine(name + ret);

            //string strdata = "김경욱은 유명한 블랙형 짐승이다.";

            //Console.WriteLine(strdata.IndexOf("김"));
            //Console.WriteLine(strdata.IndexOf("블랙"));
            //Console.WriteLine(strdata.Contains("."));
            //Console.WriteLine(strdata.Contains("짐승"));

            //strdata = strdata.Replace("김경욱", "김블랙");
            //Console.WriteLine(strdata);

            //string strdata2 = "hole mole";
            //Console.WriteLine(strdata2.ToUpper());
            //Console.WriteLine(strdata2.ToLower());  
            //Console.WriteLine(strdata2.Insert(9, "kimblack"));
            //Console.WriteLine(strdata2.Remove(4, 4));

            cast.caststring();
            Cast.CastInt();
        }
    }


    internal class cast
    {
        public static void caststring()
        {
            //float num1 = 3.14159f;
            //int retvalue = 0;

            //Console.WriteLine("num1 = {0}", num1);
            //Console.WriteLine("retvalue = {0}", retvalue);

            //retvalue = (int)num1;
            //Console.WriteLine("num1 = {0}", num1);
            //Console.WriteLine("retvalue = {0}", retvalue);

            //num1 = (float)retvalue;
            //Console.WriteLine("num1 = {0:f5}", num1);

            int num = 33;
            string val1;
            val1 = "" + num;
            Console.WriteLine(val1);

            num = 77;
            val1 = num.ToString();
            Console.WriteLine(val1);

            float num2 = 3.14159f;
            val1 = string.Format("{0} {1:f2}", num, num2);
            Console.WriteLine("{0}",val1);


    
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
