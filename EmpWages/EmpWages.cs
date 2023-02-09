using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWages
{
    public class EmpWages
    {
        const int Is_FullTime = 1;
        const int Is_PartTime = 2;
        const int Emp_Rate_Per_hour = 20;
        public static void Employee()
        {
            int empHr = 0;
            int empwage = 0;
            Random random = new Random(); 
            int empCheck = random.Next(3);
            switch(empCheck)
            {
                case Is_FullTime:
                   Console.WriteLine("Employee is Full time");
                   empHr = 8;
                   break;
                case Is_PartTime:
                    Console.WriteLine("Employee is Part Time");
                    empHr = 4;
                    break;
                default:
                    Console.WriteLine("Employee is absent");
                    break;
            }
            empwage = empHr * Emp_Rate_Per_hour;
            Console.WriteLine("Daily wages will be :" + empwage);
        }
    }
}
