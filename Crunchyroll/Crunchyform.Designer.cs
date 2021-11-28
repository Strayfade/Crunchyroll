
namespace NeuronWebdriver
{
    partial class Crunchyform
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crunchyform));
            this.siticoneGradientPanel1 = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.BackButton = new Siticone.UI.WinForms.SiticoneButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneControlBox3 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.FullscreenButton = new Siticone.UI.WinForms.SiticoneButton();
            this.RightPanel = new Siticone.UI.WinForms.SiticoneGradientPanel();
            this.HomeButton = new Siticone.UI.WinForms.SiticoneButton();
            this.SearchButton = new Siticone.UI.WinForms.SiticoneButton();
            this.ListButton = new Siticone.UI.WinForms.SiticoneButton();
            this.TooltipManager = new Siticone.UI.WinForms.SiticoneToolTip();
            this.Electron = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.siticoneGradientPanel1.SuspendLayout();
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Electron)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneGradientPanel1
            // 
            this.siticoneGradientPanel1.Controls.Add(this.TitlebarPanel);
            this.siticoneGradientPanel1.Controls.Add(this.FullscreenButton);
            this.siticoneGradientPanel1.Controls.Add(this.RightPanel);
            this.siticoneGradientPanel1.Controls.Add(this.Electron);
            this.siticoneGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticoneGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneGradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.siticoneGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.siticoneGradientPanel1.Name = "siticoneGradientPanel1";
            this.siticoneGradientPanel1.ShadowDecoration.Parent = this.siticoneGradientPanel1;
            this.siticoneGradientPanel1.Size = new System.Drawing.Size(1161, 561);
            this.siticoneGradientPanel1.TabIndex = 1;
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitlebarPanel.BackColor = System.Drawing.Color.Black;
            this.TitlebarPanel.Controls.Add(this.BackButton);
            this.TitlebarPanel.Controls.Add(this.pictureBox1);
            this.TitlebarPanel.Controls.Add(this.siticoneLabel1);
            this.TitlebarPanel.Controls.Add(this.siticoneControlBox3);
            this.TitlebarPanel.Controls.Add(this.siticoneControlBox2);
            this.TitlebarPanel.Controls.Add(this.siticoneControlBox1);
            this.TitlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(1161, 30);
            this.TitlebarPanel.TabIndex = 3;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.CheckedState.Parent = this.BackButton;
            this.BackButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.BackButton.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.BackButton.CustomImages.Parent = this.BackButton;
            this.BackButton.FillColor = System.Drawing.Color.Black;
            this.BackButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.HoveredState.Parent = this.BackButton;
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.ShadowDecoration.Parent = this.BackButton;
            this.BackButton.Size = new System.Drawing.Size(43, 24);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "";
            this.TooltipManager.SetToolTip(this.BackButton, "Search");
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::NeuronWebdriver.Properties.Resources.Crunchyroll_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(51, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(75, 4);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(72, 19);
            this.siticoneLabel1.TabIndex = 3;
            this.siticoneLabel1.Text = "Crunchyroll";
            this.siticoneLabel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveForm);
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox3.FillColor = System.Drawing.Color.Black;
            this.siticoneControlBox3.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox3.HoveredState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(1024, 0);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox3.TabIndex = 2;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1070, 0);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1116, 0);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // FullscreenButton
            // 
            this.FullscreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FullscreenButton.CheckedState.Parent = this.FullscreenButton;
            this.FullscreenButton.CustomBorderColor = System.Drawing.Color.White;
            this.FullscreenButton.CustomImages.Parent = this.FullscreenButton;
            this.FullscreenButton.FillColor = System.Drawing.Color.Black;
            this.FullscreenButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenButton.ForeColor = System.Drawing.Color.White;
            this.FullscreenButton.HoveredState.Parent = this.FullscreenButton;
            this.FullscreenButton.Location = new System.Drawing.Point(1111, 511);
            this.FullscreenButton.Name = "FullscreenButton";
            this.FullscreenButton.ShadowDecoration.Parent = this.FullscreenButton;
            this.FullscreenButton.Size = new System.Drawing.Size(50, 50);
            this.FullscreenButton.TabIndex = 2;
            this.FullscreenButton.Text = "";
            this.TooltipManager.SetToolTip(this.FullscreenButton, "Fullscreen");
            this.FullscreenButton.Click += new System.EventHandler(this.FullscreenButton_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightPanel.BackColor = System.Drawing.Color.Black;
            this.RightPanel.BorderColor = System.Drawing.Color.White;
            this.RightPanel.Controls.Add(this.HomeButton);
            this.RightPanel.Controls.Add(this.SearchButton);
            this.RightPanel.Controls.Add(this.ListButton);
            this.RightPanel.CustomBorderColor = System.Drawing.Color.White;
            this.RightPanel.Location = new System.Drawing.Point(1111, 28);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShadowDecoration.Parent = this.RightPanel;
            this.RightPanel.Size = new System.Drawing.Size(50, 484);
            this.RightPanel.TabIndex = 1;
            // 
            // HomeButton
            // 
            this.HomeButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeButton.CheckedState.Parent = this.HomeButton;
            this.HomeButton.CustomImages.Parent = this.HomeButton;
            this.HomeButton.FillColor = System.Drawing.Color.Black;
            this.HomeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.HoveredState.Parent = this.HomeButton;
            this.HomeButton.Location = new System.Drawing.Point(3, 1);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.ShadowDecoration.Parent = this.HomeButton;
            this.HomeButton.Size = new System.Drawing.Size(43, 50);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.Text = "";
            this.TooltipManager.SetToolTip(this.HomeButton, "Homepage");
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchButton.CheckedState.Parent = this.SearchButton;
            this.SearchButton.CustomImages.Parent = this.SearchButton;
            this.SearchButton.FillColor = System.Drawing.Color.Black;
            this.SearchButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.ForeColor = System.Drawing.Color.White;
            this.SearchButton.HoveredState.Parent = this.SearchButton;
            this.SearchButton.Location = new System.Drawing.Point(3, 113);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.ShadowDecoration.Parent = this.SearchButton;
            this.SearchButton.Size = new System.Drawing.Size(43, 50);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "";
            this.TooltipManager.SetToolTip(this.SearchButton, "Search");
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ListButton
            // 
            this.ListButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListButton.CheckedState.Parent = this.ListButton;
            this.ListButton.CustomImages.Parent = this.ListButton;
            this.ListButton.FillColor = System.Drawing.Color.Black;
            this.ListButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListButton.ForeColor = System.Drawing.Color.White;
            this.ListButton.HoveredState.Parent = this.ListButton;
            this.ListButton.Location = new System.Drawing.Point(3, 57);
            this.ListButton.Name = "ListButton";
            this.ListButton.ShadowDecoration.Parent = this.ListButton;
            this.ListButton.Size = new System.Drawing.Size(43, 50);
            this.ListButton.TabIndex = 0;
            this.ListButton.Text = "";
            this.TooltipManager.SetToolTip(this.ListButton, "Watchlist");
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // TooltipManager
            // 
            this.TooltipManager.AllowLinksHandling = true;
            this.TooltipManager.BackColor = System.Drawing.Color.Black;
            this.TooltipManager.BorderColor = System.Drawing.Color.DarkGray;
            this.TooltipManager.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // Electron
            // 
            this.Electron.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Electron.CreationProperties = null;
            this.Electron.DefaultBackgroundColor = System.Drawing.Color.White;
            this.Electron.Location = new System.Drawing.Point(3, 31);
            this.Electron.Name = "Electron";
            this.Electron.Size = new System.Drawing.Size(1115, 527);
            this.Electron.TabIndex = 4;
            this.Electron.ZoomFactor = 1D;
            // 
            // Crunchyform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(1161, 561);
            this.Controls.Add(this.siticoneGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crunchyform";
            this.Text = "Crunchyroll";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.siticoneGradientPanel1.ResumeLayout(false);
            this.TitlebarPanel.ResumeLayout(false);
            this.TitlebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Electron)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneGradientPanel siticoneGradientPanel1;
        private Siticone.UI.WinForms.SiticoneGradientPanel RightPanel;
        private Siticone.UI.WinForms.SiticoneButton ListButton;
        private Siticone.UI.WinForms.SiticoneButton SearchButton;
        private Siticone.UI.WinForms.SiticoneButton FullscreenButton;
        private Siticone.UI.WinForms.SiticoneButton HomeButton;
        private Siticone.UI.WinForms.SiticoneToolTip TooltipManager;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneButton BackButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 Electron;
    }
}

