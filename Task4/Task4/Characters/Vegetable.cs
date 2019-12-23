using System;

namespace Task4.Characters
{
    public class Vegetable
    {
        public virtual string Name { get; }
        public Vegetable(string name)
        {
            Name = name;
        }
    }

    public class Turnip : Vegetable
    {
        public override string Name => "репка";
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

    public class Carrot : Vegetable
    {
        public override string Name => "морковка";
        public string quality => "оранжевая";
        public Carrot(string[] qualities) : base("морковка") { }
    }

    public class Potato : Vegetable
    {
        public override string Name => "картошка";
        public string quality => "круглая";
        public Potato(string[] qualities) : base("картошка") { }
    }
}
