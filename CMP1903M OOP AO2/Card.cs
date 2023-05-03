using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_OOP_AO2
{
    class Card
    {
        public int Suit { get; set; } //Card pnly has 2 variables, Value and Suit
        public int Value { get; set; }
        public Card(int Suit, int Value) //constructor to set Suit and Value (encapsulation)
        {
            this.Suit = Suit;
            this.Value = Value;
        }

    }
}
