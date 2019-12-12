using System;

namespace Story.Characters
{
    public class Turnip
    {
        string[] qualities;
        public string Name { get => "репка"; }
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

        public Turnip(string[] qualities)
        {
            this.qualities = qualities;
        }
        public void BecomeBig()
        {
            Console.WriteLine($"Выросла репка {qualities[0]}, {qualities[1]}, {qualities[2]}.");
        }
    }
}
