using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {
        static  void Main(string[] args)
        {
            //add();
            //mul();
            //sub();
            //power();
            //volume();
            //perim();
            swap();
        }
        public static void sub1()
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int b = int.Parse(Console.ReadLine());
            int sub1 = a - b;
            Console.WriteLine(sub1);
        }
        public static void sub()
        {

            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int b = int.Parse(Console.ReadLine());
            int sub = a - b;
            Console.WriteLine(sub);
        }
        public static void mul()
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int b = int.Parse(Console.ReadLine());
            int mul = a * b;
            Console.WriteLine(mul);
        }
        public static void power()
        {
            Console.WriteLine("enter the number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number");
            int b = int.Parse(Console.ReadLine());
            double pow = Math.Pow(a, b);
            Console.WriteLine(pow);
        }
        public static void volume()
        {
            Console.WriteLine("enter the length");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the base");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the height");
            int h = int.Parse(Console.ReadLine());
            float volume =(float) l * b * h;
            Console.WriteLine(volume);
        }
        public static void perimeter()
        {
            Console.WriteLine("enter the radius");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine(2 * Math.PI * r);
        }
        public static int c1()
        {
            Console.WriteLine("entre the value");
            int n1 = int.Parse(Console.ReadLine());
            return n1;
        }
        public static void perim()
        {
            Console.WriteLine(2 * Math.PI * c1());
        }
        public static void area()
        {
            Console.WriteLine(1.0 / 2 * c1() * c1());
        }
        public static void km()
        {
            Console.WriteLine(c1() * 1.60934);
        }
        public static void feh()
        {
            Console.WriteLine((c1() * 9.0 / 5) + 32);
        }
       public static void ran()
       {
           Random r=new Random();
           int ran=r.Next(c1(),c1());
           Console.WriteLine(ran);
       }
       public static void swap()
       {
           int a = c1();
           int b = c1();
           int temp = 0;
           temp = a;
           a = b;
           b = temp;
           Console.WriteLine(a+"\n"+b);
       }


    }
}
