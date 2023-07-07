using WinrarKG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Windows;
using static WinrarKG.FormParent;

namespace WinrarKG
{
    public partial class FormParent : Form
    {

        /*
            Classes
        */

        private Serial Serial = new Serial();
        private Helpers Helpers = new Helpers();

        /*
            Variables
        */

        static private string lib_path = ConfigurationManager.AppSettings["libs_default"];
        static private string app_loc = AppDomain.CurrentDomain.BaseDirectory + "\\" + lib_path + "\\winrarkg_cli.exe";
        static private string ps_cmd = "& \"" + app_loc + "\"";
 
        private string query_result;
        private string query_arg_name;
        private string query_arg_company;

        /*
            Frame > Parent
        */

        public FormParent()
        {
            InitializeComponent();
            this.statusStrip.Renderer = new StatusBar_Renderer();

            string product = AppInfo.Title;
            lblTitle.Text = product;

            this.txt_User.PlaceholderText = ConfigurationManager.AppSettings["username_default"];
            this.txt_Company.PlaceholderText = ConfigurationManager.AppSettings["company_default"];

            if (!File.Exists(app_loc))
            {

                MessageBox.Show(
                    "Cannot locate a required library file:\n" + app_loc + "\n\nAdd the missing library file and restart the program.",
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                toolStripStatusLabel1.Text = string.Format("Fatal Error: Can't find " + app_loc);
                statusStrip.Refresh();

            }

        }

        /*
            Frame > Parent > Load
        */

        private void FormParent_Load(object sender, EventArgs e)
        {
            mnuTop.Renderer = new ToolStripProfessionalRenderer(new mnuTop_ColorTable());
            toolStripStatusLabel1.Text = string.Format("Press Generate to create license key ...");
            statusStrip.Refresh();
        }

        /*
            Window > Button > Minimize > Click
        */

        private void btn_Window_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /*
            Window > Button > Minimize > Mouse Enter
        */

        private void btn_Window_Minimize_MouseEnter(object sender, EventArgs e)
        {
            minimizeBtn.ForeColor = Color.FromArgb(222, 31, 100);
        }

        /*
            Window > Button > Minimize > Mouse Leave
        */

        private void btn_Window_Minimize_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.ForeColor = Color.FromArgb(255, 255, 255);
        }

        /*
            Window > Button > Close > Click
        */

        private void btn_Window_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            button > Generate > OnClick
        */

        private void btn_Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_User.Value))
            {
                MessageBox.Show(
                    "Type a name before you attempt to generate a license key",
                    "No name specified",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                txt_LicenseKey.isPlaceholder = false;

                /*
                    License Value > User name

                    clean up / allow spaces
                */

                query_arg_name = "\"" + txt_User.Value + "\"";

                /*
                    License Value > Company name

                    fetch company name, check for null -> apply default value
                */

                query_arg_company = txt_Company.Value;

                if (string.IsNullOrEmpty(query_arg_company))
                {
                    string v_def_company = ConfigurationManager.AppSettings["company_default"];
                    query_arg_company = v_def_company;
                }

                /*
                    add quotes to company name for CLI to handle spaces.
                */

                query_arg_company = "\"" + query_arg_company + "\"";

                /*
                    DEBUG MODE: 
                        Confirm entered values
                */

#if DEBUG
                    System.Windows.Forms.MessageBox.Show(
                        ps_cmd + " " + query_arg_name + " " + query_arg_company,
                        "Sending To CLI:",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
#endif

                query_result = Serial.Generate(ps_cmd + " " + query_arg_name + " " + query_arg_company);

                txt_LicenseKey.Value = query_result;

                toolStripStatusLabel1.Text = string.Format("License key generated. Paste into WinRAR app.");
                statusStrip.Refresh();
            }
        }

        /*
             Button > Copy generated license key
        */

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(txt_LicenseKey.Value);

            if (string.IsNullOrEmpty(txt_LicenseKey.Value))
            {
                toolStripStatusLabel1.Text = string.Format("Generate license key first");
                statusStrip.Refresh();
            }
            else
            {
                Clipboard.SetText(txt_LicenseKey.Value);

                toolStripStatusLabel1.Text = string.Format(
                    "License key copied. Paste into rarreg.key"
                );
                statusStrip.Refresh();
            }
        }

        /*
            Main Form > Mouse Down
            deals with moving form around on screen
        */

        private bool mouseDown;
        private Point lastLocation;

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        /*
            Main Form > Mouse Up
            deals with moving form around on screen
        */

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /*
            Main Form > Mouse Move
            deals with moving form around on screen
        */

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y
                );

                this.Update();
            }
        }

        /*
            Label > Window Title
        */

        private void lbl_Title_Click(object sender, EventArgs e) { }

        /*
            Top Menu > File > Exit
        */

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*
            Top Menu > Help > About
        */

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAbout to = new FormAbout();
            to.TopMost = true;
            to.Show();
        }

        /*
            Top Menu > Click Item
        */

        private void mnuTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        /*
            Status Bar > Color Table
        */

        public class ClrTable : ProfessionalColorTable
        {
            public override Color StatusStripGradientBegin => Color.FromArgb(35, 35, 35);
            public override Color StatusStripGradientEnd => Color.FromArgb(35, 35, 35);
        }

        /*
            Status Bar > Renderer
            Override colors
        */

        public class StatusBar_Renderer : ToolStripProfessionalRenderer
        {
            public StatusBar_Renderer()
                : base(new ClrTable()) { }

            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
            {
                if (!(e.ToolStrip is StatusStrip))
                    base.OnRenderToolStripBorder(e);
            }
        }

        /*
            Top Menu > Override Render Colors
        */

        public class mnuTop_ColorTable : ProfessionalColorTable
        {
            /*
                Gets the starting color of the gradient used when
                a top-level System.Windows.Forms.ToolStripMenuItem is pressed.
            */

            public override Color MenuItemPressedGradientBegin => Color.FromArgb(55, 55, 55);

            /*
                Gets the end color of the gradient used when a top-level
                System.Windows.Forms.ToolStripMenuItem is pressed.
            */

            public override Color MenuItemPressedGradientEnd => Color.FromArgb(55, 55, 55);

            /*
                Gets the border color to use with a
                System.Windows.Forms.ToolStripMenuItem.
            */

            public override Color MenuItemBorder => Color.FromArgb(0, 45, 45, 45);

            /*
                Gets the starting color of the gradient used when the
                System.Windows.Forms.ToolStripMenuItem is selected.
            */

            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(222, 31, 103);

            /*
                Gets the end color of the gradient used when the
                System.Windows.Forms.ToolStripMenuItem is selected.
            */

            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(222, 31, 103);

            /*
                Gets the solid background color of the
                System.Windows.Forms.ToolStripDropDown.
            */

            public override Color ToolStripDropDownBackground => Color.FromArgb(40, 40, 40);

            /*
                Top Menu > Image > Start Gradient Color
            */

            public override Color ImageMarginGradientBegin => Color.FromArgb(222, 31, 103);

            /*
                Top Menu > Image > Middle Gradient Color
            */

            public override Color ImageMarginGradientMiddle => Color.FromArgb(222, 31, 103);

            /*
                Top Menu > Image > End Gradient Color
            */

            public override Color ImageMarginGradientEnd => Color.FromArgb(222, 31, 103);

            /*
                Top Menu > Shadow Effect
            */

            public override Color SeparatorDark => Color.FromArgb(0, 45, 45, 45);

            /*
                Top Menu > Border Color
            */

            public override Color MenuBorder => Color.FromArgb(0, 45, 45, 45);

            /*
                 Top Menu > Item Hover BG Color
             */

            public override Color MenuItemSelected => Color.FromArgb(222, 31, 103);
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        /*
            Label > Sub Header
                "Generated License key"
        */

        private void lbl_Serial_Sub_Click(object sender, EventArgs e) { }

        /*
            Label > Body
                "Click the "Generate" button below to create a number number."
        */

        private void lbl_LicenseKey_Click(object sender, EventArgs e) { }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txt_LicenseKey.Value))
            {
                string path_winrar = Helpers.FindApp("WinRAR.exe");

                /*
                    WinRAR found
                */

                if (Directory.Exists(path_winrar))
                {
                    SaveFileDialog dlg = new SaveFileDialog();

                    dlg.FileName = "rarreg";
                    dlg.Title = "Save WinRAR License Key";
                    dlg.CheckPathExists = true;
                    dlg.InitialDirectory = path_winrar;
                    dlg.DefaultExt = "key";
                    dlg.Filter = @"Key File (*.key)|*.key|All files (*.*)|*.*";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(dlg.FileName))
                        {
                            foreach (string line in txt_LicenseKey.Lines)
                            {
                                sw.WriteLine(line);
                            }

                            MessageBox.Show(
                                "Successfully saved rarreg.key.\nRestart WinRAR for license to apply.",
                                "Keygen Installed Successfully",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.None
                            );

                            string file_path = dlg.FileName;
                            toolStripStatusLabel1.Text = string.Format(
                                "Saved license key to " + file_path
                            );

                            statusStrip.Refresh();
                        }
                    }
                }
                else
                {

                    if (string.IsNullOrEmpty(path_winrar))
                    {
                        /*
                            WinRAR not found > empty path
                        */

                        MessageBox.Show(
                            "Keygen cannot determine where WinRAR is installed.\n\nCopy the generated key and place it inside a file labeled rarreg.key.\n\nThen place the file in your WinRAR folder.",
                            "Cannot find WinRAR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                    else
                    {

                        /*
                            WinRAR not found > path tried but unsuccessful
                        */

                        MessageBox.Show(
                            "Keygen cannot determine where WinRAR is installed\nTried looking in " + path_winrar + ".\n\nCopy the generated key and place it inside a file labeled rarreg.key\n\nThen place the file in your WinRAR folder.",
                            "Cannot find WinRAR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    "Can't save an empty WinRAR keyfile.\n\nEnter a valid name & company / license name; then click \"Generate\"",
                    "No Generated Response",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void txt_User__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
