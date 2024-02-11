using System;
namespace lab9_2
{
    public class DialClockArray
    {
        static Random rnd = new Random();
        DialClock[] dialClocks;

        //конструктор без параметров
        public DialClockArray()
        {
            dialClocks = new DialClock[0];
        }

        //конструктор с параметрами, заполняющий элементы случайными значениями
        public DialClockArray(int size)
        {
            dialClocks = new DialClock[size];
            for (int i = 0; i < size; i++)
            {
                dialClocks[i] = new DialClock { Hours = rnd.Next(0, 24), Minutes = rnd.Next(0, 60) };
            }
        }

        //конструктор с параметрами для заполнения с клавиатуры
        public DialClockArray(int size, int[] hours, int[] minutes)
        {
            dialClocks = new DialClock[size];
            for (int i = 0; i < dialClocks.Length; i++)
            {
                Console.Write("Введите количество часов: ");
                int dialClockHours = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите количество минут: ");
                int dialClockMinutes = Convert.ToInt32(Console.ReadLine());
                dialClocks[i] = new DialClock(dialClockHours, dialClockMinutes);
            }
        }

        public int Length
        {
            get => dialClocks.Length;
        }

        //Конструктор копирования
        public DialClockArray(DialClockArray other)
        {
            this.dialClocks = new DialClock[other.Length];
            for (int i = 0; i < other.Length; i++)
            {
                this.dialClocks[i] = new DialClock(other.dialClocks[i]);
            }
        }

        // Метод для просмотра элементов массива
        public void ShowArray()
        {
            Console.WriteLine("Элементы коллекции:");
            foreach (DialClock dialclock in dialClocks)
            {
                Console.WriteLine($"Часы: {dialclock.hours}, Минуты: {dialclock.minutes}");
            }
        }

        // Индексатор для доступа к элементам коллекции
        public DialClock this[int index]
        {
            get
            {
                if (0 <= index && index < dialClocks.Length)
                    return dialClocks[index];
                else
                    throw new Exception("Индекс выходит за пределы коллекции");
            }
            set
            {
                if (0 <= index && index < dialClocks.Length)
                    dialClocks[index] = value;
                else
                    Console.WriteLine("Индекс выходит за пределы коллекции");
            }
        }

        
        
    }
}

