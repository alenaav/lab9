namespace lab9_2;

class Program
{

    public static DialClock MaxElement(DialClockArray array)
    {
        DialClock max = new DialClock(0, 0);
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].CalculateAngle() > max.CalculateAngle())
                max = new DialClock(array[i].Hours, array[i].Minutes);
        }
        return max;
    }

    static void Main(string[] args)
    {
        DialClock clock1 = new DialClock(13, 41); //создание объекта через конструктор c параметрами
        DialClock clock2 = new DialClock(2, 15) ; //создание объекта через конструктор с параметрами
        DialClock clock3 = new DialClock(); //создание через конструктор без параметров
        DialClock clock4 = new DialClock(clock2); //создание через конструктор копирования

        clock1.Show(); //вывод атрибутов объекта на печать
        clock2.Show();
        clock3.Show();
        clock4.Show();

        double angle1 = clock1.CalculateAngle();
        double angle2 = DialClock.CalculateAngleStatic(13, 41);

        Console.WriteLine($"Угол между часовой и минутной стрелками для объекта clock1: {angle1}");
        Console.WriteLine($"Угол между часовой и минутной стрелками для объекта clock1 (статическая): {angle2}");


        Console.WriteLine($"Всего создано объектов: {DialClock.counter}");

        Console.WriteLine("Вывод объектов после унарных операций: ");
        clock1++;
        clock1--;
        clock1.Show();

        Console.WriteLine($"Явная операция приведения типа bool для clock1: {(bool)clock1}");
        Console.WriteLine($"Неявная операция приведения типа int для clock1: {(int)clock1}");

        //бинарные операции
        DialClock clock5 = clock1 + clock2;
        DialClock clock6 = clock1 - clock2;
        Console.WriteLine("Вывод объектов после бинарных операций: ");
        clock5.Show();
        clock6.Show();

        DialClock equals1 = clock5;
        DialClock equals2 = clock6;
        Console.WriteLine($"clock5 Equals clock6: {clock5.Equals(clock6)}");


        Console.WriteLine("3 часть");

        //создание массива разными способами
        Console.WriteLine("Выберите способ создания массива студентов: 1 - ручной ввод, 2 - рандомный");

        bool isConvert;
        int answer;
        do
        {
            string buf = Console.ReadLine();
            isConvert = int.TryParse(buf, out answer);
            if (!isConvert || answer < 1 || answer > 2)
            {
                Console.WriteLine("Неправильно введено число. Введите значение 1 или 2");
            }
        } while (!isConvert || answer < 1 || answer > 2);

        Console.WriteLine("Сколько циферблатов?");
        int count;
        do
        {
            string buf = Console.ReadLine();
            isConvert = int.TryParse(buf, out count);
            if (!isConvert || count < 1 || count > 100)
            {
                Console.WriteLine("Неправильно введено число. Введите значение от 1 до 100");
            }
        } while (!isConvert || count < 1 || count > 100);
        DialClockArray dialClockArray = new DialClockArray();

        switch (answer)
        {
            case 1:
                {
                    int[] hours = new int[count];
                    int[] minutes = new int[count];
                    dialClockArray = new DialClockArray(count, hours, minutes);
                    dialClockArray.ShowArray();
                    break;
                }
            case 2:
                {
                    dialClockArray = new DialClockArray(count);
                    dialClockArray.ShowArray();
                    break;
                }
        }

        DialClockArray dialClockArray2 = new DialClockArray(dialClockArray);
        Console.WriteLine("Копия коллекции: ");
        dialClockArray2.ShowArray();

        dialClockArray2[0] = new DialClock(10, 53); //демонстрация set для правильного индекса
        Console.WriteLine("Копия коллекции после изменения первого элемента: ");
        dialClockArray2.ShowArray(); //вывод копии коллекции после изменений
        Console.WriteLine($"Вывод первого элемента копии коллекции: {dialClockArray2[0].Hours}, {dialClockArray2[0].Minutes}"); //демонстрация get для правильного индекса

        //проверка на индекс, выходящий за пределы
        try
        {
            dialClockArray[110] = new DialClock(11, 40); //демонстрация set для неправильного индекса
            Console.WriteLine(dialClockArray[110]); //демонстрация get для неправильного индекса
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //вывод максимального угла из массива
        DialClock maxClock = MaxElement(dialClockArray);
        double maxAngle = maxClock.CalculateAngle();
        Console.WriteLine($"Максимальный угол между стрелками из коллекции = {maxAngle}");
    }
}

