using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree_obj = new Tree();
            tree_obj.Add_node(32);
            tree_obj.Add_node(2);
            tree_obj.Add_node(7);
            tree_obj.Add_node(4);
            tree_obj.Add_node(5);
            tree_obj.Add_node(9);
            tree_obj.Add_node(22);
            tree_obj.Add_node(1);
            
            Console.WriteLine("                                 До удаления");
            tree_obj.Show_tree();
            tree_obj.Del(32);
            Console.WriteLine("                                 После удаления");
            tree_obj.Show_tree();
           
            Console.Read();
        }

    }
}
