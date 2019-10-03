using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Laba_2B
{
    public class Card
    {
        private readonly int rank;
        private readonly string suit;
        Card()
        {
            rank = 0;
            suit = "";
        }
        public Card(int rank, string suit)
        {
            this.rank = rank;
            this.suit = suit;
        }
        public override string ToString()
        {
            return $"{suit} {rank}";
        }
    }

    public class Deck
    {
        public Card[] cards;
        public Deck()
        {
            cards = new Card[52];
        }

        public void SetCard(int index, int rank, string suit)
        {
            cards[index] = new Card(rank, suit);
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < 52; i++)
            {
                int j = random.Next(52);
                Card buf = cards[j];
                cards[j] = cards[i];
                cards[i] = buf;
            }
        }
    }
}
