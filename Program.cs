using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    {
        public const int FullTime = 1;                                        //creating a local variable
        public const int PartTime = 2;
        public const int empRatePerHour = 20;
        public const int empWorkingDaysPerMonth = 20;
        static void Main(string[] args)
        {
            //Local Variables
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();                               //Generating Random value

            while (empHrs <= 100 || empWorkingDaysPerMonth <= 20)
            {

                int employeeCheck = random.Next(0, 3);                      // assigning Random value to the variable 
                Console.WriteLine("Random Value: " + employeeCheck);

                //USING SWITCH STATEMENT
                switch (employeeCheck)
                {
                    case FullTime:
                        empHrs = 8;
                        break;

                    case PartTime:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }

                //computation
                empWage = empRatePerHour * empHrs * empWorkingDaysPerMonth;
                Console.WriteLine("Employee wage per day: " + empWage);
                Console.Read();
            }
        }
    }
}
