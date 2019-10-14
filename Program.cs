using System;

namespace Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate_Prime(100);
       }

        static void Calculate_Prime(int n)
        {
            int i;
            bool ifPrime = false;


            for (i=2 ; i<=n; i++)
            {
                //Console.WriteLine(i);

                for (int j = 2; j<i; j++)
                {
                    if (i%j == 0)
                    {
                        ifPrime = false;
                        break;
                    }
                    else
                    {
                        ifPrime = true;
                    }
                }

                if(ifPrime == true)
                {
                    
                    Console.WriteLine(i);
                }
            }

        }


    }
}
