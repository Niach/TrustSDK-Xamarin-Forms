using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.TrustSDK
{
    public interface ITrustSDK
    {
        void SignMessage(Message message);
        void SignTransaction();
    }
   
}
