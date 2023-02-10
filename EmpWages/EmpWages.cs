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
        const int Number_Of_Working_Days = 4; //UC6
        const int Max_Hrs_In_Month = 10;
        public static void Employee()
        {
            int empHr = 0;
            //int empwage = 0;
            int TotalEmpHrs = 0;
            int Total_Working_Days = 0;

            while(TotalEmpHrs<=Max_Hrs_In_Month && Total_Working_Days<Number_Of_Working_Days)
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
              TotalEmpHrs+= empHr;
                Console.WriteLine("Day:"+Total_Working_Days+"EmpHrs:"+empHr);
           }
            int TotalEmpWage = TotalEmpHrs * Emp_Rate_Per_hour;
            Console.WriteLine("Total employee wage will be :" +TotalEmpWage);
        }
    }
}
