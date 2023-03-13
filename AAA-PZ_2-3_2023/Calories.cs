using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAA_PZ_2_3_2023
{
    internal class Calories
    {
        private int first = 7;
        private double second = 5;
        public double Power()
        {
            return (first * 10) * second;
        }
        public void Read()
        {
            Console.WriteLine("Каллорийность на 100г = ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Масса в кг = ");
            second = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.Clear();
            Console.WriteLine($"Каллорийность на 100г = {first}\nМасса в кг = {second}\nОбщая каллорийность = {Power()}");
        }
    }
}
