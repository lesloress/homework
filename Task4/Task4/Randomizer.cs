using System;
using System.Collections.Generic;
using Task4.Characters;

namespace Task4
{
    public static class Randomizer
    {
        public static readonly Random rnd = new Random();
        //static Delegate ending

        public static Character[] GetCharacters(int length) 
        {
            Character[] list = new Character[length];
            Character ch;
            for (int i = 0; i < list.Length && characters.Count != 0; i++ )
            {
                int value = rnd.Next(characters.Count);
                int strength = rnd.Next(1, 10);
                string[] temp = characters[value];
                int name = rnd.Next(1, temp.Length);
                if (temp[0] == "дедка" || temp[0] == "мышка")
                    ch = new Male(temp[0], temp[name], strength);
                else
                    ch = new Female(temp[0], temp[name], strength);

                list[i] = ch;
                characters.RemoveAt(value);
            }
            return list;
        }

        public static Vegetable GetVegetable() 
        {
            int rand = rnd.Next(0, 10);
            if (rand > 1)

                return GetTurnip();
            else
            {
                return new Vegetable(veggies[rand]);
            }
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
            new string[] { "дедка", "Игорь Степанович", "Андрей Алексеевич", "Виталий Фёдорович", "Иван Владимирович"},
            new string[] { "бабка", "Зинаида Фёдоровна", "Мария Ивановна", "Ирина Викторовна", "Лидия Сергеевна"},
            new string[] { "внучка", "Саша", "Настя", "Лиза", "Женя", "Соня"},
            new string[] { "собака", "Жучка", "Ручка", "Кучка", "Зефирка", "Ириска"},
            new string[] { "кошка","Колбаса", "Сосиска", "Валентина Андреевна", "Умка", "Репка"},
            new string[] { "мышка", "Владимир Петрович", "Чебурек", "Сахарок", "Рогалик", "Пончик"}
        };

        private static List<string> qualities = new List<string>
            { "вкусная", "сочная", "большая-пребольшая",
            "красивая", "умная", "добрая", "сладкая",
            "крепкая", "возбуждающая аппетит", "толстая"};

        //private static List<string> endings = new List<string>
        //{
        //    "Как выяснилось позже, дедка покинул страну забрав с собой репку.\nБольше о нем никто ничего не слышал.",
        //    "Через много лет репка окончила школу и стала успешным стоматологом.",
        //    "После случившегося на землю напали инопланетяне."
        //};
        public static string[] veggies = { "картошка", "морковка", "репка" };
    }
}
