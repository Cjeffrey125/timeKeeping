using System;

namespace C_
{
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("\t Employee Time Keeping System");

            Console.WriteLine(" ");

            Console.WriteLine( $"\t TODAY's DATE is {DateTime.Today.ToShortDateString()}");
            
            Console.WriteLine(" ");
            
                Console.Write("Enter Your ID Number : ");
                string Id = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine($"\t  Goodmorning Employee {Id}!");

            Console.WriteLine(" ");

            TimeSpan timeIn = new TimeSpan (8, 29, 0);
            Console.WriteLine($"Your Login Time is Recorded at {timeIn}.");

            Console.WriteLine(" "); 
            
            Console.WriteLine("\t     End of Shift");

            Console.WriteLine(" ");
   
                Console.Write("Enter Your ID Number : ");
                Id = Console.ReadLine();

            Console.WriteLine(" ");

          
            TimeSpan timeOut = new TimeSpan (17, 0, 0);
            Console.WriteLine($"Your Logout Time is Recorded at {timeOut}.");

            TimeSpan lunchTime = new TimeSpan(1,0,0);
            TimeSpan ttlhrs =  (timeOut - timeIn) - lunchTime;

            TimeSpan hoursStart = new TimeSpan(8,0,0);
            TimeSpan hoursEnd = new TimeSpan (19,0,0);

        TimeSpan lateIn = new TimeSpan (0,0,0), 
        earlyOut = new TimeSpan (0,0,0), 
        tLate = new TimeSpan (0,0,0),
        ovTime = new TimeSpan (0,0,0);

        if (timeIn > hoursStart) {
            lateIn = timeIn - hoursStart;
        }         

        if (timeOut < hoursEnd) {
            earlyOut = timeOut - hoursEnd;
        }
        
        TimeSpan regHours = ttlhrs -(lateIn + earlyOut);

        Console.WriteLine($"Your Total Regular Hours Worked is : {ttlhrs}");

        TimeSpan gperiod = new TimeSpan (0, 30, 0);
        TimeSpan mLate = new TimeSpan(8, 30, 0);
        if (timeIn > mLate) {
            tLate =  timeIn - mLate + gperiod;
        }

        Console.WriteLine($"The Amount of Time you are Late is {tLate}");

        TimeSpan oTime = new TimeSpan(18,0,0);
        if (timeOut > oTime){
            ovTime = timeOut - oTime;
        }
        Console.WriteLine($"The Amount of Overtime is {ovTime}");

        Console.WriteLine(" ");

        Console.WriteLine($"\t    Have a great day!!");


        }
    }
}
