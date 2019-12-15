using System;

namespace Task2
{
    class VegetableException:Exception
    {
        public string Name { get; }
        public VegetableException(string message, string name)
        : base(message)
        {
            Name = name;
        }
    }
}
