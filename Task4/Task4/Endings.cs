﻿using System;

namespace Task4
{
    public static class Endings
    {
        public delegate void EndingDelegate<T>(T ending);
        public static EndingDelegate<string> strEnding;

        public static EndingDelegate<string> GetEnding()
        {
            EndingDelegate<string> ending = Fail;
            return ending;
        }

        public static EndingDelegate<string> GetEnding(int num, string price)
        {
            if (num <= 10)
            {
                EndingDelegate<string> ending = SellTurnip;
                return ending;
            }
            else
            {
                EndingDelegate<string> ending = Success;
                return ending;
            }
        }

        public static EndingDelegate<int> GetEnding(int num, int price)
        {
            EndingDelegate<int> ending = SellTurnip;
            return ending;
        }

        public static void SellTurnip<T>(T price)
        {
            if (price.GetType().Equals(typeof(Int32)))
                Console.WriteLine($"В конце концов вытащили они репку и продали её за {price} гривен, а после уехали на Бали.");
            else
                Console.WriteLine($"В конце концов вытащили они репку и продали её за {price}.");
        }

        public static void Fail(string nick) => Console.WriteLine(
            $"Так и не вытащили они репку и съели {nick.Substring(0, nick.Length - 1)}у.");

        public static void Success<T>(T prof) => Console.WriteLine(
            $"И вот вытащили они репку и вырастили её в любви и заботе. \n" +
            $"И стала репка успешным {prof}.");
    }
}
