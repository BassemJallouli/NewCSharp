using System;

namespace C_Review
{
    class Program

    {
        static void Main(string[] args)
        {
            int x = 25;
            Console.WriteLine("Hello World!"+x);

            int[] myarray = new int[5]{3,5,6,7,8};
            myarray[0]=2; // update value
            Console.WriteLine(myarray[0]);

            if (x < 30 ) {
                Console.WriteLine("X is less than thirty");

            }else if ( x == 30 ){
                Console.WriteLine("X is thirty");

            }
            else if ( x > 30 ){
                Console.WriteLine("X is bigger than thirty");
        
            }

            int a = 3;
            switch (a) 
            {
                case 1:
                    Console.WriteLine("Value is 1!");
                    break;
                case 2:
                    Console.WriteLine("Value is 2!");
                    break;
                case 3:
                    Console.WriteLine("Value is 3!");
                    break;
                default:
                    Console.WriteLine("Oh, it's a nother value!");
                break;
            }
            // Let's call a method.
            MyMethod();
        }
        static void MyMethod()
        {
            Console.WriteLine("Test!");
        }


    }
}
