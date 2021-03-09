using CodingChallenge.CardGame;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallengUnitTest
{
    [TestFixture]
    public class CardGameUnitTest
    {
        private PackOfCardsCreator cardsCreator;

        [SetUp]
        public void Setup()
        {
            cardsCreator = new PackOfCardsCreator();
        }

        [Test]
        public void Test_Card_Create()
        {
            var actualPack = cardsCreator.Create();
            var expectedPack = CreateMockCards();
            CollectionAssert.AreEquivalent(expectedPack, actualPack);
        }

        [Test]
        public void Test_Card_Shuffle()
        {
            var actualPack = cardsCreator.Create();
            actualPack.Shuffle();
            var expectedPack = CreateMockCards();
            CollectionAssert.AreEquivalent(expectedPack, actualPack);
            Assert.IsFalse(expectedPack.SequenceEqual(actualPack));
        }

        [Test]
        public void Test_Card_TakeCardFromTopOfPack()
        {
            var currentCards = cardsCreator.Create().GetEnumerator();
            currentCards.MoveNext();
            var topCards = currentCards.Current;
            Assert.AreEqual(CreateMockCards()[0], topCards);
        }

        private IList<ICard> CreateMockCards()
        {
            return new List<ICard>
            {
                new Card(Suit.Clubs,Value.Ace ),
                new Card(Suit.Clubs,Value.Two),
                new Card(Suit.Clubs,Value.Three),
                new Card(Suit.Clubs,Value.Four),
                new Card(Suit.Clubs,Value.Five),
                new Card(Suit.Clubs,Value.Six),
                new Card(Suit.Clubs,Value.Seven),
                new Card(Suit.Clubs,Value.Eight),
                new Card(Suit.Clubs,Value.Nine),
                new Card(Suit.Clubs,Value.Ten),
                new Card(Suit.Clubs,Value.Jack),
                new Card(Suit.Clubs,Value.Queen),
                new Card(Suit.Clubs,Value.King),

                new Card(Suit.Diamonds,Value.Ace ),
                new Card(Suit.Diamonds,Value.Two),
                new Card(Suit.Diamonds,Value.Three),
                new Card(Suit.Diamonds,Value.Four),
                new Card(Suit.Diamonds,Value.Five),
                new Card(Suit.Diamonds,Value.Six),
                new Card(Suit.Diamonds,Value.Seven),
                new Card(Suit.Diamonds,Value.Eight),
                new Card(Suit.Diamonds,Value.Nine),
                new Card(Suit.Diamonds,Value.Ten),
                new Card(Suit.Diamonds,Value.Jack),
                new Card(Suit.Diamonds,Value.Queen),
                new Card(Suit.Diamonds,Value.King),

                new Card(Suit.Hearts,Value.Ace ),
                new Card(Suit.Hearts,Value.Two),
                new Card(Suit.Hearts,Value.Three),
                new Card(Suit.Hearts,Value.Four),
                new Card(Suit.Hearts,Value.Five),
                new Card(Suit.Hearts,Value.Six),
                new Card(Suit.Hearts,Value.Seven),
                new Card(Suit.Hearts,Value.Eight),
                new Card(Suit.Hearts,Value.Nine),
                new Card(Suit.Hearts,Value.Ten),
                new Card(Suit.Hearts,Value.Jack),
                new Card(Suit.Hearts,Value.Queen),
                new Card(Suit.Hearts,Value.King),

                new Card(Suit.Spades,Value.Ace ),
                new Card(Suit.Spades,Value.Two),
                new Card(Suit.Spades,Value.Three),
                new Card(Suit.Spades,Value.Four),
                new Card(Suit.Spades,Value.Five),
                new Card(Suit.Spades,Value.Six),
                new Card(Suit.Spades,Value.Seven),
                new Card(Suit.Spades,Value.Eight),
                new Card(Suit.Spades,Value.Nine),
                new Card(Suit.Spades,Value.Ten),
                new Card(Suit.Spades,Value.Jack),
                new Card(Suit.Spades,Value.Queen),
                new Card(Suit.Spades,Value.King),
            };
        }
    }
}
