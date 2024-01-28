/*
    @app        : WinRAR Keygen
    @repo       : https://github.com/Aetherinox/WinrarKeygen
    @author     : Aetherinox
*/

#region "Using"

using System.Windows.Forms;

#endregion

/*

    Aetherx > Control > Button

    Button customization

*/

namespace WinrarKG
{

    public class AetherxButton : Button
    {

        /*
            Show keyboard cues no matter what.
            By default, user must press ALT to see them.
        */

        protected override bool ShowKeyboardCues
        {
            get
            {
                return true;
            }
        }
    }
}
