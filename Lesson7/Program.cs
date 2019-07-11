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

            objArray.Add_sort(5);
            objArray.Add_sort(5);
            objArray.Add_sort(0);
            objArray.Add_sort(4);
            objArray.Add_sort(9);
            objArray.Add_sort(9);
            objArray.Add_sort(8);
            objArray.Add_sort(2);
            objArray.Add_sort(1); 
            //objArray.Insert(2, 3);//элемент, индекс
            //objArray.Remove(2);
            objArray.Display();
            objArray.Find_in_sort(6);
            
            Console.ReadLine();

        }
    }
}
