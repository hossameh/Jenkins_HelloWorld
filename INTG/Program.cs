using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTG
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 100000;
            string two = "Codility";
            string three = "Test";
            string five = "Coders";
            string rslt = string.Empty;
            for (int i = 1; i <= 24; i++)
            {
                rslt += (i % 2 == 0 && i%3==0)? two+three:
                        (i % 2 == 0 && i % 3 == 0 && i%5==0?two+three+five:
                        (i%2 ==0 && i% 5==0) ? two+five:
                        (i%3==0 && i%5==0)?three+five:
                        (i % 2 == 0) ? two : 
                        (i % 3 == 0) ? three : 
                        (i % 5 == 0) ? five : 
                        i.ToString());
                Console.WriteLine(rslt);
                rslt = string.Empty;
            }
            //string checkDivisble(int Num,int divBy)
            //{
            //    string retVal = string.Empty;
            //    if (divBy == 2)
            //        retVal = (Num % 2 == 0) ? two : divBy.ToString();
            //    else
            //        (divBy == 2)
            //        retVal = (i % 2 == 0) ? two : divBy.ToString();

            //    return retVal;
            //}

        }
    }
}
