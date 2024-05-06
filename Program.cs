using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP3
{
    class Program
    {
        static void Main()
        {
            Time time = Edit();
            GC.Collect();
            Memo(time);
            Console.ReadKey();
        }


        static Time Edit()
        {
            Console.Write("Часов = ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Минут = ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Секунд = ");
            int sedonds = int.Parse(Console.ReadLine());
            return new Time(hour, minutes, sedonds);

        }


        static void Memo(Time time)
        {
            Console.WriteLine(time.СalculateMinutes());
            Console.WriteLine(time.MinusTenMinutes());
        }
    }
}
