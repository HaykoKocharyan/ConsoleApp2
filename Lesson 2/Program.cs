using System.Net.Http.Headers;
using System.Text;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 8;
            //Console.WriteLine(x);
            //x++;//x=x+1
            //Console.WriteLine(x);
            //++x;
            //Console.WriteLine(x);

            //int a = 64;
            //int b = 2048;

            //if (a > b)
            //{
            //    a = a + b;
            //}
            //else
            //{
            //    b = b - a;
            //}
            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //int t = a > b ? a = a + b:b = b - a;
            //Console.WriteLine(t);

            //string s = "Barev";
            //string g = s.Replace('a', '0');
            //Console.WriteLine(g);
            //Console.WriteLine(s);

            //StringBuilder sb = null;
            //sb.Append("Barev");

            //int                  t  =  new int --> value
            //StringBuilder sb1 = new StringBuilder("Hello World", 25);

            //StringBuilder sb2 = new StringBuilder("Shat vat or", 25);
            //Console.WriteLine(sb1.Append(sb2));

            const int a = 2;const int b=3;const int c=4;const int d=5;
            //if (a > b)
            //{
            //    Console.WriteLine(a);
            //}
            //else
            //{
            //    if (a > c)
            //    { 
            //    Console.WriteLine(a);
            //    }
            //    else
            //    {
            //        if (a > d)
            //        { 
            //        Console.WriteLine(a);
            //        }
            //        else { Console.WriteLine("a saxic poqra");
            //        }
            //    }
            //}
            switch (a)
            {
                case  b:
                    Console.WriteLine(a);
                    break;
                case   c:
                    Console.WriteLine(a);
                    break;
                case  d:
                    Console.WriteLine(a);
                    break;
                default: Console.WriteLine("a poqra saxic");
                    break;
            }

            // Dynamic Type
            dynamic t1 = "fhiasfh";
            dynamic t2 = 44564;
            int oo = t1 + t2;

            string t3 = "safggfu";
            int t4 = 26464;
            //int ooo = t3 / t4;

            var uuu = 6745;
            string yull = "wfjgjhfsbj";
            //int tg = uuu / yull;



            int t = 65646464;
            short v = Convert.ToInt16(t);
         
        }
    }
}