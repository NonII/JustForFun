using System;

namespace JustForFun.Sorting
{
    public abstract class AbstractSort<T>
    {
        public AbstractSort(Func<T, T, bool> judge)
        {
            Judge = judge;
        }

        public Func<T, T, bool> Judge { get; set; }

        public bool IsDataSorted(T[] data)
        {
            if (data == null) {
                throw new ArgumentNullException();
            }
            if (data.Length <= 1) {
                return true;
            }

            for (var i = 1; i < data.Length; i++) {
                if (Judge(data[i - 1], data[i]) == false) {
                    return false;
                }
            }
            return true;
        }

        public abstract void Sort(T[] data);
    }
}
