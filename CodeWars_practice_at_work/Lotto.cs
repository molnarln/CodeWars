using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars
{
    public static class Lotto
    {
        public static Lottery[] LotteryFunction(Lottery[] lotterys, int pricePool)
        {
            Random random = new Random();
            int[] Nyeroszamok = new int[5];
            int numberOfFourMatches = 0;
            int numberOfFiveMatches = 0;
            for (int i = 0; i < Nyeroszamok.Length; i++)
            {
                int randomNumber = 0;
                while (Array.IndexOf(Nyeroszamok, randomNumber) != -1 || randomNumber == 0)
                {
                    randomNumber = random.Next(1, 60);
                }
                Nyeroszamok[i] = randomNumber;
            }
            for (int i = 0; i < lotterys.Length; i++)
            {
                lotterys[i].Matches = lotterys[i].Numbers.Intersect(Nyeroszamok).ToList().Count();
                if (lotterys[i].Matches == 4)
                {
                    numberOfFourMatches++;
                }
                else if (lotterys[i].Matches == 5)
                {
                    numberOfFiveMatches++;
                }
            }
            for (int i = 0; i < lotterys.Length; i++)
            {
                if (lotterys[i].Matches == 4 && numberOfFourMatches != 0)
                {
                    lotterys[i].Prize = pricePool * 0.3 / numberOfFourMatches;
                }
                if (lotterys[i].Matches == 5 && numberOfFiveMatches != 0)
                {
                    lotterys[i].Prize = pricePool * 0.7 / numberOfFiveMatches;
                }
                if (lotterys[i].Matches == 5 && numberOfFourMatches == 0)
                {
                    lotterys[i].Prize = pricePool * 0.7;
                }
                if (lotterys[i].Matches == 5 && numberOfFiveMatches == 0)
                {
                    lotterys[i].Prize = pricePool * 0.7;
                }
            }
            return lotterys;
        }
    }

    public class Lottery
    {
        public int[] Numbers { get; set; }
        public int Matches { get; set; }
        public double Prize { get; set; }
        public Lottery(int[] numbers)
        {
            this.Numbers = numbers;
        }
    }
}
