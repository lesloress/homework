using System;
using System.Collections.Generic;
using System.Threading;
using Story.Characters;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            //get random sequence of characters
            List<Character> characters = RandomPlay.GetCharacters();
            Character first = characters[0];
            Character second = characters[1];
            Character third = characters[2];
            Character fourth = characters[3];
            Character fifth = characters[4];
            Character sixth = characters[5];
            //get random turnip and ending of the story
            Turnip turnip = RandomPlay.GetTurnip();
            string ending = RandomPlay.GetEnding();
            string sequence = $"{first.Nickname} за репку:";

            Console.WriteLine("~~~СКАЗКА \"РЕПКА\"~~~ \n");
            Thread.Sleep(3500);

            first.Plant(turnip.Qualities);
            Thread.Sleep(4000);

            turnip.BecomeBig();
            Thread.Sleep(3500);

            first.StartKilling();
            Thread.Sleep(3500);

            first.KillWithoutSuccess();
            Thread.Sleep(4000);

            first.Call(second);
            sequence = $"{second.Nickname} за " +
                $"{first.Nickname.Substring(0, first.Nickname.Length - 1)}у, {sequence}";
            Thread.Sleep(3500);

            Console.WriteLine($"{sequence}\nТянут-тянут, а вытянуть не могут.\n");
            Thread.Sleep(4000);

            second.Call(third);
            sequence = $"{third.Nickname} за " +
                $"{second.Nickname.Substring(0, second.Nickname.Length - 1)}у, {sequence}";
            Thread.Sleep(3500);

            Console.WriteLine($"{sequence}\nТянут-тянут, а вытянуть не могут.\n");
            Thread.Sleep(4000);

            third.Call(fourth);
            sequence = $"{fourth.Nickname} за " +
                $"{third.Nickname.Substring(0, third.Nickname.Length - 1)}у, {sequence}";
            Thread.Sleep(3500);

            Console.WriteLine($"{sequence}\nТянут-тянут, а вытянуть не могут.\n");
            Thread.Sleep(4000);

            fourth.Call(fifth);
            sequence = $"{fifth.Nickname} за " +
                $"{fourth.Nickname.Substring(0, fourth.Nickname.Length - 1)}у, {sequence}";
            Thread.Sleep(3500);

            Console.WriteLine($"{sequence}\nТянут-тянут, а вытянуть не могут.\n");
            Thread.Sleep(4000);

            fifth.Call(sixth);
            sequence = $"{sixth.Nickname} за " +
                $"{fifth.Nickname.Substring(0, fifth.Nickname.Length - 1)}у, {sequence}";
            Thread.Sleep(3500);

            Console.WriteLine($"{sequence}\nТянут-тянут и вытягивают!.\n");
            Thread.Sleep(3000);

            Console.WriteLine(ending + "\n");
            Thread.Sleep(3000);

            Console.WriteLine("~~~КОНЕЦ~~~");


            Console.ReadLine();
        }
    }
}
