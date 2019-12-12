using System;

namespace Story.Characters
{
    public class Man: Character
    {
        public Man(string nickname, string name) : base(nickname, name) { }
        public override void Plant(string[] qualities)
        {
            Console.WriteLine($"Посадил {Nickname} {Name} репку и говорит: \n" +
                $"- Расти, репка, {qualities[0]}, {qualities[1]} и {qualities[2]}!\n");
        }
        public override void Call(Character character)
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
