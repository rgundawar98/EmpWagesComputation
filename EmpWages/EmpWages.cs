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
            int Is_Present = 1;
            int Emp_Rate_Per_hour = 20;
            int empHr = 0;
            int empwage = 0;
            Random random = new Random(); 
            int empCheck = random.Next(2);
            if(empCheck == Is_Present)
            {
                Console.WriteLine("Employee is present");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHr = 0;
            }
            empwage = empHr * Emp_Rate_Per_hour;
            Console.WriteLine("Daily wages will be :" + empwage);
        }
    }
}
