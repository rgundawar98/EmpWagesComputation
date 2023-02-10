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
        const int Number_Of_Working_Days = 20;
        public static void Employee()
        {
            int empHr = 0;
            int empwage = 0;
            int TotalEmpWage = 0;

            for (int day = 0; day < Number_Of_Working_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
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
                TotalEmpWage+= empwage;
                Console.WriteLine("Emp wage:"+empwage);
            }
               Console.WriteLine("Total employee wage will be :" +TotalEmpWage);
        }
    }
}
