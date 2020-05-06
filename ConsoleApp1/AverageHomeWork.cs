using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AverageHomeWork
    {

        public void SumAverageHomeWork(int[] arr)
        {
            
            double finalPAverage;
            double finalPMedian; 

            int size;
            Console.WriteLine("Enter the name of the Student:");
            string StudentName = Console.ReadLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            AverageHomeWork.ClearCurrentConsoleLine(1);
            Console.WriteLine("Enter the Sur Name of the Student:");
            string StudentSurName = Console.ReadLine();
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            AverageHomeWork.ClearCurrentConsoleLine(1);



            Console.WriteLine("Enter the total number of homeworks given:");
            size = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            AverageHomeWork.ClearCurrentConsoleLine(1);

            //   int[] a = new int[size];
            //Console.WriteLine("Enter the marks for the homework given: ");

            //  for (int i = 0; i < size; i++)
            // {
            //     Console.WriteLine("Enter the marks for the homework given: ");
            //      a[i] = Convert.ToInt32(Console.ReadLine());
            //      Console.SetCursorPosition(0, Console.CursorTop - 1);
            //      AverageHomeWork.ClearCurrentConsoleLine(1);
            //   
            //  }
            //  int len = a.Length;

            //to generate random homework marks in the array
            double randomsum = 0;
            double randomaverage = 0;
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = size;
                Random random = new Random();
                double randomHomeWork = random.Next(1,11);
                randomsum += randomHomeWork;


            }
            randomaverage = randomsum / size;
            int len = a.Length;


           /*
            double sum = 0;
            double average = 0;
            for (int i = 0; i < size; i++)
            {
                sum += a[i];
                

            }
            average = sum / size;  */
            //Console.WriteLine("Average of Homeworks is:" + average);
            // Console.ReadLine();

            // Console.WriteLine("Median is:" + Median(a, len));
            Double median = 0;
        
            Array.Sort(a);
            if (len % 2 != 0)
            {
                 median = a[len / 2];
            }
            else
            {
                 median = (a[(len - 1) / 2] + a[len / 2]) / 2.0;
            }



           // Console.WriteLine("Enter the exam results:");
           // double exam = Convert.ToDouble(Console.ReadLine());
           // Console.SetCursorPosition(0, Console.CursorTop - 1);
           // AverageHomeWork.ClearCurrentConsoleLine(1);

            //for a randon exam result to be generated
             Random randomm = new Random();
             double examrandom = randomm.Next(1, 11);
             Console.WriteLine("Random Number generated for the exam:"+examrandom);
             Console.SetCursorPosition(0, Console.CursorTop - 1);
            AverageHomeWork.ClearCurrentConsoleLine(1);   

            // add examrandom in place of exam 
            finalPMedian = (0.3 * median) + (0.7 * examrandom);
            finalPAverage = (0.3 * randomaverage) + (0.7 * examrandom);
            // finalPMedian = (0.3 * median) + (0.7 * exam);

            // finalPAverage = (0.3 * average) + (0.7 * exam);

            //finalPAverage = (0.3 * randomaverage) + (0.7 * exam);

            String FinalPMedian = Convert.ToString(finalPMedian);
            String FinalPAverage = Convert.ToString(finalPAverage);
            ConsoleDataFormatter.PrintRow(StudentName, StudentSurName, FinalPAverage,FinalPMedian);

           


        }

        public static void ClearCurrentConsoleLine(int lines)
        {
            for (int i = 1; i <= lines; i++)
            {

                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }

        }

        //public static double Median(int[]a,int n)
       // {
        //    Array.Sort(a);
        //    if (n % 2 != 0)
        //        return (double)a[n / 2];
        //    return (double)(a[(n - 1) / 2] + a[n / 2]) / 2.0;

       // }
    }
}
