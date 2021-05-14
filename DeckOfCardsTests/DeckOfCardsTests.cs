using NUnit.Framework;
using DeckOfCards;
using DeckOfCards.Enums;
using System.Collections.Generic;
using System;
using System.Linq;

namespace DeckOfCardsTests
{
	[TestFixture]
	public class DeckOfCardsTests
	{
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void DealOneCard()
		{
			var deck = new Deck();

			var listOfExpectedValues = deck.Cards;

			var actualValue = deck.DealOneCard();

			Assert.IsNotNull(listOfExpectedValues.Where(card => card == actualValue).Count() == 1);
		}

		[Test]
		public void DealOneCardWithEmptyDeck()
		{
			var deck = new Deck();
				
			//Empty the deck of cards
			foreach (var card in deck.Cards)
			{
				deck.DealOneCard();
			}

			//Deal a card after the deck is empty
			var actualValue = deck.DealOneCard();

			Assert.IsNull(actualValue);
		}

		[Test]
		public void ShuffleAndDealOneCard()
		{
			var deck = new Deck();
			deck.Shuffle();

			var listOfExpectedValues = deck.Cards;

			var actualValue = deck.DealOneCard();

			Assert.IsNotNull(listOfExpectedValues.Where(card => card == actualValue).Count() == 1);
		}

		[Test]
		public void ShuffleAndEnsureDealtCardsMatchOriginalDeck()
		{
			var deck = new Deck();

			var listOfExpectedValues = deck.Cards;

			deck.Shuffle();

			List<Card> actualValues = new List<Card>() { };
			foreach (var card in deck.Cards)
			{
				actualValues.Add(card);
			}

			actualValues = actualValues.OrderBy(property => property.Rank).OrderBy(property => property.Suit).ToList();
			listOfExpectedValues = listOfExpectedValues.OrderBy(property => property.Rank).OrderBy(property => property.Suit).ToList();

			Assert.AreEqual(listOfExpectedValues, actualValues);
		}
	}
}