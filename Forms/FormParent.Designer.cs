using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace WinrarKG
{
    partial class FormParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        protected override bool ShowKeyboardCues => true;

        /*
            Main Form > Rectangle
        */

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen clr_border = new Pen(Color.FromArgb(75, 75, 75));
            e.Graphics.DrawRectangle(clr_border, 0, 0, Width - 1, Height - 1);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParent));
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_LicenseKey = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.mnu_Main = new System.Windows.Forms.MenuStrip();
            this.mnu_Cat_File = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Sub_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Cat_Contribute = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Cat_Help = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Sub_Updates = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Sub_Validate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Help_Sep_1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_Sub_About = new System.Windows.Forms.ToolStripMenuItem();
            this.imgHeader = new System.Windows.Forms.PictureBox();
            this.lbl_HeaderSub = new System.Windows.Forms.Label();
            this.lbl_HeaderName = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Label();
            this.btn_Minimize = new System.Windows.Forms.Label();
            this.pnl_StatusParent = new System.Windows.Forms.Panel();
            this.status_Strip = new System.Windows.Forms.StatusStrip();
            this.lbl_StatusOutput = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_Company = new WinrarKG.AetherxTextBox();
            this.btnSave = new WinrarKG.AetherxButton();
            this.txt_LicenseKey = new WinrarKG.AetherxTextBox();
            this.txt_User = new WinrarKG.AetherxTextBox();
            this.btnCopy = new WinrarKG.AetherxButton();
            this.btnGenerate = new WinrarKG.AetherxButton();
            this.mnu_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
            this.pnl_StatusParent.SuspendLayout();
            this.status_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(15, 158);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(52, 21);
            this.lbl_User.TabIndex = 0;
            this.lbl_User.Text = "Name";
            this.lbl_User.Click += new System.EventHandler(this.lbl_Serial_Sub_Click);
            // 
            // lbl_LicenseKey
            // 
            this.lbl_LicenseKey.AutoSize = true;
            this.lbl_LicenseKey.Location = new System.Drawing.Point(12, 301);
            this.lbl_LicenseKey.Name = "lbl_LicenseKey";
            this.lbl_LicenseKey.Size = new System.Drawing.Size(166, 21);
            this.lbl_LicenseKey.TabIndex = 20;
            this.lbl_LicenseKey.Text = "Generated License Key";
            this.lbl_LicenseKey.Click += new System.EventHandler(this.lbl_LicenseKey_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 28);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.aboutToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem3});
            this.aboutToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(52, 28);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // aboutToolStripMenuItem3
            // 
            this.aboutToolStripMenuItem3.Name = "aboutToolStripMenuItem3";
            this.aboutToolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem3.Text = "About";
            // 
            // lbl_Company
            // 
            this.lbl_Company.AutoSize = true;
            this.lbl_Company.Location = new System.Drawing.Point(15, 228);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(151, 21);
            this.lbl_Company.TabIndex = 3;
            this.lbl_Company.Text = "Company or License";
            // 
            // mnu_Main
            // 
            this.mnu_Main.AutoSize = false;
            this.mnu_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mnu_Main.Dock = System.Windows.Forms.DockStyle.None;
            this.mnu_Main.GripMargin = new System.Windows.Forms.Padding(12, 2, 0, 2);
            this.mnu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Cat_File,
            this.mnu_Cat_Contribute,
            this.mnu_Cat_Help});
            this.mnu_Main.Location = new System.Drawing.Point(1, 100);
            this.mnu_Main.Name = "mnu_Main";
            this.mnu_Main.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.mnu_Main.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnu_Main.Size = new System.Drawing.Size(528, 38);
            this.mnu_Main.TabIndex = 24;
            this.mnu_Main.Text = "menuStrip1";
            this.mnu_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.mnu_Main_Paint);
            // 
            // mnu_Cat_File
            // 
            this.mnu_Cat_File.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mnu_Cat_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Sub_Exit});
            this.mnu_Cat_File.ForeColor = System.Drawing.Color.White;
            this.mnu_Cat_File.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.mnu_Cat_File.Name = "mnu_Cat_File";
            this.mnu_Cat_File.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnu_Cat_File.Size = new System.Drawing.Size(53, 34);
            this.mnu_Cat_File.Text = "File";
            // 
            // mnu_Sub_Exit
            // 
            this.mnu_Sub_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mnu_Sub_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Sub_Exit.ForeColor = System.Drawing.Color.White;
            this.mnu_Sub_Exit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mnu_Sub_Exit.Name = "mnu_Sub_Exit";
            this.mnu_Sub_Exit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.mnu_Sub_Exit.Size = new System.Drawing.Size(180, 21);
            this.mnu_Sub_Exit.Text = "Exit";
            this.mnu_Sub_Exit.Click += new System.EventHandler(this.mnu_Sub_Exit_Click);
            // 
            // mnu_Cat_Contribute
            // 
            this.mnu_Cat_Contribute.ForeColor = System.Drawing.Color.White;
            this.mnu_Cat_Contribute.Name = "mnu_Cat_Contribute";
            this.mnu_Cat_Contribute.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnu_Cat_Contribute.Size = new System.Drawing.Size(92, 34);
            this.mnu_Cat_Contribute.Text = "Contribute";
            this.mnu_Cat_Contribute.Click += new System.EventHandler(this.mnu_Cat_Contribute_Click);
            // 
            // mnu_Cat_Help
            // 
            this.mnu_Cat_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Sub_Updates,
            this.mnu_Sub_Validate,
            this.mnu_Help_Sep_1,
            this.mnu_Sub_About});
            this.mnu_Cat_Help.ForeColor = System.Drawing.Color.White;
            this.mnu_Cat_Help.Name = "mnu_Cat_Help";
            this.mnu_Cat_Help.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.mnu_Cat_Help.Size = new System.Drawing.Size(60, 34);
            this.mnu_Cat_Help.Text = "Help";
            // 
            // mnu_Sub_Updates
            // 
            this.mnu_Sub_Updates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mnu_Sub_Updates.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Sub_Updates.ForeColor = System.Drawing.Color.White;
            this.mnu_Sub_Updates.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mnu_Sub_Updates.Name = "mnu_Sub_Updates";
            this.mnu_Sub_Updates.Size = new System.Drawing.Size(168, 22);
            this.mnu_Sub_Updates.Text = "Updates";
            this.mnu_Sub_Updates.Click += new System.EventHandler(this.mnu_Sub_Updates_Click);
            this.mnu_Sub_Updates.Paint += new System.Windows.Forms.PaintEventHandler(this.mnu_Sub_Updates_Paint);
            // 
            // mnu_Sub_Validate
            // 
            this.mnu_Sub_Validate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mnu_Sub_Validate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Sub_Validate.ForeColor = System.Drawing.Color.White;
            this.mnu_Sub_Validate.Name = "mnu_Sub_Validate";
            this.mnu_Sub_Validate.Size = new System.Drawing.Size(168, 22);
            this.mnu_Sub_Validate.Text = "Validate Signature";
            this.mnu_Sub_Validate.Click += new System.EventHandler(this.mnu_Sub_Validate_Click);
            // 
            // mnu_Help_Sep_1
            // 
            this.mnu_Help_Sep_1.AutoSize = false;
            this.mnu_Help_Sep_1.BackColor = System.Drawing.Color.Black;
            this.mnu_Help_Sep_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mnu_Help_Sep_1.Name = "mnu_Help_Sep_1";
            this.mnu_Help_Sep_1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.mnu_Help_Sep_1.Size = new System.Drawing.Size(165, 1);
            // 
            // mnu_Sub_About
            // 
            this.mnu_Sub_About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.mnu_Sub_About.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mnu_Sub_About.ForeColor = System.Drawing.Color.White;
            this.mnu_Sub_About.Name = "mnu_Sub_About";
            this.mnu_Sub_About.Size = new System.Drawing.Size(168, 22);
            this.mnu_Sub_About.Text = "About";
            this.mnu_Sub_About.Click += new System.EventHandler(this.mnu_Sub_About_Click);
            // 
            // imgHeader
            // 
            this.imgHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.imgHeader.BackgroundImage = global::WinrarKG.Properties.Resources.bg_header;
            this.imgHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHeader.Location = new System.Drawing.Point(1, 1);
            this.imgHeader.Name = "imgHeader";
            this.imgHeader.Size = new System.Drawing.Size(528, 129);
            this.imgHeader.TabIndex = 29;
            this.imgHeader.TabStop = false;
            this.imgHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgHeader_MouseDown);
            this.imgHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgHeader_MouseMove);
            this.imgHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgHeader_MouseUp);
            // 
            // lbl_HeaderSub
            // 
            this.lbl_HeaderSub.AutoSize = true;
            this.lbl_HeaderSub.Font = new System.Drawing.Font("Segoe UI", 9.2F);
            this.lbl_HeaderSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lbl_HeaderSub.Location = new System.Drawing.Point(24, 56);
            this.lbl_HeaderSub.Name = "lbl_HeaderSub";
            this.lbl_HeaderSub.Size = new System.Drawing.Size(51, 17);
            this.lbl_HeaderSub.TabIndex = 38;
            this.lbl_HeaderSub.Text = "Version";
            this.lbl_HeaderSub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_HeaderSub_MouseDown);
            this.lbl_HeaderSub.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_HeaderSub_MouseMove);
            this.lbl_HeaderSub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_HeaderSub_MouseUp);
            // 
            // lbl_HeaderName
            // 
            this.lbl_HeaderName.AutoSize = true;
            this.lbl_HeaderName.Font = new System.Drawing.Font("Myriad Pro Light", 20F);
            this.lbl_HeaderName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(41)))), ((int)(((byte)(101)))));
            this.lbl_HeaderName.Location = new System.Drawing.Point(21, 23);
            this.lbl_HeaderName.Name = "lbl_HeaderName";
            this.lbl_HeaderName.Size = new System.Drawing.Size(186, 32);
            this.lbl_HeaderName.TabIndex = 35;
            this.lbl_HeaderName.Text = "WinRAR Keygen";
            this.lbl_HeaderName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbl_HeaderName_MouseClick);
            this.lbl_HeaderName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbl_HeaderName_MouseDown);
            this.lbl_HeaderName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbl_HeaderName_MouseMove);
            this.lbl_HeaderName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbl_HeaderName_MouseUp);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_Close.Location = new System.Drawing.Point(490, 7);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(24, 32);
            this.btn_Close.TabIndex = 10;
            this.btn_Close.Text = "";
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Close.Click += new System.EventHandler(this.btn_Window_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Window_Close_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Window_Close_MouseLeave);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Minimize.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.Location = new System.Drawing.Point(462, 8);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(13, 32);
            this.btn_Minimize.TabIndex = 9;
            this.btn_Minimize.Text = "―";
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Window_Minimize_Click);
            this.btn_Minimize.MouseEnter += new System.EventHandler(this.btn_Window_Minimize_MouseEnter);
            this.btn_Minimize.MouseLeave += new System.EventHandler(this.btn_Window_Minimize_MouseLeave);
            // 
            // pnl_StatusParent
            // 
            this.pnl_StatusParent.BackColor = System.Drawing.Color.Transparent;
            this.pnl_StatusParent.Controls.Add(this.status_Strip);
            this.pnl_StatusParent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_StatusParent.Location = new System.Drawing.Point(0, 549);
            this.pnl_StatusParent.Name = "pnl_StatusParent";
            this.pnl_StatusParent.Padding = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.pnl_StatusParent.Size = new System.Drawing.Size(530, 31);
            this.pnl_StatusParent.TabIndex = 39;
            // 
            // status_Strip
            // 
            this.status_Strip.AutoSize = false;
            this.status_Strip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.status_Strip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.status_Strip.ForeColor = System.Drawing.Color.Red;
            this.status_Strip.GripMargin = new System.Windows.Forms.Padding(0);
            this.status_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_StatusOutput});
            this.status_Strip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.status_Strip.Location = new System.Drawing.Point(1, 0);
            this.status_Strip.Name = "status_Strip";
            this.status_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.status_Strip.Size = new System.Drawing.Size(528, 30);
            this.status_Strip.SizingGrip = false;
            this.status_Strip.TabIndex = 0;
            this.status_Strip.Text = "statusStrip1";
            // 
            // lbl_StatusOutput
            // 
            this.lbl_StatusOutput.ActiveLinkColor = System.Drawing.Color.White;
            this.lbl_StatusOutput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_StatusOutput.ForeColor = System.Drawing.Color.White;
            this.lbl_StatusOutput.LinkVisited = true;
            this.lbl_StatusOutput.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.lbl_StatusOutput.Name = "lbl_StatusOutput";
            this.lbl_StatusOutput.Size = new System.Drawing.Size(96, 25);
            this.lbl_StatusOutput.Text = "Status Output";
            // 
            // txt_Company
            // 
            this.txt_Company.AllowFocus = true;
            this.txt_Company.AutoScroll = true;
            this.txt_Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txt_Company.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.txt_Company.BorderFocusColor = System.Drawing.Color.White;
            this.txt_Company.BorderSize = 1;
            this.txt_Company.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Company.ForeColor = System.Drawing.Color.White;
            this.txt_Company.Location = new System.Drawing.Point(19, 254);
            this.txt_Company.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Company.Multiline = false;
            this.txt_Company.MultilineScrollbars = true;
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txt_Company.PasswordChar = false;
            this.txt_Company.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Company.PlaceholderText = "Unlimited Business License";
            this.txt_Company.ReadOnly = false;
            this.txt_Company.Selectable = true;
            this.txt_Company.Size = new System.Drawing.Size(494, 28);
            this.txt_Company.TabIndex = 4;
            this.txt_Company.UnderlineStyle = false;
            this.txt_Company.Value = "";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(390, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "&Save keyfile";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btn_Save_Click);
            this.btnSave.MouseEnter += new System.EventHandler(this.btnSave_MouseEnter);
            this.btnSave.MouseLeave += new System.EventHandler(this.btnSave_MouseLeave);
            // 
            // txt_LicenseKey
            // 
            this.txt_LicenseKey.AllowFocus = true;
            this.txt_LicenseKey.AutoScroll = true;
            this.txt_LicenseKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txt_LicenseKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.txt_LicenseKey.BorderFocusColor = System.Drawing.Color.White;
            this.txt_LicenseKey.BorderSize = 1;
            this.txt_LicenseKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_LicenseKey.ForeColor = System.Drawing.Color.White;
            this.txt_LicenseKey.Location = new System.Drawing.Point(19, 327);
            this.txt_LicenseKey.Margin = new System.Windows.Forms.Padding(5);
            this.txt_LicenseKey.Multiline = true;
            this.txt_LicenseKey.MultilineScrollbars = true;
            this.txt_LicenseKey.Name = "txt_LicenseKey";
            this.txt_LicenseKey.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_LicenseKey.PasswordChar = false;
            this.txt_LicenseKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_LicenseKey.PlaceholderText = "";
            this.txt_LicenseKey.ReadOnly = true;
            this.txt_LicenseKey.Selectable = true;
            this.txt_LicenseKey.Size = new System.Drawing.Size(494, 158);
            this.txt_LicenseKey.TabIndex = 5;
            this.txt_LicenseKey.UnderlineStyle = false;
            this.txt_LicenseKey.Value = "";
            // 
            // txt_User
            // 
            this.txt_User.AllowFocus = true;
            this.txt_User.AutoScroll = true;
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.txt_User.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.txt_User.BorderFocusColor = System.Drawing.Color.White;
            this.txt_User.BorderSize = 1;
            this.txt_User.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_User.ForeColor = System.Drawing.Color.White;
            this.txt_User.Location = new System.Drawing.Point(19, 184);
            this.txt_User.Margin = new System.Windows.Forms.Padding(5);
            this.txt_User.Multiline = false;
            this.txt_User.MultilineScrollbars = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txt_User.PasswordChar = false;
            this.txt_User.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_User.PlaceholderText = null;
            this.txt_User.ReadOnly = false;
            this.txt_User.Selectable = true;
            this.txt_User.Size = new System.Drawing.Size(494, 28);
            this.txt_User.TabIndex = 1;
            this.txt_User.UnderlineStyle = false;
            this.txt_User.Value = "";
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(136, 499);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(69, 29);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btn_Copy_Click);
            this.btnCopy.MouseEnter += new System.EventHandler(this.btnCopy_MouseEnter);
            this.btnCopy.MouseLeave += new System.EventHandler(this.btnCopy_MouseLeave);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(19, 499);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(111, 29);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btn_Generate_Click);
            this.btnGenerate.MouseEnter += new System.EventHandler(this.btnGenerate_MouseEnter);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(530, 580);
            this.Controls.Add(this.txt_Company);
            this.Controls.Add(this.pnl_StatusParent);
            this.Controls.Add(this.lbl_HeaderSub);
            this.Controls.Add(this.lbl_HeaderName);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.mnu_Main);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.txt_LicenseKey);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_LicenseKey);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.imgHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.FormParent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.mnu_Main.ResumeLayout(false);
            this.mnu_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
            this.pnl_StatusParent.ResumeLayout(false);
            this.status_Strip.ResumeLayout(false);
            this.status_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_User;
        private Label lbl_LicenseKey;
        private AetherxTextBox txt_User;
        private AetherxTextBox txt_LicenseKey;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem2;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem3;
        private AetherxTextBox txt_Company;
        private Label lbl_Company;
        private AetherxButton btnGenerate;
        private AetherxButton btnCopy;
        private AetherxButton btnSave;
        private MenuStrip mnu_Main;
        private ToolStripMenuItem mnu_Cat_File;
        private ToolStripMenuItem mnu_Sub_Exit;
        private ToolStripMenuItem mnu_Cat_Contribute;
        private ToolStripMenuItem mnu_Cat_Help;
        private ToolStripMenuItem mnu_Sub_Updates;
        private ToolStripMenuItem mnu_Sub_Validate;
        private ToolStripSeparator mnu_Help_Sep_1;
        private ToolStripMenuItem mnu_Sub_About;
        private PictureBox imgHeader;
        private Label lbl_HeaderSub;
        private Label lbl_HeaderName;
        private Label btn_Close;
        private Label btn_Minimize;
        private Panel pnl_StatusParent;
        private StatusStrip status_Strip;
        private ToolStripStatusLabel lbl_StatusOutput;
    }
}

