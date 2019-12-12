using Story.Characters;

namespace Story.Actions
{
    interface IAction
    {
        void Plant(string[] qualities);
        void Call(Character character);
    }
}
