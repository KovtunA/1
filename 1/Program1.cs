using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string user_types = (" ");
            do
            {
                Int32 Number1;
                Int32 Number2;
                Int32 Final = 0;

                Console.Write("Enter number A");
                Number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number B");
                Number2 = Convert.ToInt32(Console.ReadLine());

                {
                    if (Number1 % 2 == 0)
                    {
                        Final = Number1 * Number2;
                        Console.WriteLine("a*b={0}", Final);
                    }

                    else
                    {
                        Final = Number1 + Number2;
                        Console.WriteLine("a+b={0}", Final);

                    }

                }
            }
            while (user_types != "q");
        }
    }
}
