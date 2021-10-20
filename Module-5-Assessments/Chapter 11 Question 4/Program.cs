using System;

namespace Chapter_11_Question_4
{
    class systemtest
    {
        private static void Main(string[] args)
        {
            long days = 0;
            long hours = 0;
            long mins = 0;

            long computerTimeCount = Environment.TickCount;
            long secs = computerTimeCount / 1000;
            mins = secs / 60;
            hours = mins / 60;
            days = hours / 24;
                     
            Console.WriteLine("{0:d2}:{1:d2}:{2:d2}", days, hours % 24, mins % 60);
           
            



        }
    }
}