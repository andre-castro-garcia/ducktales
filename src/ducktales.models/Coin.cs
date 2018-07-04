// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global

using System;

namespace ducktales.models {
    
    public sealed class Coin : IComparable<Coin> {

        public Coin(decimal weight, decimal value) {
            Weight = weight;
            Value = value;
        }
        
        public decimal Weight { get; }
        
        public decimal Value { get; }
        
        public int CompareTo(Coin other) {
            var weight = Weight.CompareTo(other.Weight);
            return weight == 0 ? weight : Value.CompareTo(other.Value);
        }

        public override bool Equals(object obj) {
            if (ReferenceEquals(null, obj)) 
                return false;
            if (ReferenceEquals(this, obj)) 
                return true;

            var coin = obj as Coin;
            return coin != null && Weight.Equals(coin.Weight) && Value.Equals(coin.Value);
        }

        public override int GetHashCode() {
            return decimal.ToInt32(Weight) + decimal.ToInt32(Value);
        }

        public static bool operator == (Coin left, Coin right) {
            return left?.Equals(right) ?? ReferenceEquals(right, null);
        }
        
        public static bool operator > (Coin left, Coin right) {
            return left.CompareTo(right) > 0;
        }
        
        public static bool operator < (Coin left, Coin right) {
            return left.CompareTo(right) < 0;
        }
        
        public static bool operator != (Coin left, Coin right) {
            return !(left == right);
        }
        
        public static bool operator <= (Coin left, Coin right)
        {
            return left.CompareTo(right) <= 0;
        }
        
        public static bool operator >= (Coin left, Coin right)
        {
            return left.CompareTo(right) >= 0;
        }
    }
}