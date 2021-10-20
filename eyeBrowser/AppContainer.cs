using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace eyeBrowser
{
    public partial class AppContainer : Form
    {
        List<String> webPages = new List<string>();
        int current = 0;
        public AppContainer()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public ChromiumWebBrowser chromeBrowser;

        //Initializing all the components for the use of the browser with chromium
        public void InitializeChromium()
        {
            //Initialize cef with the provided settings
            CefSettings settings = new CefSettings();
            if (!Cef.IsInitialized)
                Cef.Initialize(settings);

            chromeBrowser = new ChromiumWebBrowser("google.com");//Create new browser component of ChromiumWebBrowser with the initialize page of google
            chromiumWebBrowser1.Controls.Add(chromeBrowser);//Add the chromeBrowser to the chromiumWebBrowser1 and fill it to the chromiumWebBrowser1 window
            chromeBrowser.Dock = DockStyle.Fill;
            current++;
            webPages.Add(chromeBrowser.Address);

            chromeBrowser.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;//The counter of the website for the loader, while it's counting the loader spins
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;//The counter for the change of the tab title
        }

        //Changes the title of the tab based on the title of the website
        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                this.FindForm().Text = e.Title;
            });
        }


        //When a site is loaded, the little icon of the loader starts to take action and shuts when the web is loaded
        private void ChromeBrowser_LoadingStateChanged(Object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                loader.Visible = e.IsLoading;
                urlTxt.Text = chromeBrowser.Address;
                iconSec.Image = chromeBrowser.Address.StartsWith("https") ? imageList1.Images[0] : imageList1.Images[1];
            });
        }

        //Back button click event for returning to the last site you visited
        private void backBtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoBack)
                chromeBrowser.Back();
        }

        //Forward button click event for returning to the site your back from
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (chromeBrowser.CanGoForward)
                chromeBrowser.Forward();
        }

        //Refresh the page while it refresh only the page it's in and not the address that's in urlTxt. not to refresh to wrong page
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Navigation(chromeBrowser.Address);
        }

        //Navigation button for the navigation of the url you typed
        private void navBtn_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left)
            {
                Navigation(urlTxt.Text);
            }
            if (me.Button == MouseButtons.Right)
            {
                ContextMenuStrip cm = new ContextMenuStrip();
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                int webPagesLength = webPages.ToArray().Length;
                Console.WriteLine(webPagesLength);
                Console.WriteLine("The current: " + current);
                foreach (string i in webPages)
                {
                    if (!(i.Contains("http://") || i.Contains("https://")))
                    {
                        var iconURL = "http://www.google.com/s2/favicons?domain=" + i;
                        WebRequest request = HttpWebRequest.Create(iconURL);
                        WebResponse response = request.GetResponse();
                        Stream stream = response.GetResponseStream();
                        Image favicon = Image.FromStream(stream);
                        cm.Items.Add(i,favicon);
                    }
                }
                cm.Show(navBtn, new Point(0, navBtn.Height));
                cm.ItemClicked += new ToolStripItemClickedEventHandler(contexMenu_ItemClicked);
            }
        }

        private void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripItem item = e.ClickedItem;
            Navigation(item.Text);

        }

        //Go to the home page which in this case is google
        private void homeBtn_Click(object sender, EventArgs e)
        {
            Navigation("google.com");
        }

        //This method is for the use of enter in the urlTxt area in order to make the load of the site straight from the url line easier for the user
        private void urlTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Navigation(urlTxt.Text);
                current++;
                webPages.Add(urlTxt.Text);
            }
        }

        //The navigation methos responsible for all the load commands of the websites the user enters in the url line
        private void Navigation(string url)
        {
            if (String.IsNullOrEmpty(url)) return;//check for not empty line
            if (url.Equals("about:blank")) return;//check id the url line is to the about page
            if (!url.StartsWith("http://") &&
                !url.StartsWith("https://"))
            {//in this block we take care of the cases where the user enters "broken" url ex."google.com" instead of "https://www.google.com"
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
