using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Node
    {
        public Node next;
        public Person obj_per;
        public Node preveos;

        public Node(Person obj_per)
        {
            this.obj_per = obj_per;
        }
    }





       
}
