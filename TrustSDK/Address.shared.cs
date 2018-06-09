using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.TrustSDK
{
    public class Address
    {
        public static readonly Address EMPTY = new Address("0000000000000000000000000000000000000000");

        public String Value { get; }

        public Address(String value)
        {
            value = value.ToLower();
            if (value.StartsWith("0x"))
            {
                value = value.Replace("0x", "");
            }
            if (String.Empty == value)
            {
                throw new ArgumentException("Address can't be empty");
            }
            Value = value;
        }

        public override string ToString()
        {
            return "0x" + Value;
        }
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj is Address && Value == (obj as Address).Value;
        }
    }
}
