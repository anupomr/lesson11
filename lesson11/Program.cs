﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Anupom Roy
 * Date: July 25, 2017
 * Description: Demo for Lesson 11
 * Version: 0.5 - HighestCards implemented in driver class
 */
namespace lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            Hand hand = new Hand(); // new empty Hand container

            Deck deck = new Deck();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();
            deck.Shuffle();
            Console.WriteLine(deck.ToString());
            Console.WriteLine();


            /*hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());
            Console.WriteLine();
            hand.Add(deck.Deal1()); // deal one card from the top of the deck
            Console.WriteLine(hand.ToString());*/


            // hand = deck.Deal5(); // creates a new Hand object and assigns it to hand
            // deal one card from the top of the deck
            hand = deck.Deal5();
            hand.HighestCards(hand);

        }

    }
}
