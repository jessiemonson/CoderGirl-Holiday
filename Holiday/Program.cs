using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the date you will be leaving:");
            DateTime leaveDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("How many days will you be gone?");
            int daysGone = int.Parse( Console.ReadLine());

            //string returnWeekDay = ReturnDay.WriteLine(weekday);

            Console.ReadLine();
        }
        //TimeSpan elapsed = now.Subtract(leaveDate);
        // double days = elapsed.TotalDays;
        //Console.WriteLine("{0} was {1} days ago." , leaveDate, daysGone.ToString("0"));
        
        public static string DayReturning(int daysGone, DateTime leaveDate)
        {
   
           
            DateTime returnDate = leaveDate.AddDays(daysGone);

            //DateTime weekdayReturn;

            return returnDate.DayOfWeek.ToString();
        }
            
            
        




    }
}



           


              
                
