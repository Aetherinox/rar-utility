/*
    @app        : WinRAR Keygen
    @repo       : https://github.com/Aetherinox/WinrarKeygen
    @author     : Aetherinox
*/

#region "Using"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Res = WinrarKG.Properties.Resources;
using Cfg = WinrarKG.Properties.Settings;

#endregion

namespace WinrarKG
{

    /*
        OReceiver > Status Bar
    */

    public interface IReceiver
    {
        void Status( string message );
    }

    /*
        Receiver > Status Bar
    */

    public static class StatusBar
    {
        private static IReceiver recv = null;

        /*
            Receiver > Initialize
        */

        public static void InitializeReceiver( IReceiver f )
        {
            recv = f;
        }

        /*
            Receiver > Send Message
        */

        public static void Update( string message )
        {
            if ( recv != null ) recv.Status( message );
        }
    }
}
