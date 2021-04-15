using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class Program
    { 
        static void Main(string[] args)
        {
                //Constraits
                int Present = 1;
                int EmpRatePerHours = 20;
                //Local Variables
                int empHrs = 0;
                int empwage = 0;

                //inbuilt class
                Random randomvalue = new Random();
                int employeCheck = randomvalue.Next(0, 2);
                Console.WriteLine("random value:-" + employeCheck);
                if (employeCheck == Present)
                {
                    empHrs = 8;

                }
                else
                {
                    empHrs = 0;
                }
                empwage = EmpRatePerHours * empHrs;
                Console.WriteLine("Empolyee wage perhours:" + empHrs);
                Console.Read();
            }
        }
    }