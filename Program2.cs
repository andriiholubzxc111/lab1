using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(13);
            numbers.Enqueue(7);
            numbers.Enqueue(5);
            numbers.Enqueue(8);
            numbers.Enqueue(28);
            numbers.Enqueue(21);
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }

            }
            int difference = max - min;
            Console.WriteLine("Максимальне:{0}", max);
            Console.WriteLine("Мінімальне:{0}", min);
            Console.WriteLine("Різниця:{0}", difference);
        }
    }
}
