using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForFun.Sorting
{
    public interface ISort<T>
    {
        Func<T, T, bool> Judge { get; set; }
        void Sort(T[] data);
        bool IsDataSorted(T[] data);
    }
}
