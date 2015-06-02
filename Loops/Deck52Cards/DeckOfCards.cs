using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deck52Cards
{
    class DeckOfCards
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deck of cards");
            for (int card = 2; card <= 14; card++)
            {
                switch (card)
                {
                    case 2:
                        Console.WriteLine("2♣ 2♦ 2♥ 2♠");
                        break;
                    case 3:
                        Console.WriteLine("3♣ 3♦ 3♥ 3♠");
                        break;
                    case 4:
                        Console.WriteLine("4♣ 4♦ 4♥ 4♠");
                        break;
                    case 5:
                        Console.WriteLine("5♣ 5♦ 5♥ 5♠");
                        break;
                    case 6:
                        Console.WriteLine("6♣ 6♦ 6♥ 6♠");
                        break;
                    case 7:
                        Console.WriteLine("7♣ 7♦ 7♥ 7♠");
                        break;
                    case 8:
                        Console.WriteLine("8♣ 8♦ 8♥ 8♠");
                        break;
                    case 9:
                        Console.WriteLine("9♣ 9♦ 9♥ 9♠");
                        break;
                    case 10:
                        Console.WriteLine("10♣ 10♦ 10♥ 10♠");
                        break;
                    case 11:
                        Console.WriteLine("J♣ J♦ J♥ J♠");
                        break;
                    case 12:
                        Console.WriteLine("Q♣ Q♦ Q♥ Q♠");
                        break;
                    case 13:
                        Console.WriteLine("K♣ K♦ K♥ K♠");
                        break;
                    case 14:
                        Console.WriteLine("A♣ A♦ A♥ A♠");
                        break;
                }

            }
           

        }
    }
}
