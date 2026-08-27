using System;

namespace test01
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

        }
    }
}
