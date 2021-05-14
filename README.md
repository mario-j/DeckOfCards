# DeckOfCards

A .Net Core Console App functioning as a rudimentary deck of cards.

## Running Locally

To run locally clone this repository onto your local machine and open the solution with your favorite editor. 

## Classes and Functions

### Deck
 - Properties
   - Cards 
     - A list of 52 unique cards created by permutating through the Ranks and Suits Enums
 - Functions
   - Shuffle() : void
     - Shuffles all of the Cards randomly
   - DealOneCard() : Card
     - Returns the first card in the Deck 

### Card
  - Properties
    - Suit 
      - One of the 4 suits found in the Suits Enum
    - Rank 
      - One of the 13 ranks found in the Ranks Enum

## Testing

Unit tests have been declared in the DeckOfCardsTests.cs class of the DeckOfCardsTests project. To run tests run ```dotnet test``` 

## Current State of the App

Running the DeckOfCards console app executes the Main function in the Program.cs file.

Currently this function declares a new deck of cards, shuffles the deck, and deals all of the cards in the deck. Each dealt card is printed to the console.
