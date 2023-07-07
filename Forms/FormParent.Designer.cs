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
            this.minimizeBtn = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_LicenseKey = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_Company = new System.Windows.Forms.Label();
            this.btnSave = new WinrarKG.AetherxButton();
            this.txt_Company = new WinrarKG.AetherxTextBox();
            this.txt_LicenseKey = new WinrarKG.AetherxTextBox();
            this.txt_User = new WinrarKG.AetherxTextBox();
            this.btnCopy = new WinrarKG.AetherxButton();
            this.btnGenerate = new WinrarKG.AetherxButton();
            this.mnuTop.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.Location = new System.Drawing.Point(469, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(13, 32);
            this.minimizeBtn.TabIndex = 8;
            this.minimizeBtn.Text = "―";
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minimizeBtn.Click += new System.EventHandler(this.btn_Window_Minimize_Click);
            this.minimizeBtn.MouseEnter += new System.EventHandler(this.btn_Window_Minimize_MouseEnter);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.btn_Window_Minimize_MouseLeave);
            // 
            // closeBtn
            // 
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.closeBtn.Location = new System.Drawing.Point(494, 7);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(24, 32);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Click += new System.EventHandler(this.btn_Window_Close_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.btn_Window_Close_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.btn_Window_Close_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.lblTitle.Location = new System.Drawing.Point(14, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(267, 30);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "WinRAR License Generator";
            this.lblTitle.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(12, 99);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(52, 21);
            this.lbl_User.TabIndex = 6;
            this.lbl_User.Text = "Name";
            this.lbl_User.Click += new System.EventHandler(this.lbl_Serial_Sub_Click);
            // 
            // mnuTop
            // 
            this.mnuTop.AutoSize = false;
            this.mnuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mnuTop.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuTop.GripMargin = new System.Windows.Forms.Padding(12, 2, 0, 2);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(1, 46);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.mnuTop.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuTop.Size = new System.Drawing.Size(528, 32);
            this.mnuTop.TabIndex = 1;
            this.mnuTop.Text = "menuStrip1";
            this.mnuTop.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuTop_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 28);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ForeColor = System.Drawing.Color.Red;
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip.Location = new System.Drawing.Point(1, 494);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip.Size = new System.Drawing.Size(528, 28);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.LinkVisited = true;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(139, 19);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // lbl_LicenseKey
            // 
            this.lbl_LicenseKey.AutoSize = true;
            this.lbl_LicenseKey.Location = new System.Drawing.Point(12, 242);
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
            this.lbl_Company.Location = new System.Drawing.Point(12, 169);
            this.lbl_Company.Name = "lbl_Company";
            this.lbl_Company.Size = new System.Drawing.Size(151, 21);
            this.lbl_Company.TabIndex = 23;
            this.lbl_Company.Text = "Company or License";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(390, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save keyfile";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txt_Company
            // 
            this.txt_Company.AutoScroll = true;
            this.txt_Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txt_Company.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.txt_Company.BorderFocusColor = System.Drawing.Color.White;
            this.txt_Company.BorderSize = 1;
            this.txt_Company.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_Company.ForeColor = System.Drawing.Color.White;
            this.txt_Company.Location = new System.Drawing.Point(19, 195);
            this.txt_Company.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Company.Multiline = false;
            this.txt_Company.Name = "txt_Company";
            this.txt_Company.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txt_Company.PasswordChar = false;
            this.txt_Company.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_Company.PlaceholderText = "Unlimited Business License";
            this.txt_Company.ReadOnly = false;
            this.txt_Company.Size = new System.Drawing.Size(494, 28);
            this.txt_Company.TabIndex = 3;
            this.txt_Company.UnderlineStyle = false;
            this.txt_Company.Value = "";
            // 
            // txt_LicenseKey
            // 
            this.txt_LicenseKey.AutoScroll = true;
            this.txt_LicenseKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txt_LicenseKey.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.txt_LicenseKey.BorderFocusColor = System.Drawing.Color.White;
            this.txt_LicenseKey.BorderSize = 1;
            this.txt_LicenseKey.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_LicenseKey.ForeColor = System.Drawing.Color.White;
            this.txt_LicenseKey.Location = new System.Drawing.Point(19, 268);
            this.txt_LicenseKey.Margin = new System.Windows.Forms.Padding(5);
            this.txt_LicenseKey.Multiline = true;
            this.txt_LicenseKey.Name = "txt_LicenseKey";
            this.txt_LicenseKey.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txt_LicenseKey.PasswordChar = false;
            this.txt_LicenseKey.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_LicenseKey.PlaceholderText = "";
            this.txt_LicenseKey.ReadOnly = true;
            this.txt_LicenseKey.Size = new System.Drawing.Size(494, 158);
            this.txt_LicenseKey.TabIndex = 4;
            this.txt_LicenseKey.UnderlineStyle = false;
            this.txt_LicenseKey.Value = "";
            // 
            // txt_User
            // 
            this.txt_User.AutoScroll = true;
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.txt_User.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.txt_User.BorderFocusColor = System.Drawing.Color.White;
            this.txt_User.BorderSize = 1;
            this.txt_User.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_User.ForeColor = System.Drawing.Color.White;
            this.txt_User.Location = new System.Drawing.Point(19, 125);
            this.txt_User.Margin = new System.Windows.Forms.Padding(5);
            this.txt_User.Multiline = false;
            this.txt_User.Name = "txt_User";
            this.txt_User.Padding = new System.Windows.Forms.Padding(8, 3, 8, 3);
            this.txt_User.PasswordChar = false;
            this.txt_User.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_User.PlaceholderText = null;
            this.txt_User.ReadOnly = false;
            this.txt_User.Size = new System.Drawing.Size(494, 28);
            this.txt_User.TabIndex = 2;
            this.txt_User.UnderlineStyle = false;
            this.txt_User.Value = "";
            this.txt_User._TextChanged += new System.EventHandler(this.txt_User__TextChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(136, 440);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(69, 29);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "&Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btn_Copy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(6)))), ((int)(((byte)(85)))));
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(19, 440);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(111, 29);
            this.btnGenerate.TabIndex = 5;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(530, 525);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txt_Company);
            this.Controls.Add(this.lbl_Company);
            this.Controls.Add(this.txt_LicenseKey);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_LicenseKey);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.mnuTop);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuTop;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormParent";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.Load += new System.EventHandler(this.FormParent_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimizeBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
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
    }
}

