using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Plugin.TrustSDK
{
    /// <summary>
    /// Interface for $safeprojectgroupname$
    /// </summary>
    public class TrustSDKImplementation : ITrustSDK
    {
        public void SignMessage(Message message)
        {
            Debug.WriteLine("sign message ios");
        }

        public void SignTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
