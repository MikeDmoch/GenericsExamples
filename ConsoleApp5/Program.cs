using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Salaries salaries = new Salaries();
            //ArrayList salaryList = salaries.GetSalaries();
            List<float> salaryList = salaries.GetSalaries();
            float salary = salaryList[1];
            salary = salary * 1.02f;
            Console.WriteLine(salary);
            Console.ReadKey();
        }
    }
}
