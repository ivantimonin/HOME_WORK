using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    interface ArrayPossibility
    {
        void Add(int elment);
        void Insert(int element, int index);
        void Remove(int element);
        void Display();
        int FindIndex(int element);
    }

}
