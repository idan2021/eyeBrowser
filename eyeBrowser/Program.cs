using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.Web;
using EasyTabs;

namespace eyeBrowser
{
    static class Program
    {
        public static HtmlString HostURL { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            App container = new App();
            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new AppContainer
                    {
                        Text="New Tab"
                    }
                }
            );

            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
