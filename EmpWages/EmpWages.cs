using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWages
{
    public class EmpWages
    {
        public static void Employee()
        {
            int Is_FullTime = 1;
            int Is_PartTime = 2;
            int Emp_Rate_Per_hour = 20;
            int empHr = 0;
            int empwage = 0;
            Random random = new Random(); 
            int empCheck = random.Next(3);
            if(empCheck == Is_FullTime)
            {
                Console.WriteLine("Employee is Full time");
                empHr = 8;
            }
            else if(empCheck == Is_PartTime)
            {
                Console.WriteLine("Employee is Part Time");
                empHr = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            empwage = empHr * Emp_Rate_Per_hour;
            Console.WriteLine("Daily wages will be :" + empwage);
        }
    }
}
