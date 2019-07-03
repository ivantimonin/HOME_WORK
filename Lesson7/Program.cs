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
            Array obj_array = new Array();
            obj_array.Add_element(5);
            obj_array.Add_element(10);
            obj_array.Add_element(-45);
            obj_array.Add_element(1154);
            obj_array.Display_array();

            Console.ReadLine();
       
        }
    }
}
