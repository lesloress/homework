using System;
using System.Collections.Generic;
using Task3.Characters;

namespace Task3
{
    class Randomizer
    {
        static readonly Random rnd = new Random();

        public static List<Person> GetCharacters()
        {
            List<Person> Sequence = new List<Person>();
            Person ch;
            while (characters.Count != 0)
            {
                int value = rnd.Next(characters.Count);
                string[] temp = characters[value];
                int name = rnd.Next(1, temp.Length);
                if (temp[0] == "дедка" || temp[0] == "мышка")
                    ch = new Male(temp[0], temp[name]);
                else
                    ch = new Female(temp[0], temp[name]);

                Sequence.Add(ch);
                characters.RemoveAt(value);
            }
            return Sequence;
        }


        public static Vegetable GetVegetable()
        {
            int rand = rnd.Next(1, 4);
            if (rand == 3)
                return new Vegetable(veggies[rnd.Next(veggies.Length)]);
            else
            {
                return GetTurnip();
            }
        }

        public static string GetEnding()
        {
            int indx = rnd.Next(endings.Count);
            return endings[indx];
        }

        private static Turnip GetTurnip()
        {
            string[] qu = new string[3];
            int i = 0;
            while (i < qu.Length)
            {
                int indx = rnd.Next(qualities.Count);
                qu[i] = qualities[indx];
                qualities.RemoveAt(indx);
                i++;
            }
            return new Turnip(qu);
        }

        private static List<string[]> characters = new List<string[]>
        {
            new string[] { "дедка", "Игорь", "Зорро", "Виталий Фёдорович", "Иван", "Константин"},
            new string[] { "бабка", "Зина", "Маша", "Даша", "Ирина Викторовна", "Лидия Сергеевна"},
            new string[] { "внучка", "Саша", "Настя", "Лиза", "Женя", "Соня"},
            new string[] { "собака", "Жучка", "Ручка", "Кучка", "Зефирка", "Ириска"},
            new string[] { "кошка","Колбаса", "Сосиска", "Валентина Андреевна", "Умка", "Репка"},
            new string[] { "мышка", "Владимир Петрович", "Чебурек", "Сахарок", "Рогалик", "Пончик"}
        };

        private static List<string> qualities = new List<string>
            { "вкусная", "сочная", "большая-пребольшая",
            "красивая", "умная", "добрая", "сладкая",
            "спортивная", "возбуждающая аппетит", "толстая"};

        private static List<string> endings = new List<string>
        {
            "Как выяснилось позже, дедка покинул страну забрав с собой репку.\nБольше о нем никто ничего не слышал.",
            "Через много лет репка окончила школу и стала успешным стоматологом.",
            "После случившегося на землю напали инопланетяне."
        };
        public static string[] veggies = { "картошка", "морковка", "редиска"};
    }
    
}
