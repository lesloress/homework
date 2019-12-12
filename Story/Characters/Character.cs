using System;
using Story.Actions;

namespace Story.Characters
{
    public abstract class Character : IAction, IVegetableKiller
    {
        public string Nickname { get; set; }
        public string Name { get; }

        public Character(string nickname, string name)
        {
            Nickname = nickname;
            Name = name;
        }
        public void KillWithoutSuccess()
        {
            Console.WriteLine("Тянет-тянет, вытянуть не может");
        }
        public abstract void Plant(string[] qualities);
        public abstract void Call(Character character);
        public abstract void StartKilling();
    }
}
