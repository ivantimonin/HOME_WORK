using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Array objArray = new Array(10);

            objArray.Add(5);
            objArray.Add(10);
            objArray.Add(19);
            objArray.Add(15);
            objArray.Add(19);

            objArray.Insert(2, 3);//элемент, индекс

            objArray.Remove(19);

            objArray.Display();
            Console.ReadLine();

        }
    }
}
