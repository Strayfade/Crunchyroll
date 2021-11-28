using System;
using System.IO;
using System.Drawing;
using System.Threading;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using HtmlAgilityPack;
using System.Windows;
using Microsoft.Web.WebView2;
using Microsoft.Web.WebView2.Core;

namespace Crunchyroll
{
    public partial class Crunchyform : Form
    {
        public Crunchyform()
        {
            InitializeComponent();

            GenrePanel.Visible = false;

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
            UpdateLayoutWidth();

            //CoreWebView2Settings G;
            //G.IsPasswordAutosaveEnabled = true;
            //G.IsBuiltInErrorPageEnabled = false;
            //G.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.55 Safari/537.36 Edg/96.0.1054.34";
            //G.AreDevToolsEnabled = false;
            //G.AreDefaultContextMenusEnabled = false;
            //G.AreDefaultScriptDialogsEnabled = false;
            //G.AreBrowserAcceleratorKeysEnabled = false;

            Electron.NavigationCompleted += Electron_NavigationStarting; ;
            Electron.EnsureCoreWebView2Async();
            Electron.Source = new Uri("https://www.crunchyroll.com/trybeta");
        }

        bool Betatest = false;
        private void Electron_NavigationStarting(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (Betatest)
            {
                if (Electron.Source.ToString().Contains("beta") || Electron.CoreWebView2.Source.ToString().Contains("watch"))
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
            FullscreenUpdate();
        }

        private void FullscreenUpdate()
        {
            if (Fullscreen)
            {
                WindowLocation = Location;
                WindowSize = Size;

                FullscreenButton.Visible = false;
                RightPanel.Visible = false;
                TitlebarPanel.Visible = false;
                UpdateLayoutWidth();

                Location = new Point(0, 0);
                Size = new Size(ScreenX, ScreenY);
            }
            else
            {
                FullscreenButton.Visible = true;
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

        private void Crunchyform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                if (Fullscreen)
                {
                    Fullscreen = false;
                    FullscreenUpdate();
                }
            }
        }

        private void Electron_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                if (Fullscreen)
                {
                    Fullscreen = false;
                    FullscreenUpdate();
                }
            }
        }

        private void FullscreenButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                if (Fullscreen)
                {
                    Fullscreen = false;
                    FullscreenUpdate();
                }
            }
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Electron.Source = new Uri("https://beta.crunchyroll.com/videos/" + ((Siticone.UI.WinForms.SiticoneButton)sender).Text.ToString().ToLower());
            GenrePanel.Visible = false;
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Electron.Source = new Uri("https://www.crunchyroll.com/originals/en/index.html");
            GenrePanel.Visible = false;
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            Electron.Source = new Uri("https://www.crunchyroll.com/simulcastcalendar");
            GenrePanel.Visible = false;
        }

        private void siticoneButton19_Click(object sender, EventArgs e)
        {
            Electron.Source = new Uri("https://beta.crunchyroll.com/videos/slice-of-life");
            GenrePanel.Visible = false;
        }

        private void siticoneButton22_Click(object sender, EventArgs e)
        {
            GenrePanel.Visible = false;
        }

        private void siticoneButton21_Click(object sender, EventArgs e)
        {
            GenrePanel.Visible = !GenrePanel.Visible;
        }
    }
}
