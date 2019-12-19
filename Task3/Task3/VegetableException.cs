using System;

namespace Task3
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
