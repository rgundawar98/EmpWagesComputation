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
            Random random = new Random(); 
            int empCheck = random.Next(2);
            if(empCheck == Is_Present)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
