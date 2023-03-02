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
            //try
            //{
            //    using (var ping = new Ping())
            //    {
            //        var reply = ping.Send("www.google.com", 5000);
            //        return (reply.Status == IPStatus.Success);
            //    }
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
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
