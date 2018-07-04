﻿// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable ClassNeverInstantiated.Global

using System;

namespace ducktales.models {
    
    public sealed class Coin : IComparable<Coin>, IEquatable<Coin> {
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

        public bool Equals(Coin other) {
            return Weight.Equals(other.Weight) && Value.Equals(other.Value);
        }
        
        public static bool operator == (Coin left, Coin right) {
            return left?.Equals(right) ?? ReferenceEquals(right, null);
        }
        public static bool operator > (Coin left, Coin right)
        {
            return left.CompareTo(right) > 0;
        }
        public static bool operator < (Coin left, Coin right)
        {
            return left.CompareTo(right) < 0;
        }
        public static bool operator != (Coin left, Coin right)
        {
            return !(left == right);
        }
    }
}