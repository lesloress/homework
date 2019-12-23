using System;
using System.Collections.Generic;
using System.Text;
using Task4.Characters;

namespace Task4
{
    public delegate void StartAgain();
    public class Narration
    {
        public event StartAgain OnExcept;
        private delegate void DoSmth(); //do smth with turnip
        DoSmth pull;
        DoSmth tryAgain;

        private ListOfCharacters listOfCharacters;
        private Vegetable vegetable;
        private string sequence => listOfCharacters.Sequence;

        public Vegetable Vegetable
        {
            get { return vegetable; }
            set
            {
                if (value is Turnip t)
                    vegetable = value;
                else
                    throw new VegetableException("посаженный овощ не репка", value.Name);
            }
        }

        public Narration()
        {
            listOfCharacters = new ListOfCharacters();
            pull = () => Console.WriteLine($"{sequence}\nТянут-тянут, а вытянуть не могут.\n");
            tryAgain = () => Console.WriteLine($"На следующий год: ");
        }

        public void StartStory()
        {
            listOfCharacters[0].Plant();
            try
            {
                Vegetable = Randomizer.GetVegetable();
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
            Turnip turnip = vegetable as Turnip;
            turnip.BecomeBig();
            
            listOfCharacters[0].Pick();
            listOfCharacters[0].Pull();
            
            foreach (Character c in listOfCharacters)
            {
                pull();
            }

            EndStory();
        }

        private void EndStory()
        {
            if (listOfCharacters.FullStrength < 5)
            {
                Endings.GetEnding(0)(listOfCharacters[Randomizer.rnd.Next(0, 7)].Nickname);
            }
            else
            {
                int rnd = Randomizer.rnd.Next(1, 30);
                if (rnd > 20)
                    Endings.GetEnding()(100);
                else
                    Endings.GetEnding(rnd)("за 3 коровы");
            }

        }
        
    }
}
