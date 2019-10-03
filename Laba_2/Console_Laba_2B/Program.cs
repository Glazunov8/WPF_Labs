using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Laba_2B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Suits = new string[] { "Буби", "Черви", "Крести", "Пики"};
            Deck deck = new Deck();

            for (int i = 0; i < 52; i+=4)
                for (int j = 0; j < 4; j++)
                    deck.SetCard(i+j, i, Suits[j]);

            for (int i = 0; i < 52; i += 4)
                for (int j = 0; j < 4; j++)
                    Console.WriteLine(deck.GetCard(i+j).ToString());

            int c;
            do
            {
                switch (c = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        deck.Shuffle();
                        for (int i = 0; i < 52; i += 4)
                            for (int j = 0; j < 4; j++)
                                Console.WriteLine(deck.GetCard(i + j).ToString());
                        break;
                }
            } while (c != 0);
        }
    }
}
