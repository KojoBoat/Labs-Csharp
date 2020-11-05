using System;
using System.Collections.Generic;
using System.Text;

namespace Turntabl
{
    class tryDelegate
    {
        public delegate void Changer(ref int val);
        public delegate void Creator(out object val);
        public delegate void Action<T>(T msg);

        public partial class Utils
        {
            public static void BigIncrement(ref int val)
            {
                val += 100;
                Console.WriteLine(val);
            }

            public static void PopulateData(out object s)
            {
                s = Environment.StackTrace;
                Console.WriteLine(s);
            }
        }

        class Printer
        {
            private string message;

            public Printer(string msg)
            {
                message = msg;
            }

            public void Print()
            {
                Console.Write(message);
            }
        }

        static void Main(string[] args)
        {
            Changer ch = Utils.BigIncrement;
            Creator cr = Utils.PopulateData;
            //Action<string> act = new Printer("Hello World");
            int i = 100;
            object o;

            ch(ref i);
            Console.WriteLine();
            cr(out o);
        }
    }
}
