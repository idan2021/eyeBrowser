
namespace eyeBrowser
{
    partial class AppContainer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppContainer));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.loader = new Bunifu.UI.WinForms.BunifuLoader();
            this.iconSec = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.urlTxt = new System.Windows.Forms.TextBox();
            this.backBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.navBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.refreshBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.homeBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.forwardBtn = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.bunifuCards1.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardBtn)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCards1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.bunifuPanel1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(801, 55);
            this.bunifuCards1.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Silver;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 20;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.loader);
            this.bunifuPanel1.Controls.Add(this.iconSec);
            this.bunifuPanel1.Controls.Add(this.urlTxt);
            this.bunifuPanel1.Location = new System.Drawing.Point(180, 12);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(575, 30);
            this.bunifuPanel1.TabIndex = 2;
            // 
            // loader
            // 
            this.loader.AllowStylePresets = true;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.loader.Color = System.Drawing.Color.OrangeRed;
            this.loader.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.loader.Customization = "";
            this.loader.DashWidth = 0.5F;
            this.loader.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.loader.Image = null;
            this.loader.Location = new System.Drawing.Point(11, 5);
            this.loader.Name = "loader";
            this.loader.NoRounding = false;
            this.loader.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.loader.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Solid;
            this.loader.ShowText = false;
            this.loader.Size = new System.Drawing.Size(20, 20);
            this.loader.Speed = 7;
            this.loader.TabIndex = 9;
            this.loader.Text = "bunifuLoader1";
            this.loader.TextPadding = new System.Windows.Forms.Padding(0);
            this.loader.Thickness = 3;
            this.loader.Transparent = true;
            this.loader.Visible = false;
            // 
            // iconSec
            // 
            this.iconSec.AllowFocused = false;
            this.iconSec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iconSec.AutoSizeHeight = true;
            this.iconSec.BackColor = System.Drawing.Color.Silver;
            this.iconSec.BorderRadius = 0;
            this.iconSec.Image = ((System.Drawing.Image)(resources.GetObject("iconSec.Image")));
            this.iconSec.IsCircle = true;
            this.iconSec.Location = new System.Drawing.Point(11, 5);
            this.iconSec.Name = "iconSec";
            this.iconSec.Size = new System.Drawing.Size(20, 20);
            this.iconSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSec.TabIndex = 7;
            this.iconSec.TabStop = false;
            this.iconSec.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // urlTxt
            // 
            this.urlTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTxt.BackColor = System.Drawing.Color.Silver;
            this.urlTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.urlTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.urlTxt.ForeColor = System.Drawing.Color.Black;
            this.urlTxt.Location = new System.Drawing.Point(42, 7);
            this.urlTxt.Name = "urlTxt";
            this.urlTxt.Size = new System.Drawing.Size(521, 16);
            this.urlTxt.TabIndex = 8;
            this.urlTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlTxt_KeyPress);
            // 
            // backBtn
            // 
            this.backBtn.AllowFocused = false;
            this.backBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.backBtn.AutoSizeHeight = true;
            this.backBtn.BorderRadius = 10;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.IsCircle = true;
            this.backBtn.Location = new System.Drawing.Point(12, 17);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(20, 20);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 2;
            this.backBtn.TabStop = false;
            this.backBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // navBtn
            // 
            this.navBtn.AllowFocused = false;
            this.navBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.navBtn.AutoSizeHeight = true;
            this.navBtn.BorderRadius = 10;
            this.navBtn.Image = ((System.Drawing.Image)(resources.GetObject("navBtn.Image")));
            this.navBtn.IsCircle = true;
            this.navBtn.Location = new System.Drawing.Point(768, 17);
            this.navBtn.Name = "navBtn";
            this.navBtn.Size = new System.Drawing.Size(20, 20);
            this.navBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.navBtn.TabIndex = 3;
            this.navBtn.TabStop = false;
            this.navBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.navBtn.Click += new System.EventHandler(this.navBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.AllowFocused = false;
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.refreshBtn.AutoSizeHeight = true;
            this.refreshBtn.BorderRadius = 10;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.IsCircle = true;
            this.refreshBtn.Location = new System.Drawing.Point(141, 17);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(20, 20);
            this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBtn.TabIndex = 4;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.AllowFocused = false;
            this.homeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.homeBtn.AutoSizeHeight = true;
            this.homeBtn.BorderRadius = 10;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.IsCircle = true;
            this.homeBtn.Location = new System.Drawing.Point(98, 17);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(20, 20);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 5;
            this.homeBtn.TabStop = false;
            this.homeBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.AllowFocused = false;
            this.forwardBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.forwardBtn.AutoSizeHeight = true;
            this.forwardBtn.BorderRadius = 10;
            this.forwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtn.Image")));
            this.forwardBtn.IsCircle = true;
            this.forwardBtn.Location = new System.Drawing.Point(55, 17);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(20, 20);
            this.forwardBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forwardBtn.TabIndex = 6;
            this.forwardBtn.TabStop = false;
            this.forwardBtn.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBody.Controls.Add(this.chromiumWebBrowser1);
            this.pnlBody.Location = new System.Drawing.Point(0, 54);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(801, 399);
            this.pnlBody.TabIndex = 7;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "protect.png");
            this.imageList1.Images.SetKeyName(1, "warning_shield.png");
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.chromiumWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(0, 0);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(801, 399);
            this.chromiumWebBrowser1.TabIndex = 0;
            // 
            // AppContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.navBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppContainer";
            this.Text = "Form1";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardBtn)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuPictureBox backBtn;
        private Bunifu.UI.WinForms.BunifuPictureBox navBtn;
        private Bunifu.UI.WinForms.BunifuPictureBox refreshBtn;
        private Bunifu.UI.WinForms.BunifuPictureBox homeBtn;
        private Bunifu.UI.WinForms.BunifuPictureBox forwardBtn;
        private System.Windows.Forms.TextBox urlTxt;
        private Bunifu.UI.WinForms.BunifuPictureBox iconSec;
        private System.Windows.Forms.Panel pnlBody;
        private Bunifu.UI.WinForms.BunifuLoader loader;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
    }
}