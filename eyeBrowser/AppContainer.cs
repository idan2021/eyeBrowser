using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using System;
using System.Windows.Forms;

namespace eyeBrowser
{
    public partial class AppContainer : Form
    {
        public AppContainer()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public ChromiumWebBrowser chromeBrowser;

        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            if (!Cef.IsInitialized)
                Cef.Initialize(settings);
            chromeBrowser = new ChromiumWebBrowser("google.com");
            chromiumWebBrowser1.Controls.Add(chromeBrowser);
            chromeBrowser.Dock = DockStyle.Fill;

            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
        }

        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                this.FindForm().Text = e.Title;
            });
        }

        private void ChromeBrowser_LoadingStateChanged(Object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                loader.Visible = e.IsLoading;
                urlTxt.Text = chromeBrowser.Address;
                iconSec.Image = chromeBrowser.Address.StartsWith("https") ? imageList1.Images[0] : imageList1.Images[1];
            });
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
                chromeBrowser.Back();
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
                chromeBrowser.Forward();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            chromeBrowser.Refresh();
        }

        private void navBtn_Click(object sender, EventArgs e)
        {
            Navigation(urlTxt.Text);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Navigation("google.com");
        }

        private void urlTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Navigation(urlTxt.Text);
        }

        private void Navigation(string url)
        {
            if (String.IsNullOrEmpty(url)) return;
            if (url.Equals("about:blank")) return;
            if (!url.StartsWith("http://") &&
                !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            try
            {
                chromeBrowser.Load(url);
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }
    }

}
