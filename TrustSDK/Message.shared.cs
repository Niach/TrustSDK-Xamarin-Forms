using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.TrustSDK
{
    public class Message
    {
        public String Value { get; }
        public bool IsPersonal { get; }

        public Message(String value) : this(value, false)
        {
        }
        public Message(String value, bool isPersonal)
        {
            Value = value;
            IsPersonal = isPersonal;
        }
    }
}
