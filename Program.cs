using System;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 25;
            Console.WriteLine("Hello World!"+x);

            if (x < 30 ) {
                Console.WriteLine("X is less than thirty");

            }else if ( x == 30 ){
                Console.WriteLine("X is thirty");

            }
            else if ( x > 30 ){
                Console.WriteLine("X is bigger than thirty");

            }
        }
    }
}
