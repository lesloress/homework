using System;
using System.Collections.Generic;
using Task2.Characters;

namespace Task2
{
    public class Narration
    {
        private List<Person> characters = Randomizer.GetCharacters();
        Person first;
        Person second;
        Person third;
        Person fourth;
        Person fifth;
        Person sixth;

        private string sequence;
        private Vegetable veg;
        public Vegetable Veg
        {
            get { return veg; }
            set
            {
                if (value is Turnip t)
                    veg = value;
                else
                    throw new VegetableException("посаженный овощ не репка", value.Name);
            }
        }

        public Narration()
        {
            first = characters[0];
            second = characters[1];
            third = characters[2];
            fourth = characters[3];
            fifth = characters[4];
            sixth = characters[5];
            sequence = $"{first.Nickname} за репку:";
        }

        public void StartStory()
        {
            Console.WriteLine("~~~СКАЗКА \"РЕПКА\"~~~ \n");
            first.Plant(new string[] { "большая", "вкусная", "красивая" });
            try
            {
                Veg = Randomizer.GetVegetable();
                ContinueStory();
            }
            catch (VegetableException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла ошибка: {ex.Message}.\n" +
                    $"Посаженный овощ: {ex.Name}.");
                Console.ResetColor();
            }
        }

        private void ContinueStory()
        {
            string ending = Randomizer.GetEnding();

            Turnip turnip = veg as Turnip;
            turnip.BecomeBig();
            first.StartKilling();
            first.KillWithoutSuccess();

            first.Call(second);
            ChangeSequence(ref sequence, first.Nickname, second.Nickname);
            Pull();

            second.Call(third);
            ChangeSequence(ref sequence, second.Nickname, third.Nickname);
            Pull();

            third.Call(fourth);
            ChangeSequence(ref sequence, third.Nickname, fourth.Nickname);
            Pull();

            fourth.Call(fifth);
            ChangeSequence(ref sequence, fourth.Nickname, fifth.Nickname);
            Pull();

            fifth.Call(sixth);
            ChangeSequence(ref sequence, fifth.Nickname, sixth.Nickname);
            
            Console.WriteLine($"{sequence}\nТянут-тянут и вытягивают!.\n");
            Console.WriteLine(ending + "\n");
            Console.WriteLine("~~~КОНЕЦ~~~");
            
        }

        private static void ChangeSequence(ref string seq, string a, string b)
            =>seq = $"{b} за {a.Substring(0, a.Length - 1)}у, {seq}";

        private void Pull() => 
            Console.WriteLine($"{sequence}\nТянут-тянут, а вытянуть не могут.\n");

        

    }
}
