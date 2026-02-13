using G_NET_26_C__5.Enums;

namespace G_NET_26_C__5
{
    internal class Program
    {
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
            double[,] gradsArray = new double[3, 4];
            double classSum = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"enter grades for student {i+1}: ");
                double stuSum = 0;
                  for (int j = 0; j < 4; j++)
                {
                    bool valid = double.TryParse(Console.ReadLine(), out gradsArray[i, j]);
                    if (!valid)
                    {
                        Console.WriteLine("invalid grade");
                        return;
                    }

                    
                    stuSum += gradsArray[i, j];
                }
                double stuAvg = stuSum / 4;
                Console.WriteLine($"student {i+1} average grades = {stuAvg}");
                classSum += stuSum;
            }
            double classAvg = classSum / 12;
            Console.WriteLine($"class average grades = {classAvg}");
            #endregion
        }
    }
}
