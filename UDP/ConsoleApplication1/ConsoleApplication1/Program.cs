using System;
using System.Threading;


namespace RectangleApplication
{
    public delegate string GetStrDelegate();
    public class Program
    {
        public static void Main(string[] args)
        {
            GetStrDelegate del = Func1;
            del += Func2;
            del += Func3;
            Delegate[] delList = del.GetInvocationList();
            foreach(GetStrDelegate item in delList)
            {
                string result = item();
                Console.WriteLine(result);
            }
            //string result = del();
            //Console.WriteLine(result);
            Console.ReadLine();
            //控制台输出结果：
            //You called me from Func3
        }
        public static string Func1()
        {
            return "You called me from Func1!";
        }
        public static string Func2()
        {
            return "You called me from Func2!";
        }
        public static string Func3()
        {
            return "You called me from Func3!";
        }
    }


   
 }
