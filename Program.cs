using G_NET_26_C__5.Enums;

namespace G_NET_26_C__5
{
    internal class Program
    {

        static double Add(double a, double b)
        { return a + b; }

        static double Subtract(double a, double b)
        { return a - b; }

        static double Multiply(double a, double b)
        { return a * b; }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("cannot divide by zero !!");
                return 0;
            }
            return a / b;
        }

        
        static void CalculateCircle (double redius , out double area , out double circumference)
        {
            area = Math.PI * redius * redius;
            circumference = 2 * Math.PI * redius;
        }

        static Grade GetGrade(int score)
        {
            if (score >= 90)
                return Grade.A;
            if (score >= 80)
                return Grade.B;
            if (score >= 70)
                return Grade.C;
            if (score >= 60)
                return Grade.D;
            else 
                return Grade.F;
        }

        static double CalculateAverage(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        static void GetMinMax (int[] array , out int max , out int min)
        {
            max = int.MinValue;
            min = int.MaxValue ;
            for (int i = 0; i < array.Length; i++)
            { 
                if(array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
        }
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a day number (1 - 7) : ");
            //int dayNumber = int.Parse(Console.ReadLine());
            //DayOfWeeK day = (DayOfWeeK) dayNumber;
            //Console.WriteLine($"Day: {day}");

            //switch (day)
            //{
            //    case DayOfWeeK.Saturday:
            //    case DayOfWeeK.Friday:
            //        Console.WriteLine("it's the Weekend");
            //         break;
            //    default:
            //        Console.WriteLine("it's a Workday");
            //        break;

            //}
            #endregion
            #region Q2
            // Console.Write("Enter array size: ");
            //bool sizeValid =  int.TryParse(Console.ReadLine() , out int sizeOfArray );
            // if (!sizeValid || sizeOfArray <= 0)
            // {
            //     Console.WriteLine("invalid size!!");
            //     return;
            // }
            // int[] array = new int[sizeOfArray];

            // int sum = 0 , max = int.MinValue , min = int.MaxValue ;
            // for (int i = 0; i < sizeOfArray; i++)
            // {
            //     Console.Write($"Enter element[{i}]:");
            //     bool valid = int.TryParse(Console.ReadLine(), out array[i]);

            //     if(!valid )
            //     {
            //         Console.WriteLine("invaild element!!");
            //         return;
            //     }
            //      sum+= array[i];
            //     if (array[i] < min)
            //         min = array[i];
            //     if(array[i] > max)
            //         max = array[i];
            // }
            // double avg = (double)sum / sizeOfArray;
            // Console.WriteLine();
            // Console.WriteLine($"Sum = {sum}");
            // Console.WriteLine($"Average = {avg}");
            // Console.WriteLine($"Max = {max}");
            // Console.WriteLine($"Min = {min}");
            // Console.Write("Reverse = ");
            // for (int i = sizeOfArray - 1; i >= 0; i--)
            // {
            //     Console.Write(array[i]);
            //     if (i!= 0)
            //         Console.Write(", ");
            // }
            #endregion
            #region Q3
            //double[,] gradsArray = new double[3, 4];
            //double classSum = 0;

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"enter grades for student {i+1}: ");
            //    double stuSum = 0;
            //      for (int j = 0; j < 4; j++)
            //    {
            //        bool valid = double.TryParse(Console.ReadLine(), out gradsArray[i, j]);
            //        if (!valid)
            //        {
            //            Console.WriteLine("invalid grade");
            //            return;
            //        }


            //        stuSum += gradsArray[i, j];
            //    }
            //    double stuAvg = stuSum / 4;
            //    Console.WriteLine($"student {i+1} average grades = {stuAvg}");
            //    classSum += stuSum;
            //}
            //double classAvg = classSum / 12;
            //Console.WriteLine($"class average grades = {classAvg}");
            #endregion
            #region Q4
            // Console.WriteLine("enter two numbers:");
            //bool v1 = double.TryParse(Console.ReadLine(), out double a);
            //bool v2 = double.TryParse(Console.ReadLine(), out double b);
            // if(!v1 || !v2)
            // {
            //     Console.WriteLine("invalid number");
            //     return;
            // }

            // Console.WriteLine("enter opration (+ , - , * , /)");
            // char opration = Console.ReadLine()[0];
            // switch (opration)
            // {
            //     case '+':
            //         Console.WriteLine($"result = {Add(a, b)}");
            //         break;

            //     case '-':
            //         Console.WriteLine($"result = {Subtract(a, b)}");
            //         break;

            //     case '*':
            //         Console.WriteLine($"result = {Multiply(a, b)}");
            //         break;

            //     case '/':
            //         Console.WriteLine($"result = {Divide(a, b)}");
            //         break;

            //   default:
            //         Console.WriteLine("invaild opration!!");
            //         break;
            // }

            #endregion
            #region Q5
            //Console.Write("enter the redius : ");
            //bool valid = double.TryParse(Console.ReadLine(), out double redius);

            //if(!valid || redius < 0)
            //{
            //    Console.WriteLine("invalid redius!!");
            //    return;
            //}
            //double area, circumference;
            //CalculateCircle(redius, out area, out circumference);
            //Console.WriteLine($"the area = {area:F2}\nthe circumference = {circumference:F2}");

            #endregion
            #region Q6
            int[] array = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter score for student {i +1}: ");
                bool vaild = int.TryParse(Console.ReadLine(), out array[i]);
                if(!vaild || array[i] < 0)
                {
                    Console.WriteLine("invalid score!!");
                    return;
                }
            }
            Console.WriteLine("\n--- Report ---");

            for (int i = 0; i < 5; i++)
            {
                Grade g = GetGrade(array[i]);

                Console.WriteLine($"Student {i +1}: {array[i]} -> Grade: {g}");
            }
            GetMinMax(array , out int max ,out int min);
            Console.WriteLine($"\nAverage: {CalculateAverage(array)}");
            Console.WriteLine($"Highest Score: {max}");
            Console.WriteLine($"Lowest Score: {min}");

            #endregion
        }
    }
}
