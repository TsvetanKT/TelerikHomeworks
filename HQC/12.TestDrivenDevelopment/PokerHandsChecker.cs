namespace Poker
{
    using System;
    using System.Linq;

    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool isValid = true;
            if (hand.Cards.Count != 5)
            {
                isValid = false;
            }

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face && hand.Cards[i].Suit == hand.Cards[j].Suit)
                    {
                        isValid = false;
                    }
                }
            }

            return isValid;
        }

        private bool IsFaceRepeated(IHand hand, int times)
        {
            return hand.Cards
                .GroupBy(card => card.Face)
                .Select(group => group.Count())
                .Contains(times);
        }

        private void ValidExceptionHelper(IHand hand)
        {
            if (!this.IsValidHand(hand))
            {
                throw new ArgumentException("Hand is not valid!");
            }
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool isHandValid = this.IsValidHand(hand);
            byte count = 1;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                for (int j = i + 1; j < hand.Cards.Count; j++)
                {
                    if (hand.Cards[i].Face == hand.Cards[j].Face)
                    {
                        count++;
                    }
                }

                if (count == 4)
                {
                    break;
                }

                count = 0;
            }

            bool isFourCardsFromTheSameKind = false;
            if (isHandValid == true && count == 4)
            {
                isFourCardsFromTheSameKind = true;
            }

            return isFourCardsFromTheSameKind;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            bool isHandValid = this.IsValidHand(hand);
            bool isAllCardsTheSameColor = IsAllCardsTheSameColor(hand);
            bool isAllCardsConsecutive = IsAllCardsConsecutive(hand);

            bool isFlush = false;
            if (isHandValid == true && isAllCardsTheSameColor == true &&
                isAllCardsConsecutive == false)
            {
                isFlush = true;
            }

            return isFlush;
        }

        private static bool IsAllCardsConsecutive(IHand hand)
        {
            bool isAllCardsConsecutive = true;
            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if ((int)hand.Cards[i].Face != (int)hand.Cards[i + 1].Face + 1)
                {
                    isAllCardsConsecutive = false;
                    break;
                }
            }

            return isAllCardsConsecutive;
        }

        private static bool IsAllCardsTheSameColor(IHand hand)
        {
            bool isAllCardsTheSameColor = true;

            for (int i = 0; i < hand.Cards.Count - 1; i++)
            {
                if (hand.Cards[i].Suit != hand.Cards[i + 1].Suit)
                {
                    isAllCardsTheSameColor = false;
                    break;
                }
            }

            return isAllCardsTheSameColor;
        }

        public bool IsStraight(IHand hand)
        {
            this.ValidExceptionHelper(hand);

            var uniqueFaces = hand.Cards.Select(card => card.Face).Distinct();

            bool straight = (uniqueFaces.Max() - uniqueFaces.Min()) == 4;

            if (!straight)
            {
                bool isHighestFive = uniqueFaces.Take(4).Max() == CardFace.Five;
                bool isLowestAce = uniqueFaces.Max() == CardFace.Ace;

                straight = isHighestFive && isLowestAce;
            }

            return straight;
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            this.ValidExceptionHelper(hand);

            return this.IsFaceRepeated(hand, 3);
        }

        public bool IsTwoPair(IHand hand)
        {
            this.ValidExceptionHelper(hand);

            var pairs = hand.Cards
                .GroupBy(card => card.Face)
                .Where(group => group.Count() == 2);

            return pairs.Count() == 2;
        }

        public bool IsOnePair(IHand hand)
        {
            this.ValidExceptionHelper(hand);

            return this.IsFaceRepeated(hand, 2);
        }

        public bool IsHighCard(IHand hand)
        {
            this.ValidExceptionHelper(hand);

            return true;
        }

        public int CompareHands(IHand hand1, IHand hand2)
        {
            this.ValidExceptionHelper(hand1);
            this.ValidExceptionHelper(hand2);

            throw new NotImplementedException();
        }
    }
}