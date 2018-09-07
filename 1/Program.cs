using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number A: ");
                Int32 Number1 = getNumberOrExit();
                Console.Write("Enter number B: ");
                Int32 Number2 = getNumberOrExit();

                if (Number1 % 2 == 0)
                {
                    Int32 Final = Number1 * Number2;
                    Console.WriteLine("a*b={0}", Final);
                }

                else
                {
                    Int32 Final = Number1 + Number2;
                    Console.WriteLine("a+b={0}", Final);
                }
            }
        }

        private static bool shouldExit(String userInput) {
            return userInput == "q" || userInput == "quit" || userInput == "Q";
        }

        private static Int32 getNumberOrExit() {
            string userInput = Console.ReadLine();
            if (shouldExit(userInput)) { Environment.Exit(0); }

            try { return Convert.ToInt32(userInput); }
            catch
            {
                Console.WriteLine("Invalid input, please try again or 'q' to exit");
                return getNumberOrExit();
            }
        }
    }
}
