using WinrarKG;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Lng = WinrarKG.Properties.Resources;
using Cfg = WinrarKG.Properties.Settings;
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
            variables > resource (cli exe)
        */

        static private string app_exe = Cfg.Default.app_def_exe;
        static private string app_loc = AppDomain.CurrentDomain.BaseDirectory + "\\" + app_exe;
        readonly private string app_cli = "& \"" + app_loc + "\"";

        /*
            variables > query
        */

        private string query_result;
        private string query_arg_name;
        private string query_arg_company;

        /*
            Frame > Parent
        */

        public FormParent()
        {
            InitializeComponent();
            this.statusStrip.Renderer       = new StatusBar_Renderer();

            string product                  = AppInfo.Title;
            lblTitle.Text                   = product;

            lbl_User.Text                   = Lng.lbl_generate_name;
            txt_User.PlaceholderText        = Cfg.Default.app_def_name;

            txt_Company.Text                = Lng.lbl_generate_name;
            txt_Company.PlaceholderText     = Cfg.Default.app_def_license;

            btnGenerate.Text                = Lng.btn_generate;
            btnCopy.Text                    = Lng.btn_generate_copy;
            btnSave.Text                    = Lng.btn_savekeyfile;
        }

        /*
            Frame > Parent > Load
        */

        private void FormParent_Load(object sender, EventArgs e)
        {
            mnuTop.Renderer = new ToolStripProfessionalRenderer(new mnuTop_ColorTable());
            toolStripStatusLabel1.Text = string.Format(Lng.statusbar_generate);
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
                    Lng.msgbox_noname_msg,
                    Lng.msgbox_noname_title,
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
                    string v_def_company = Cfg.Default.app_def_license;
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
                        app_cli + " " + query_arg_name + " " + query_arg_company,
                        "Sending To CLI:",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
#endif

                query_result = Serial.Generate(app_cli + " " + query_arg_name + " " + query_arg_company);

                txt_LicenseKey.Value = query_result;

                toolStripStatusLabel1.Text = string.Format(Lng.statusbar_generated);
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
                toolStripStatusLabel1.Text = string.Format(Lng.statusbar_generate_first);
                statusStrip.Refresh();
            }
            else
            {
                Clipboard.SetText(txt_LicenseKey.Value);

                toolStripStatusLabel1.Text = string.Format(
                    Lng.statusbar_license_copied
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
                    dlg.Title = Lng.dlg_save_title;
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
                                Lng.msgbox_save_msg,
                                Lng.msgbox_save_title,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.None
                            );

                            string file_path = dlg.FileName;
                            toolStripStatusLabel1.Text = string.Format(Lng.statusbar_license_saved, file_path);
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
                            Lng.msgbox_nolocnopath_msg,
                            Lng.msgbox_nolocnopath_title,
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
                            string.Format(Lng.msgbox_nolocpath_msg, path_winrar),
                            Lng.msgbox_nolocpath_title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
            else
            {
                MessageBox.Show(
                    Lng.msgbox_licempty_msg,
                    Lng.msgbox_licempty_title,
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
