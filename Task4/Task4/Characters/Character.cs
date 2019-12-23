using System;

namespace Task4.Characters
{
    public abstract class Character : IGardener
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Strength { get; set; }

        public Character(string nickname, string name, int strength)
        {
            Name = name;
            Nickname = nickname;
            Strength = strength;
        }

        public abstract void CallForHelp(Character character);
        public abstract void Plant();
        public abstract void Pick();
        public void Pull() => Console.WriteLine("Тянет-тянет, а вытянуть не может");
    }

    public class Male:Character
    {
        public Male(string nickname, string name, int strength)
            : base(nickname, name, strength) { }

        public override void CallForHelp(Character character)
        {
            string nick = character.Nickname;
            Console.WriteLine($"Решил {Nickname} позвать на помощь " +
                $"{nick.Substring(0, nick.Length - 1)}у: \n");
        }

        public override void Plant()
        {
            Console.WriteLine($"Посадил {Nickname} {Name} репку и говорит: \n" +
                $"- Расти, расти, репка, сладка!Расти, расти, репка, крепка!");
        }

        public override void Pick()
        {
            Console.WriteLine($"Пошел {Nickname} {Name} репку рвать.");
        }
    }

    public class Female : Character
    {
        public Female(string nickname, string name, int strength)
            : base(nickname, name, strength) { }

        public override void CallForHelp(Character character)
        {
            string nick = character.Nickname;
            Console.WriteLine($"Решила {Nickname} позвать на помощь " +
                $"{nick.Substring(0, nick.Length - 1)}у: \n");
        }

        public override void Plant()
        {
            Console.WriteLine($"Посадила {Nickname} {Name} репку и говорит: \n" +
                $"- Расти, расти, репка, сладка!Расти, расти, репка, крепка!");
        }

        public override void Pick()
        {
            Console.WriteLine($"Пошла {Nickname} {Name} репку рвать.");
        }
    }

}
