using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Example<T, U> where T : U
    {
        public void ShowInfo(T obj)
        {
            Console.WriteLine(obj.GetType().Name);
        }

    }
}
