using System;

namespace EMPLOYEE
{
    public class Employee
    {
        private string firstName;
        private string lastName;
        private decimal monthlySalary;

        //three parameter constructor 
        public Employee(string first, string last, decimal msalary)
        {
            firstName = first;
            lastName = last;

            //To check if monthly salary is positive
            if (msalary >= 0)
            {
                monthlySalary = msalary;
            }
             
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            //To check if monthly salary is not negative
            set
            {
                if (value >= 0)
                    monthlySalary = value;
                //When the monthly salary is negative set accessor should leave the instance variable unchanged.
                else
                    monthlySalary = (decimal)0.0;
            }
        }

        public decimal YearlySalary()
        {
            return MonthlySalary * 12;
        }

      

       
        public override string ToString()
        {

            return ("EMPLOYEE DETAILS FOR" + FirstName + " " + LastName + "\nMONTHLY SALARY" + MonthlySalary + " " + "Yearly Salary"
                + YearlySalary().ToString());

           
        }

    }
}
       
