using System;
using System.ComponentModel;

namespace DeckOfCards
{
	class Program
	{
		static void Main(string[] args)
		{
			Deck deck = new Deck();
			//PrintObjectProps(deck.DealOneCard());
			//deck.Shuffle();
			//PrintObjectProps(deck.DealOneCard());

			for (int i = 0; i < 55; i++)
			{
				PrintObjectProps(deck.DealOneCard());
			}
		}

		public static void PrintObjectProps(object obj)
		{
			foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
			{
				string name = descriptor.Name;
				object value = descriptor.GetValue(obj);
				Console.WriteLine("{0}={1}", name, value);
			}
		}
	}
}
