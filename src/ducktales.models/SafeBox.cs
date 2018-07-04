using System;
using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnusedMember.Global

namespace ducktales.models {
    
    public sealed class SafeBox : IEquatable<SafeBox> {
        
        public SafeBox(List<Coin> coins) {
            Coins = coins;
        }       
        
        public List<Coin> Coins { get; }

        public bool Equals(SafeBox other) {
            var totalCoins = Coins.Count;
            var otherTotalCoins = other.Coins.Count;
            
            if (totalCoins != otherTotalCoins) {
                return false;
            }

            var equals = true;
            Coins.Sort();
            other.Coins.Sort();
            
            for (var i = 0; i < Coins.Count; i++) {
                var coin = Coins[i];
                var otherCoin = other.Coins[i];

                if (coin.Equals(otherCoin)) 
                    continue;
                
                equals = false;
                break;
            }

            return equals;
        }
    }
}