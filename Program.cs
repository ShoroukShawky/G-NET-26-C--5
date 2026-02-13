using G_NET_26_C__5.Enums;

namespace G_NET_26_C__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.Write("Enter a day number (1 - 7) : ");
            int dayNumber = int.Parse(Console.ReadLine());
            DayOfWeeK day = (DayOfWeeK) dayNumber;
            Console.WriteLine($"Day: {day}");

            switch (day)
            {
                case DayOfWeeK.Saturday:
                case DayOfWeeK.Friday:
                    Console.WriteLine("it's the Weekend");
                     break;
                default:
                    Console.WriteLine("it's a Workday");
                    break;

            }
            #endregion
        }
    }
}
