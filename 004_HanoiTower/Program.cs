using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_HanoiTower
{
    class Program
    {
        static void Main(string[] args)
        {
            Hanoi(5, 'A', 'C', 'B');
        }

        private static void Hanoi(int n, char from, char to, char by)
        {
            if (n == 1)
                Console.WriteLine("Move : {0} -> {1}", from, to);

            else
            {
                Hanoi(n - 1, from, by, to);
                Console.WriteLine("Move : {0} -> {1}", from, to);
                Hanoi(n - 1, by, to, from);
            }
        }
    }
}
