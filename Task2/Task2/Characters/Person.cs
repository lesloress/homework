using System;

namespace Task2.Characters
{
    public abstract class Person : IAction, IVegetableKiller
    {
        public string Nickname { get; set; }
        public string Name { get; }
        public Person(string nickname, string name)
        {
            Nickname = nickname;
            Name = name;
        }
        public void KillWithoutSuccess()
        {
            Console.WriteLine("Тянет-тянет, вытянуть не может");
        }
        public abstract void Plant(string[] qualities);
        public abstract void Call(Person character);
        public abstract void StartKilling();
    }

    public class Female : Person
    {
        public Female(string nickname, string name) : base(nickname, name) { }
        public override void Plant(string[] qualities)
        {
            Console.WriteLine($"Посадила {Nickname} {Name} репку и говорит: \n" +
                $"- Расти, репка, {qualities[0]}, {qualities[1]} и {qualities[2]}!");
        }

        public override void Call(Person character)
        {
            string nick = character.Nickname;
            Console.WriteLine($"Позвала {Nickname} на помощь {nick.Substring(0, nick.Length - 1)}у: \n" +
                $"- {character.Name}, помоги репку рвать!");
        }

        public override void StartKilling()
        {
            Console.WriteLine($"Пошла {Nickname} {Name} репку рвать.");
        }
    }

    public class Male : Person
    {
        public Male(string nickname, string name) : base(nickname, name) { }
        public override void Plant(string[] qualities)
        {
            Console.WriteLine($"Посадил {Nickname} {Name} репку и говорит: \n" +
                $"- Расти, репка, {qualities[0]}, {qualities[1]} и {qualities[2]}!");
        }
        public override void Call(Person character)
        {
            string nick = character.Nickname;
            Console.WriteLine($"Позвал {Nickname} на помощь {nick.Substring(0, nick.Length - 1)}у: \n" +
                $"- {character.Name}, помоги репку рвать!");
        }
        public override void StartKilling()
        {
            Console.WriteLine($"Пошел {Nickname} {Name} репку рвать.");
        }
    }
}
