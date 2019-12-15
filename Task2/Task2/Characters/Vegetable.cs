using System;

namespace Task2.Characters
{
    public class Vegetable
    {
        public string Name { get; }
        public Vegetable(string name)
        {
            Name = name;
        }
    }

    public class Turnip:Vegetable
    {
        string[] qualities;
        public string[] Qualities
        {
            get
            {
                return qualities;
            }
            set
            {
                if (value.Length == 3)
                    qualities = value;
            }
        }

        public Turnip(string[] qualities) : base("репка")
        {
            this.qualities = qualities;
        }
        public void BecomeBig()
        {
            Console.WriteLine($"Выросла репка {qualities[0]}, {qualities[1]}, {qualities[2]}.");
        }
    }
}
