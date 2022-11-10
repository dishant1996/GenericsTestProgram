using System;

namespace UC1_MaximumOfThree
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Find the Maximum number");
            int output = MaximumNumber.MaximumIntNum(10, 20, 5);
            Console.WriteLine(output);
            double output1 = MaximumNumber.MaximumIntNum(20.5, 45.2, 5.5);
            Console.WriteLine(output1);
            string output2 = MaximumNumber.MaximumIntNum("abc", "xyz", "pqr");
            Console.WriteLine(output2);

        }
    }
}


