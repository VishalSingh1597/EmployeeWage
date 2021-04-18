using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("welcome to employee Program");
			EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
			empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
			empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
			CompanyEmpWage dmart = new CompanyEmpWage("DMart", 20, 2, 10);
			CompanyEmpWage reliance = new CompanyEmpWage("Reliance", 10, 4, 20);
			double dmartPrice = empWageBuilder.computeEmpWage(dmart);
			double reliancePrice = empWageBuilder.computeEmpWage(reliance);
			Console.Read();
		}


	}
}
