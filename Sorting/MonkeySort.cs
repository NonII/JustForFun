using System;

namespace JustForFun.Sorting
{
    public class MonkeySort<T> : AbstractSort<T>
    {
        public MonkeySort(Func<T, T, bool> judge) : base(judge) { }

        public override void Sort(T[] data)
        {
            if (data == null) {
                throw new ArgumentNullException();
            }

            var rnd = new Random();
            while (IsDataSorted(data) == false) {
                _SwitchDataItem(ref data, rnd.Next(0, data.Length), rnd.Next(0, data.Length));
            }
        }

        private void _SwitchDataItem(ref T[] data, int i, int j)
        {
            if (data == null) {
                throw new ArgumentNullException();
            }
            if (i < 0 || j < 0 || i >= data.Length || j >= data.Length) {
                throw new ArgumentException();
            }
            if (i == j) {
                return;
            }

            var tmp = data[i];
            data[i] = data[j];
            data[j] = tmp;
        }
    }
}
