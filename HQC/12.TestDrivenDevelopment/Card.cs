namespace Poker
{
    using System;

    public class Card : ICard
    {   
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public override string ToString()
        {
            string faceStr = this.GetCardFaceAsString();

            char suit = this.GetCardSuitAsString();

            string cardStr = faceStr + suit;
            return cardStr;
        }

        private char GetCardSuitAsString()
        {
            char suit;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = '♣';
                    break;
                case CardSuit.Diamonds:
                    suit = '♦';
                    break;
                case CardSuit.Hearts:
                    suit = '♥';
                    break;
                case CardSuit.Spades:
                    suit = '♠';
                    break;
                default:
                    throw new InvalidOperationException("Invalid suit " + this.Suit);
            }

            return suit;
        }

        private string GetCardFaceAsString()
        {
            string faceStr;
            if ((int)this.Face <= 10)
            {
                faceStr = ((int)this.Face).ToString();
            }
            else
            {
                faceStr = this.Face.ToString()[0].ToString();
            }

            return faceStr;
        }
    }
}