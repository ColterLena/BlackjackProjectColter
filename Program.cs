using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackProjectColter
{
  class Program
  {
    static void Main(string[] args)
    {
     /*
      1. Create a deck of 52 cards.
      2. Create a algorithm to shuffle the cards.
      3. Draw four cards from the Deck.
      4. Set up a loop so the program will keep drawing cards until the deck run out.
      5. Allocated the first set of two cards of each sequence to the player.
      6. Allocated the second set of two cards of each sequence to the dealer.
      7. Show the player his set of cards at the beginning of each hand.
      8. Give the player the functionality to Hit or Stand.
      9. For Hit, instruct the program to draw another card and allocate it to the player.
      10. For Stand, tell the program begin the dealer's turn.
      11. If the player's hand is greater than a count of 21 then the player will automatically bust.
      12. If the player busts, the program will skip the dealer's turn, and it will automatically win.
      13. At the start of the dealer's turn, the program will reveal the dealer's cards to the player.
      14. Create an algorithm that instructs the dealer to continue drawing cards until its card total reaches 17 or more.
      15. If the program's card total goes over 21, then instruct the program to bust the dealers hand and declare the player the winner.
      16. If no one busts, set up algorithm to calculate which players' card total is closer to 21.
      17. Add written commands that declare: "Player Wins","Dealer Wins", or "Tie".
      18. Add a loop that allows the player to play again. This loop should reshuffle the deck and reset the hands.
     */

     /* Random rnd = new Random ();
      var cards = new List<string>() {"2 of Clubs", "3 of Clubs", "4 of Clubs", "5 of Clubs", "6 of Clubs", "7 of Clubs", "8 of Clubs", "9 of Clubs", "10 of Clubs", "Jack of Clubs", "Queen of Clubs", "King of Clubs", "Ace of Clubs", "2 of Diamonds", "3 of Diamonds", "4 of Diamonds", "5 of Diamonds", "6 of Diamonds", "7 of Diamonds", "8 of Diamonds", "9 of Diamonds", "10 of Diamonds", "Jack of Diamonds", "Queen of Diamonds", "King of Diamonds", "Ace of Diamonds", "2 of Hearts", "3 of Hearts", "4 of Hearts", "5 of Hearts", "6 of Hearts", "7 of Hearts", "8 of Hearts", "9 of Hearts", "10 of Hearts", "Jack of Hearts", "Queen of Hearts", "King of Hearts", "Ace of Hearts", "2 of Spades", "3 of Spades", "4 of Spades", "5 of Spades", "6 of Spades", "7 of Spades", "8 of Spades", "9 of Spades", "10 of Spades", "Jack of Spades", "Queen of Spades", "King of Spades", "Ace of Spades"};
      for (var card in cards)

      var suits = new List<string>() {"Clubs", "Diamonds", "Hearts", "Spades"};
      var value = new List<string>() {"2","3","4","5","6","7","8","9","10","Jack","Queen","King","Ace"};
      var deck = foreach (var suits in value)
      */
     var names = new List<string>() { "Mark", "Paula", "Sandy" , "Bill" };
      for (var index = 0; index < names.Count; index++) {
      var name = names[index];
      Console.WriteLine(name);}
    }
  }
}
