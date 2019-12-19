using System;
using System.Collections.Generic;
using Task3.Characters;

namespace Task3
{
    public delegate void StartAgain();
    
    public class Narration
    {
        private delegate void DoSmth(); //do smth with turnip
        public event StartAgain OnExcept;

        private static List<Person> characters = Randomizer.GetCharacters();
        DoSmth pull;
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
            sequence = $"{characters[0].Nickname} за репку:";
            pull = () => Console.WriteLine($"{sequence}\nТянут-тянут, а вытянуть не могут.\n");
        }

        public void StartStory()
        {
            characters[0].Plant(new string[] { "большая", "вкусная", "красивая" });
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
                OnExcept();
            }
        }

        private void ContinueStory()
        {
            string ending = Randomizer.GetEnding();

            Turnip turnip = veg as Turnip;
            turnip.BecomeBig();
            characters[0].StartKilling();
            characters[0].KillWithoutSuccess();
            
            CallNext(ref sequence, characters[0], characters[1]);
            pull();
            
            CallNext(ref sequence, characters[1], characters[2]);
            pull();
            
            CallNext(ref sequence, characters[2], characters[3]);
            pull();
            
            CallNext(ref sequence, characters[3], characters[4]);
            pull();
            
            CallNext(ref sequence, characters[4], characters[5]);

            Console.WriteLine($"{sequence}\nТянут-тянут и вытягивают!.\n");
            Console.WriteLine(ending + "\n");
            Console.WriteLine("~~~КОНЕЦ~~~");
        }

        private static void ChangeSequence(ref string seq, string a, string b)
            =>seq = $"{b} за {a.Substring(0, a.Length - 1)}у, {seq}";

        private void CallNext(ref string sequence, Person a, Person b)
        {
            a.Call(b);
            ChangeSequence(ref sequence, a.Nickname, b.Nickname);
        }

    }
}
