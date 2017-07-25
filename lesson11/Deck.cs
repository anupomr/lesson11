using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name: Anupom
date: july 25
 Description: 
 * Version: 0.1 - Created the Deck class
 */
namespace lesson11
{
    public class Deck:List<Card>
    {

        public Deck()
        {
            this._initialize();
        }
        private void _initialize()
        {
            for (int suit = 0; suit < (int)Suit.Spreads; suit++)
            {
                for (int faces = 0; faces < (int )Faces.King; faces++)
                {
                    this.Add(new Card((Faces)faces, (Suit)suit));
                }
            }

            
        }
        public override string ToString()
        {
            string outputstring = "";
            foreach (Card card in this)
            {
                outputstring += " The" + card.Faces + "of" + card.Suit+"\n";
            }
            return outputstring;
        }
    }
}