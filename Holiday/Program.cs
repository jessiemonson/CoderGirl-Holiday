using System;

namespace Holiday
{
    public static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the date you will be leaving:");
            DateTime leaveDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("How many days will you be gone?");
            int daysGone = Convert.ToInt32(Console.ReadLine());

            string returning = DayReturning(leaveDate, daysGone);
            Console.WriteLine($"You will return on: {returning}");
            

            Console.ReadLine();
        }
        
        public static string DayReturning( DateTime leaveDate, int daysGone)
        {
            DateTime returnDate = leaveDate.AddDays(daysGone);
            return returnDate.DayOfWeek.ToString();
            
        }

       
            
        




    }
}



           


              
                
