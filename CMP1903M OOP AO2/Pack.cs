using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_OOP_AO2
{
    class Pack
    {
        public List<Card> cards = new List<Card>(); //creates a list to add all the cards to
        public Pack()
        {
            this.reset();
        }

        public void reset()
        {
            cards.Clear();
            for (int Value = 1; Value <= 13; Value++) //loops through the amount of values in a deck of cards
            {
                for (int Suit = 1; Suit <= 4; Suit++) //loops through the amount of suits in a deck of cards
                {
                    cards.Add(new Card(Suit, Value)); //adds each individual card
                }
            }
        }

        //function to deal a single card from the set pack
        public Card deal()
        {
            var packSize = Testing.PACK.cards.Count - 1; //sets a pack size to reduce logic
            Card deal_card = Testing.PACK.cards[packSize]; //copies(draws) a card from the deck
            Testing.PACK.cards.RemoveAt(packSize); //removes the drawn card from the original deck
            return deal_card; //returns the card
        }

        //function to deal multiple cards from the set pack up to a limit of how many cards there are in the pack
        public static List<Card> dealCard(int amount)
        {
            List<Card> tempCards = new List<Card>(); //declares a list to add the drawn cards to
            var packSize = Testing.PACK.cards.Count - 1; //presets the pack size to reduce logic
            {
                for (int i = 0; i < amount; i++) //loops through the set amount of cards
                {
                    tempCards.Add(Testing.PACK.cards[packSize - i]); //copies across the drawn card to the temporary list
                    Testing.PACK.cards.RemoveAt(packSize - i); //removes the drawn card from the current deck
                }
                return tempCards; //returns the list of drawn cards
            }
        }

        //function to shuffle the cards using the riffle shuffle method where the cards are split in two and then shuffled alternatively back together
        public bool fisherShatesShuffle()
        {
            var packSize = cards.Count; //presets packsize to reduce logic
            foreach (Card card in cards.ToList()) //runs through each card in the deck
            {
                var index = cards.IndexOf(card); //grabs the index of the card
                var randIndex = Testing.RANDOM.Next(0, (packSize)); //grabs a random position/number in the set range
                var tempVar = cards[randIndex]; //takes a random card from the random position our of the deck
                cards[randIndex] = cards[index]; //places the card somewhere else in the deck
                cards[index] = tempVar; //places the card somewehere else in the deck
            }
            Console.WriteLine("Fisher-Yates Shuffle Complete");
            return true; //confirms the shuffle has completed
        }
    }
}
