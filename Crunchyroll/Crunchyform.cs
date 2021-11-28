using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using HtmlAgilityPack;
using System.Windows;

namespace NeuronWebdriver
{
    public partial class Crunchyform : Form
    {
        public Crunchyform()
        {
            InitializeComponent();
            InitializeChromium();

            Initialize();
        }

        int ScreenX = (int)SystemParameters.FullPrimaryScreenWidth;
        int ScreenY = (int)SystemParameters.FullPrimaryScreenHeight + 71;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void MoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void InitializeChromium()
        {

        }
        private static Assembly Resolver(object sender, ResolveEventArgs args)
        {
            if (args.Name.StartsWith("CefSharp"))
            {
                string assemblyName = args.Name.Split(new[] { ',' }, 2)[0] + ".dll";
                string archSpecificPath = Path.Combine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase, Environment.Is64BitProcess ? "x64" : "x86", assemblyName);

                return File.Exists(archSpecificPath) ? Assembly.LoadFile(archSpecificPath) : null;
            }

            return null;
        }

        public void Initialize()
        {
            Electron.Source = new Uri("https://www.crunchyroll.com/trybeta");
            Electron.NavigationCompleted += Electron_NavigationCompleted;
            UpdateLayoutWidth();
        }

        bool Betatest = true;
        private void Electron_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (Betatest)
            {
                if (Electron.Source.ToString().Contains("beta") || Electron.Source.ToString().Contains("watch"))
                {
                    RightPanel.Invoke(new MethodInvoker(delegate { RightPanel.Visible = true; }));
                    FullscreenButton.Invoke(new MethodInvoker(delegate { FullscreenButton.Visible = true; }));
                }
                else
                {
                    RightPanel.Invoke(new MethodInvoker(delegate { RightPanel.Visible = false; }));
                    FullscreenButton.Invoke(new MethodInvoker(delegate { FullscreenButton.Visible = false; }));
                }
                if (InvokeRequired)
                {
                    Invoke(new MethodInvoker(delegate
                    {
                        UpdateLayoutWidth();
                    }));
                }
                else
                {
                    UpdateLayoutWidth();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Electron.Dispose();
        }

        public string RemoveClassFromHTML(string HTML, string ClassName)
        {
            HtmlAgilityPack.HtmlDocument D = new HtmlAgilityPack.HtmlDocument();
            D.LoadHtml(HTML);

            HtmlNode Body = D.DocumentNode.SelectSingleNode("//body");
            if (Body != null)
            {
                HtmlNode Container = Body.ChildNodes["//div"];
                if (Container != null)
                {
                    HtmlNode Target = Container.ChildNodes["//div[@class='" + ClassName + "']"];
                    if (Target != null)
                    {
                        Container.RemoveChild(Target);
                    }
                }
            }
            return D.DocumentNode.OuterHtml.ToString();
        }

        private void UpdateLayoutWidth()
        {
            int W = this.Width;
            if (RightPanel.Visible)
                Electron.Width = W - 50 + 17;
            else
                Electron.Width = W + 17;
            if (TitlebarPanel.Visible)
            {
                Electron.Location = new Point(0, -60 + 30);
                Electron.Height = Height + 60 - 30;
            }
            else
            {
                Electron.Location = new Point(0, -60);
                Electron.Height = Height + 60;
            }

        }

        bool Fullscreen = false;
        Point WindowLocation = new Point(0, 0);
        Size WindowSize = new Size(0, 0);
        private void FullscreenButton_Click(object sender, EventArgs e)
        {
            Fullscreen = !Fullscreen;
            if (Fullscreen)
            {
                WindowLocation = Location;
                WindowSize = Size;

                FullscreenButton.Text = "\uE73F";
                RightPanel.Visible = false;
                TitlebarPanel.Visible = false;
                UpdateLayoutWidth();

                Location = new Point(0, 0);
                Size = new Size(ScreenX, ScreenY);
            }
            else
            {
                FullscreenButton.Text = "\uE740";
                RightPanel.Visible = true;
                TitlebarPanel.Visible = true;
                UpdateLayoutWidth();

                Location = WindowLocation;
                Size = WindowSize;
            }
        }

        private void ListButton_Click(object sender, EventArgs e)
        {
             Electron.Source = new Uri("https://beta.crunchyroll.com/watchlist");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
             Electron.Source = new Uri("https://beta.crunchyroll.com/?q=");
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Electron.Source = new Uri("https://beta.crunchyroll.com/");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Electron.GoBack();
        }
    }
}
