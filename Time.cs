using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP3
{
    class Time
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Time() { }

        public Time(int hours) => Hours = hours;

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }

        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        public string СalculateMinutes()
        {
            return $"Всего минут = {Minutes + (Hours * 60) + (Seconds / 60)}";
        }

        public string MinusTenMinutes()
        {
            return $"Меньше на 10 минут = {(Minutes + (Hours * 60) + (Seconds / 60)) - 10}";
        }

        ~Time()
        {
            Console.WriteLine("Информация о времени была удалена.");
        }

    }
}
