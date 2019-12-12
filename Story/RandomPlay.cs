using System;
using System.Collections.Generic;
using Story.Characters;

namespace Story
{
    public static class RandomPlay
    {
        static Random rnd = new Random();
        public static List<Character> GetCharacters()
        {
            List<Character> Sequence = new List<Character>();
            Character ch;
            while (characters.Count != 0)
            {
                int value = rnd.Next(characters.Count);
                string[] temp = characters[value];
                int name = rnd.Next(1, temp.Length);
                if (temp[0] == "дедка" || temp[0] == "мышка")
                    ch = new Man(temp[0], temp[name]);
                else
                    ch = new Woman(temp[0], temp[name]);

                Sequence.Add(ch);
                characters.RemoveAt(value);
            }
            return Sequence;
        }
        public static Turnip GetTurnip()
        {
            string[] qu = new string[3];
            int i = 0;
            while(i < qu.Length)
            {
                int indx = rnd.Next(qualities.Count);
                qu[i] = qualities[indx];
                qualities.RemoveAt(indx);
                i++;
            }
            return new Turnip(qu);
        }

        public static string GetEnding()
        {
            int indx = rnd.Next(endings.Count);
            return endings[indx];
        }
        
        private static List<string[]> characters = new List<string[]>
        {
            new string[] { "дедка", "Игорь", "Зорро", "Виталий Фёдорович", "Иван", "Константин"},
            new string[] { "бабка", "Зина", "Маша", "Даша", "Зорро", "Лидия Сергеевна"},
            new string[] { "внучка", "Саша", "Настя", "Лиза", "Женя", "Соня"},
            new string[] { "собака", "Жучка", "Ручка", "Кучка", "Зефирка", "Ириска"},
            new string[] { "кошка","Колбаса", "Сосиска", "Валентина Андреевна", "Умка", "Репка"},
            new string[] { "мышка", "Владимир Петрович", "Чебурек", "Сахарок", "Рогалик", "Пончик"}
        };

        private static List<string> qualities = new List<string>
            { "вкусная", "сочная", "большая-пребольшая",
            "красивая", "умная", "добрая", "без вредных привычек",
            "спортивная", "возбуждающая аппетит", "толстая"};

        private static List<string> endings = new List<string>
        {
            "Как выяснилось позже, дедка покинул страну забрав с собой репку.\nБольше о нем никто ничего не слышал.",
            "Через много лет репка окончила школу (с золотой медалью) \nи стала успешным стоматологом.",
            "Вытянув репку, все поняли, что это был буряк."
        };
    }
}
