using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    interface Array_action
    {
        void Add_element(int element);
        int Find_element(int element);
        void Remove_element(int element);
        void Insert_element(int index, int element);
        void Display_array();
    }
}
