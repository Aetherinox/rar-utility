using WinrarKG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;
using Lng = WinrarKG.Properties.Resources;
using Cfg = WinrarKG.Properties.Settings;

namespace WinrarKG
{

    public partial class FormAbout : Form
    {

        public string GetReadme(string product, string version, string developer)
        {

            string pattern =
@"{0}
Version {1}
{2}

This is for educational purposes only. I hold no responsibility for people doing bad things with it.

If you wish to view the source code, click the Github link above.

The keygen is free for anyone to use. I try to make stuff that isn't like the typical keygens out there. No loud annoying ass music, no ads, no weird color schemes that question if you're under the influence of shrooms.

INSTRUCTIONS
   - Provide a name and company or license name.
   - Click Generate and a new key will be created.
   - Copy generated key and paste into a rarreg.key file
     OR
     Click the save button and save the generated key file
     to your WinRAR installation directory.
   - Restart WinRAR if running.
";

            return string.Format(pattern, product, version, developer);
        }

        public FormAbout( )
        {
            InitializeComponent( );

            string ver          = AppInfo.ProductVersionCore.ToString();
            string product      = AppInfo.Title;
            string tm           = AppInfo.Trademark;

            txt_Version.Text    = "v" + ver + " by " + tm;
            lbl_Product.Text    = product;

            txt_Terms.Value     = GetReadme(product, ver, tm);
            txt_Terms.Text      = GetReadme(product, ver, tm);

            lbl_Edu.Text        = Lng.about_hdr_desc;
            lnk_TPBLink.Text    = Lng.about_lnk_tpb;
            lnk_Github.Text     = Lng.about_lnk_github;

            lbl_Dev_PIV_Thumbprint.Text         = Lng.about_lbl_thumbprint;
            lbl_Dev_GPG_KeyID.Text              = Lng.about_lbl_gpg;

            txt_Dev_PIV_Thumbprint.Value        = Cfg.Default.app_dev_piv_thumbprint;
            txt_Dev_GPG_KeyID.Value             = Cfg.Default.app_dev_gpg_keyid;
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {

        }

        /*
             Main Form > Mouse Down
             deals with moving form around on screen
         */

        private bool mouseDown;
        private Point lastLocation;

        private void FormAbout_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        /*
            Main Form > Mouse Up
            deals with moving form around on screen
        */

        private void FormAbout_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /*
            Main Form > Mouse Move
            deals with moving form around on screen
        */

        private void FormAbout_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        /*
            Window > Button > Close
        */

        private void btn_Window_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
            Window > Button > Close > Mouse Enter
        */

        private void btn_Window_Close_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.FromArgb(222, 31, 100);
        }

        /*
            Window > Button > Close > Mouse Leave
        */

        private void btn_Window_Close_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        /*
            Window > Button > Label > Click
        */

        private void lbl_Serial_Click(object sender, EventArgs e)
        {

        }

        /*
            Window > Logo
        */

        private void mat_Logo_Click(object sender, EventArgs e)
        {

        }

        /*
            Window > Button > Close
        */

        private void llblLink_TPB_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Cfg.Default.app_url_tpb);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Product_Click(object sender, EventArgs e)
        {

        }

        private void txt_Terms_Load(object sender, EventArgs e)
        {

        }

        private void lnk_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Cfg.Default.app_url_github);
        }

        private void txt_Terms__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
