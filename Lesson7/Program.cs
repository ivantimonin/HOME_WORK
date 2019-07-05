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
            obj_array.Add_element(10);
            obj_array.Add_element(11);
            obj_array.Add_element(15);
            obj_array.Add_element(15);
            obj_array.Add_element(10);

            obj_array.Insert_element(0, 555);
            obj_array.Insert_element(1, 44);//index, element

            obj_array.Remove_element(15);

            obj_array.Display_array();
            Console.ReadLine();       
        }
    }
}
