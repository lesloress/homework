using System;
using Task3.KeyEvents;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~СКАЗКА \"РЕПКА\"~~~ \n");
            Narration narration = new Narration();

            narration.OnExcept += narration.StartStory;

            narration.StartStory();



            //KeyEvent kevt = new KeyEvent();

            //ConsoleKeyInfo key;

            //kevt.KeyPress += (sender, e) =>
            //{
            //    char ch = e.key.KeyChar;
            //    if (ch == '1')
            //    {
            //        Console.Clear();
            //        StartNewStory();
            //    }
            //};
            Console.ReadLine();
        }
    }
}
