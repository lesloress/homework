using Task2.Characters;

namespace Task2
{
    interface IAction
    {
        void Plant(string[] qualities);
        void Call(Person person);
    }
}
