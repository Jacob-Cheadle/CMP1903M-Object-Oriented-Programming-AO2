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
        public static Card deal()
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
        public bool riffleShuffle()
        {
            var packSize = cards.Count; //presets packsize to reduce logic
            if (packSize % 2 != 0 && packSize <= 2) //ensures that the cards can be riffle shuffled equally
            {
                return false; //returns false if the cards cannot be shuffled
            }
            var leftPack = cards.GetRange(0, (packSize / 2));
            var rightPack = cards.GetRange((packSize / 2), packSize / 2); //splits the cards into two seperate decks
            var newPack = new List<Card>();
            for (var i = 0; i < (packSize / 2); i++) //alternates through each deck adding one card from each to the new deck
            {
                newPack.Add(leftPack[i]);
                newPack.Add(rightPack[i]);
            }
            cards = newPack; //sets the main deck as the new shuffled deck
            Console.WriteLine("Riffle Shuffle Complete");
            return true; //confirms the successful shuffle
        }
    }
}
