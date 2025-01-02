using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Salaries
    {
        // ArrayList _salaryList = new ArrayList();
        List<float> _salaryList = new List<float>();

        public Salaries()
        {
            _salaryList.Add(69000.12f);
            _salaryList.Add(42000.43f);
            _salaryList.Add(40000.44f);
        }
        public List<float> GetSalaries () => _salaryList;
    }

}
