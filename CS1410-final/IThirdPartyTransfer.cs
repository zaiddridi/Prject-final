using System;
using System.Collections.Generic;
using System.Text;

namespace CS1410_final
{
    public interface IThirdPartyTransfer
    {
        void PerformThirdPartyTransfer(BankAccount bankAccount, VMThirdPartyTransfer vmThirdPartyTransfer);
    }
}
