using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name: Anupom Roy
Date: July 25
Description: This is the Deck class.
 It inherits from the CardList class
Version: 0.5 - Added Deal1 method
 */
namespace lesson11
{
    public class Deck : CardList
    {
        // PRIVATE INSTANCE VARIABLES
        private Random _random;

        // PRIVATE PROPERTIES
        private Random Random
        {
            get
            {
                return this._random;
            }

        }

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the Deck class.
        /// </summary>
        /*public Deck()
        {
            this._initialize();
        }*/

        // PRIVATE METHODS

        /// <summary>
        /// This is the private _initialize method that loads the deck with 52 cards.
        /// This method also initializes other class variables
        /// </summary>
        protected override void _initialize()
        {
            // initialize the random object
            this._random = new Random();

            // load the list with cards
            for (int suit = 0; suit <= (int)Suit.Spades; suit++)
            {
                for (int face = 1; face <= (int)Face.King; face++)
                {
                    this.Add(new Card((Face)face, (Suit)suit));
                }
            }
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method overrides the built-in ToString method and outputs the current contents
        /// of the deck.
        /// </summary>
        public override string ToString()
        {
            string outputString = "";

            foreach (Card card in this)
            {
                outputString += "The " + card.Face + " of " + card.Suit + "\n";
            }

            return outputString;
        }

        /// <summary>
        /// This method shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            int firstCard;
            int secondCard;
            Card tempCard;

            for (int i = 0; i < this.Count; i++)
            {
                firstCard = this.Random.Next(0, 52);
                secondCard = this.Random.Next(0, 52);
                tempCard = (Card)this[secondCard].Clone();
                this[secondCard].Face = this[firstCard].Face;
                this[secondCard].Suit = this[firstCard].Suit;
                this[firstCard].Face = tempCard.Face;
                this[firstCard].Suit = tempCard.Suit;
            }
        }
        public Card Deal1()
         {

             Card firstCard = (Card)this[0].Clone();
             this.RemoveAt(0); // removes the top card
 
            Console.WriteLine("Deck Contains: " + this.Count + " Cards");
             return firstCard;
        }
    
        
    }

}