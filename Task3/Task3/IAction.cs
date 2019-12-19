using Task3.Characters;

namespace Task3
{
    interface IAction
    {
        void Plant(string[] qualities);
        void Call(Person person);
    }
}
