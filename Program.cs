using System;

namespace DZ2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string error = "";
            Console.Write("Enter Number :");
            string strNumber = Console.ReadLine();
            bool numberCheck = Int32.TryParse(strNumber,out int number);
            if (!numberCheck) 
            {
                error += "Some problems with number ;";
            }
            int i = 0;
            if (numberCheck)
            {
                int min = (int)Char.GetNumericValue(strNumber[0]);
                int max = (int)Char.GetNumericValue(strNumber[0]);

                for (int j = 0; j < strNumber.Length; j++)
                {
                    Console.WriteLine(++i + " цифра числа :" + strNumber[j]);
                    int num = (int)Char.GetNumericValue(strNumber[j]);
                    min = Math.Min( min, num );
                    max = Math.Max( max, num );
                }
                Console.WriteLine("Min number :" + min + "\nMax number :"+ max);
            }
            if (error.Length > 0) 
            {
                Console.WriteLine(error);
            }
            Console.ReadKey();
        }
    }
}
