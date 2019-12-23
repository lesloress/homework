using System.Collections;
using System.Linq;

namespace Task4.Characters
{
    class ListOfCharacters
    {

        private Character[] list = new Character[6];
        string sequence;
        public string Sequence => sequence;
        public int FullStrength => list.Sum(l => l.Strength)/list.Length;

        public ListOfCharacters()
        {
            list = Randomizer.GetCharacters(list.Length);
            sequence = list[0].Nickname + " за репку";
        }

        public Character this[int index]
        {
            get
            {
                return list[index];
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 1; i < list.Length; i++)
            {
                list[i - 1].CallForHelp(list[i]);
                ChangeSequence(ref sequence, list[i - 1].Nickname, list[i].Nickname);
                yield return list[i];
            }
        }

        private static void ChangeSequence(ref string seq, string a, string b)
            => seq = $"{b} за {a.Substring(0, a.Length - 1)}у, {seq}";
    }
}
