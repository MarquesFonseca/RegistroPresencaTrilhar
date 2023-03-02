using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace Trilhar.Uteis
{
    public static class Internet
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reservedValue);

        public static bool CheckForInternetConnection()
        {
            try
            {
                int desc;
                return InternetGetConnectedState(out desc, 0);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
