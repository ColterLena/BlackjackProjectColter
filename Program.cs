using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackProjectColter
{
    class Program
    {
        class Card
        {
            public string Face { get; set; }
            public string Suit { get; set; }
            public int Value()
            {
                switch (Face)
                {
                    case "10":
                    case "Jack":
                    case "Queen":
                    case "King":
                        return 10;

                    case "Ace":
                        return 11;

                    default:
                        return int.Parse(Face);
                }
            }
        }
        class Deck
        {
            private List<Card> Cards = new List<Card>();

            public void MakeCards()
            {
                var suits = new string[] { "Clubs", "Diamonds", "Hearts", "Spades" };
                var faces = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

                foreach (var suit in suits)
                {
                    foreach (var face in faces)
                    {
                        var newCard = new Card
                        {
                            Suit = suit,
                            Face = face,
                        };
                        Cards.Add(newCard);
                    }
                }
                var randomNumberGenerator = new Random();

                for (var index = Cards.Count - 1; index >= 1; index--)
                {
                    var otherIndex = randomNumberGenerator.Next(index);

                    var firstCard = Cards[index];
                    var otherCard = Cards[otherIndex];

                    Cards[index] = otherCard;
                    Cards[otherIndex] = firstCard;
                }
            }

            public Card Deal()
            {
                var card = Cards[0];

                Cards.Remove(card);

                return card;
            }
            class Hand
            {
                public List<Card> CardsBeingHeld = new List<Card>();
                public void Accept(Card cardWeAreGivenToHold)
                {
                    CardsBeingHeld.Add(cardWeAreGivenToHold);
                }
                public void ShowCards()
                {
                    foreach (var card in CardsBeingHeld)
                    {
                        Console.WriteLine($"{card.Face} of {card.Suit}");
                    }
                }
                public int TotalValue()
                {
                    var total = 0;
                    foreach (var card in CardsBeingHeld)
                    {
                        var cardValue = card.Value();
                        total = total + cardValue;
                    }
                    return total;
                }

            }
            class Game
            {
                public void Play()
                {
                    var deck = new Deck();

                    deck.MakeCards();

                    var playerHand = new Hand();

                    var dealerHand = new Hand();

                    var firstCard = deck.Deal();
                    playerHand.Accept(firstCard);

                    var secondCard = deck.Deal();
                    playerHand.Accept(secondCard);

                    var firstCardForDealer = deck.Deal();
                    dealerHand.Accept(firstCardForDealer);

                    var secondCardForDealer = deck.Deal();
                    dealerHand.Accept(secondCardForDealer);

                    while (playerHand.TotalValue() <= 21)
                    {
                        Console.WriteLine();
                        playerHand.ShowCards();
                        Console.WriteLine($"For a total value of {playerHand.TotalValue()}");
                        Console.WriteLine();

                        Console.Write("(H)it or (S)tand: ");
                        var answer = Console.ReadLine();

                        if (answer == "H")
                        {
                            var extraCard = deck.Deal();
                            playerHand.Accept(extraCard);
                        }
                        else
                        {
                            // Break us out of the most inner loop, in this case the `while < 21`
                            // 13. If STAND continue on
                            break;
                        }
                    }

                    Console.WriteLine();
                    playerHand.ShowCards();
                    Console.WriteLine($"For a total value of {playerHand.TotalValue()}");
                    Console.WriteLine();

                    while (dealerHand.TotalValue() < 17)
                    {
                        // 15. If the dealer has busted then goto step 17
                        // 16. If the dealer has less than 17
                        //     - Ask the deck for a card and place it in the dealer hand
                        var extraCard = deck.Deal();
                        dealerHand.Accept(extraCard);
                    }


                    Console.WriteLine();
                    Console.WriteLine("Dealer has:");
                    dealerHand.ShowCards();
                    var computedTotalValueOfDealerHand = dealerHand.TotalValue();
                    Console.WriteLine($"For a total value of {computedTotalValueOfDealerHand}");
                    Console.WriteLine();

                    if (playerHand.TotalValue() > 21)
                    {
                        Console.WriteLine("Dealer Wins!");
                    }
                    else
                    if (dealerHand.TotalValue() > 21)
                    {
                        Console.WriteLine("Player Wins!");
                    }
                    else if (dealerHand.TotalValue() >= playerHand.TotalValue())
                    {
                        Console.WriteLine("Dealer Wins!");
                    }
                    else
                    {
                        Console.WriteLine("Player Wins!");
                    }
                }
                static void Main(string[] args)
                {
                    var keepPlaying = true;

                    while (keepPlaying)
                    {
                        var game = new Game();
                        game.Play();
                        Console.Write("Play again? (Y/N): ");
                        var playAgainString = Console.ReadLine();
                        keepPlaying = (playAgainString == "Y");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Thank You for Playing Blackjack!");
                }
            }
        }
    }
}