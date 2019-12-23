using System;

namespace Task4
{
    class VegetableException:Exception
    {
        public string Name { get; }
        public VegetableException(string message, string veggieName)
        : base(message)
        {
            Name = veggieName;
        }
    }
}
