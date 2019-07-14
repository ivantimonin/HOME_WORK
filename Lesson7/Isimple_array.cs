using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    interface Isimple_array
    {
        void Add(int elment);
        void Insert(int element, int index);
        void Remove(int element);
        int FindIndex(int element);
    }

}
