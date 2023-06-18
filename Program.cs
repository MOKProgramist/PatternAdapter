using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExistingInterface existingInterface = new
            ExistingImplementation();
            ITarget adapter = new Adapter(existingInterface);

            // Вызов метода CalculateAverage через класс-адаптер
            int average = adapter.CalculateAverage();
            Console.WriteLine($"Среднее значение = {average}");

            // Вызов метода CalculateSum через класс-адаптер
            int sum = adapter.CalculateSum();
            Console.WriteLine($"Сумма = {sum}");

            Console.ReadLine();
        }
    }
}
