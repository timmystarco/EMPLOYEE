using System;
using System.Collections.Generic;
using System.Text;

namespace EMPLOYEE
{
    class program
    {
        public static void Main (string[] args)
        {
            Employee employee001 = new Employee("ONALAJA", "OLORUNTIMILEHIN", (decimal) 900000000);
            Console.WriteLine("\n\t FIRST EMPLOYEE INFORMATION \a");
            Console.WriteLine("Employee1 First name is {0}", employee001.FirstName);
            Console.WriteLine("Employee1 Last name is {0}", employee001.LastName);
            Console.WriteLine("Employee1 Monthly Salary is {0:C}",employee001.MonthlySalary);
            Console.WriteLine("Employee1 Yearly Salary is {0:C} ", employee001.YearlySalary() );
            

            Employee employee002 = new Employee("OLUWASOGO", "MARY", 4000000);
            Console.WriteLine("\n\t SECOND EMPLOYEE INFORMATION ");
            Console.WriteLine("Employee2 First name is {0}", employee002.FirstName);
            Console.WriteLine("Employee2 Last name is {0}", employee002.LastName);
            Console.WriteLine("Employee2 Monthly Salary is {0:C}", employee002.MonthlySalary);
            Console.WriteLine("Employee2 Yearly Salary is {0:C}", employee002.YearlySalary());

            //INCREASE EMPLOYEE SALARY BY 10%
            Console.WriteLine("\n\tINCREASED EMPLOYEE SALARY BY 10%");
            employee001.MonthlySalary *= (decimal)1.1;
            employee002.MonthlySalary *= (decimal)1.1;

            //NEW YEARLY SALARY FOR THE NEW INCREASED 10% OF EMPLOYEE SALARY
            employee001.MonthlySalary *=  12;
            employee002.MonthlySalary *=  12;
            
            //DISPLAY NEW YEARLY SALARY
            Console.WriteLine("Employee1 yearly salary after 10% increase {0:C}", employee001.MonthlySalary);
            Console.WriteLine("Employee2 yearly salary after 10% increase {0:C}", employee002.MonthlySalary);
            Console.ReadLine();
        }
    }
}
