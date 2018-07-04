using System.Diagnostics.CodeAnalysis;
using ducktales.models;
using NUnit.Framework;

namespace ducktales.tests.Models {
    
    [ExcludeFromCodeCoverage]
    [TestFixture]
    public class CoinTests {
        
        private readonly Coin _firstCoin = new Coin(0.01m, 0.20m);
        private readonly Coin _secondCoin = new Coin(0.02m, 0.25m);
        private readonly Coin _thirdCoin = new Coin(0.01m, 0.50m);
        private readonly Coin _fourCoin = new Coin(0.5m, 1m);
        private readonly Coin _fiveCoin = new Coin(0.01m, 0.20m);

        [Test]
        public void CompareCoins() {
            Assert.IsFalse(_firstCoin == _secondCoin);
            Assert.IsTrue(_firstCoin != _secondCoin);
            Assert.IsTrue(_fourCoin > _thirdCoin);
            Assert.IsTrue(_secondCoin < _fourCoin);
            Assert.IsTrue(_fiveCoin >= _firstCoin);
            Assert.IsTrue(_fiveCoin <= _firstCoin);
        }

        [Test]
        public void CheckHashCode() {
            Assert.IsTrue(_firstCoin.GetHashCode() == 0);
        }
    }
}

