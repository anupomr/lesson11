using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
Name: Anupom
date: july 27
 Description: 
 * Version: 0.1 - Created the Deck class
 */
namespace lesson11
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}