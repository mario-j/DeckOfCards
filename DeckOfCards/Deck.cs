using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DeckOfCards.Enums;

namespace DeckOfCards
{
	public class Deck
	{
		public List<Card> Cards = new List<Card>();

		public Deck()
		{
			foreach (Suits suit in Enum.GetValues(typeof(Suits)))
			{
				foreach (Ranks rank in Enum.GetValues(typeof(Ranks)))
				{
					Card card = new Card(suit.ToString(), rank.ToString());
					Cards.Add(card);
				}
			}
		}

		private static Random random = new Random();
		public void Shuffle()
		{
			for (var idx = Cards.Count - 1; idx > 0; idx--)
			{
				var tempCard = Cards[idx];
				var randomIdx = random.Next(0, idx + 1);
				Cards[idx] = Cards[randomIdx];
				Cards[randomIdx] = tempCard;
			}
		}

		public Card DealOneCard()
		{
			Card cardDealt = Cards.FirstOrDefault();
			Cards = Cards.Where(card => card != cardDealt).ToList();
			return cardDealt;
		}
	}
}
