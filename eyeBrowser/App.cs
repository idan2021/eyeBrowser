using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;



namespace eyeBrowser
{
   public partial class App : TitleBarTabs
    {

        public App()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }


        public override TitleBarTab CreateTab()
        {
                return new TitleBarTab(this)
                {
                    Content = new AppContainer
                    {
                        Text = "New Tab"
                    }
                };
            
        }
    }
}
