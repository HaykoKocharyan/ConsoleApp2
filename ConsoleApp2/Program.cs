namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte t1 = 255;
            byte t2 = 255;
            Console.WriteLine(t1 + t2);
            Console.WriteLine(t1 - t2);
            Console.WriteLine(t1 * t2);
            Console.WriteLine(t1 / t2);
            Console.WriteLine(t1 % t2);
            Console.WriteLine("-------------");

            sbyte sb1 = 125;
            sbyte sb2 = 125;
            Console.WriteLine(sb1 + sb2);
            Console.WriteLine(sb1 - sb2);
            Console.WriteLine(sb1 * sb2);
            Console.WriteLine(sb1 / sb2);
            Console.WriteLine(sb1 % sb2);
            Console.WriteLine("-------------");

            short s1 = 788;
            short s2 = 655;
            Console.WriteLine(s1 + s2);
            Console.WriteLine(s1 - s2);
            Console.WriteLine(s1 * s2);
            Console.WriteLine(s1 / s2);
            Console.WriteLine(s1 % s2);
            Console.WriteLine("-------------");

            ushort u1 = 8689;
            ushort u2 = 5412;
            Console.WriteLine(u1 + u2);
            Console.WriteLine(u1 - u2);
            Console.WriteLine(u1 * u2);
            Console.WriteLine(u1 / u2);
            Console.WriteLine(u1 % u2);
            Console.WriteLine("-------------");

            long l1 = 46465;
            long l2 = 6465682;
            Console.WriteLine(l1 + l2);
            Console.WriteLine(l1 - l2);
            Console.WriteLine(l1 * l2);
            Console.WriteLine(l1 / l2);
            Console.WriteLine(l1 % l2);
            Console.WriteLine("-------------");

            ulong ul1 = 564987;
            ulong ul2 = 564516;
            Console.WriteLine(ul1 + ul2);
            Console.WriteLine(ul1 - ul2);
            Console.WriteLine(ul1 * ul2);
            Console.WriteLine(ul1 / ul2);
            Console.WriteLine(ul1 % ul2);
            Console.WriteLine("-------------");

            int y1 = 80000045;
            int y2 = 80000045;
            Console.WriteLine(y1 + y2);
            Console.WriteLine(y1 - y2);
            Console.WriteLine(y1 * y2);
            Console.WriteLine(y1 / y2);
            Console.WriteLine(y1 % y2);
            Console.WriteLine("-------------");

            uint j1 = 58942;
            uint j2 = 23654;
            Console.WriteLine(j1 + j2);
            Console.WriteLine(j1 - j2);
            Console.WriteLine(j1 * j2);
            Console.WriteLine(j1 / j2);
            Console.WriteLine(j1 % j2);
            Console.WriteLine("-------------");

            float f1 = 64465f;
            float f2 = 654565f;
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);
            Console.WriteLine(f1 % f2);
            Console.WriteLine("-------------");

            double d1 = 95825;
            double d2 = 89898;
            Console.WriteLine(d1 + d2);
            Console.WriteLine(d1 - d2);
            Console.WriteLine(d1 * d2);
            Console.WriteLine(d1 / d2);
            Console.WriteLine(d1 % d2);
            Console.WriteLine("-------------");

            decimal k1 = 565646m;
            decimal k2 = 2664565m;
            Console.WriteLine(k1 + k2);
            Console.WriteLine(k1 - k2);
            Console.WriteLine(k1 * k2);
            Console.WriteLine(k1 / k2);
            Console.WriteLine(k1 % k2);
            Console.WriteLine("-------------");

            string str1 = "safhfrsfbhkfsn";
            string str2 = "jwfahuifbifbjhiw";
            Console.WriteLine(str1 + str2);
            Console.WriteLine("-------------");

            char c = 'a';
            char d = 'g';
            Console.WriteLine(c + d);
            Console.WriteLine("-------------");

            Console.Write("X= ");
            int z = Console.Read();
            Console.ReadLine();
            Console.Write("Y= ");
            int i = Console.Read();

            if (z > i)
            {
                Console.WriteLine("X > Y");
            }
            else if (z < i)
            {
                Console.WriteLine("X < Y");
            }
            else Console.WriteLine("X = Y");
        }
    }
}