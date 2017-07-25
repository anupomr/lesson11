using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lesson11
{
    public class Card
    {
        private Faces _face;
        private Suit _suit;

        public Faces Faces
        {
            get
            {
                return this._face;
            }

            set
            {
                this._face = value;
            }
        }
        public Suit Suit
        {
            get
            {
                return this._suit;
            }

            set
            {
                this._suit = value;
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the Card class.
        /// It takes two parameters - face (Face) - suit (Suit)
        /// </summary>
        /// <param name="face"></param>
        /// <param name="suit"></param>
        public Card(Faces face, Suit suit)
        {
            this.Faces = face;
            this.Suit = suit;
        }


        // PRIVATE METHODS

        // PUBLIC METHODS
    }
}