using System;

namespace Story.Characters
{
    public class Woman:Character
    {
        public Woman(string nickname, string name):base(nickname, name) { }
        public override void Plant(string[] qualities)
        {
            Console.WriteLine($"Посадила {Nickname} {Name} репку и говорит: \n" +
                $"- Расти, репка, {qualities[0]}, {qualities[1]} и {qualities[2]}!\n");
        }

        public override void Call(Character character)
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
}
