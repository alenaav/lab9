using System;
using System.Xml.Linq;

namespace lab9_2
{
	public class DialClock
	{
		public int hours;
		public int minutes;
        public static int counter = 0;
		public static double angle;

		public int Hours
		{
			get => hours;
			set
			{
				if (value < 0)
					hours = 0;
				else
				if (value <= 23)
					hours = value;
				else
				if (value > 23)
					hours = value - 24;
			}
		}

        public int Minutes
        {
            get => minutes;
            set
            {
				if (value < 0)
					minutes = 0;
				else
				if (value < 60)
					minutes = value;
				else
				{
                    hours += value / 60;
                    minutes = value % 60;
                }
            }
        }

        public DialClock(int hours, int minutes) //конструктор с параметрами
		{
			Hours = hours;
			Minutes = minutes;
			counter++;
		}

		public DialClock() //конструктор без параметров
		{
			Hours = 0;
			Minutes = 0;
            counter++;
        }

		public DialClock(DialClock otherDialClock) //конструктор копирования
		{
			Hours = otherDialClock.hours;
			Minutes = otherDialClock.minutes;
            counter++;
        }

        public double CalculateAngle()
        {
            return Math.Abs(((30*Hours) + (0.5 * Minutes)) - 6 * Minutes);
        }

        public static double CalculateAngleStatic(int h, int m)
        {
            return Math.Abs(((30 * h) + (0.5 * m)) - 6 * m);
        }

        public void Show()
		{
			Console.WriteLine("Часы: " + Hours);
			Console.WriteLine("Минуты: " + Minutes);
		}

		public static DialClock operator ++(DialClock a)
		{
			a.Hours++;
			return a;
		}

		public static DialClock operator --(DialClock a)
		{
			a.Minutes--;
			return a;
		}

		public static explicit operator bool(DialClock s)
		{
			double degree = CalculateAngleStatic(s.Hours, s.Minutes);
			if (degree % 2.5 == 0)
				return true;
			else
				return false;
		}

		public static implicit operator int(DialClock s)
		{
			return s.Minutes;
		}

		public static DialClock operator +(DialClock obj, int minsToAdd)
		{
			return new DialClock(obj.Hours, obj.Minutes + minsToAdd);
		}

		public static DialClock operator -(DialClock obj, int minsToSubtract)
		{
			return new DialClock(obj.Hours, obj.Minutes - minsToSubtract);
		}

        public override bool Equals(object obj)
        {
			if (obj == null) return false;
			if (obj is not DialClock) return false;
			return ((DialClock)obj).Hours == this.Hours && ((DialClock)obj).Minutes == this.Minutes;
        }
    }
}


