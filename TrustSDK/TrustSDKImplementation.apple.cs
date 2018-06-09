using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NativeTrust = TrustSDK.TrustSDK;

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

            //var trust = new NativeTrust("trustexample");
        }

        public void SignTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
