using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~СКАЗКА \"РЕПКА\"~~~ \n");
            Narration narration = new Narration();
            narration.OnExcept += narration.StartStory;

            narration.StartStory();

            Console.ReadLine();
        }
    }
}
