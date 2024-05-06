using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceOOP3
{
    class Time
    {
        private int hours;
        public int Hours
        {
            get { return hours; }
            set { if (value < 0) hours = 0;
                  else hours = value; }
        }
        private int minutes;
        public int Minutes 
        { 
            get { return minutes; }
            set { if (value < 0) minutes = 0; 
                  else minutes = value; }
        }
        private int seconds;
        public int Seconds 
        { 
            get { return seconds; }
            set { if (value < 0) seconds = 1; 
                  else seconds = value; }
        }
        public int AllMinutes => minutes + (hours * 60) + (seconds / 60);

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
            return $"Всего минут = {AllMinutes}";
        }

        public string MinusTenMinutes()
        {
            return AllMinutes > 10 ? $"Меньше на 10 минут = {AllMinutes - 10}" : "Невозможно отнять 10 минут";
        }

        ~Time()
        {
            Console.WriteLine("Информация о времени была удалена.");
        }

    }
}
