using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustForFun.Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var data = (from i in new int[10] select rnd.Next(20)).ToArray();

            data.ToList().ForEach(di => Console.Write(di + ", "));
            Console.WriteLine();

            ISort<int> sort = new MonkeySort<int>((x, y) => x <= y);
            sort.Sort(data);

            data.ToList().ForEach(di => Console.Write(di + ", "));

            Console.ReadKey();
        }
    }
}
