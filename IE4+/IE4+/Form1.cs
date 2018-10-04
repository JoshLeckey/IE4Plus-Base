using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.IO;
using EasyTabs;

namespace _18_10_02_Crappy_browser
{
    public partial class Form1 : Form
    {

        // 2. Important: Declare ParentTabs
        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }
        //Declaring variables
        string url = "";
        int favclick = 0, incognito = 0, history = 0;
        public Form1()
        {
            InitializeComponent();
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AppContainer container = new AppContainer();

            // Add the initial Tab
            container.Tabs.Add(
                // Our First Tab created by default in the Application will have as content the Form1
                new TitleBarTab(container)
                {
                    Content = new Form1
                    {
                        Text = "New Tab"
                    }
                }
            );

            // Set initial tab the first one
            container.SelectedTabIndex = 0;

            // Create tabs and start application
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            url = txtUrl.Text;
            txtUrl.Text = e.Url.ToString();
            progressBar1.Visible = false;
            if (url != "")
            {
                if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
                    return;
                listBox1.Items.Add(url);
            }
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string remove = "auto:blank";
                if (listBox1.Items[i].ToString().Contains(remove))
                {
                    listBox1.Items.Remove(remove);
                }
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUrl_Down(object sender, KeyEventArgs e)
        {
            url = txtUrl.Text;
            if (e.KeyCode == Keys.Enter)
            {
                webbrowser1.Navigate(url);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webbrowser1.GoHome();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (webbrowser1.CanGoBack)
            {
                webbrowser1.GoBack();
            }
        }

        private void btnFoward_Click(object sender, EventArgs e)
        {
            if (webbrowser1.CanGoForward)
            {
                webbrowser1.GoForward();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webbrowser1.Stop();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Value = (int)e.CurrentProgress;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Visible = true;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webbrowser1.Refresh();
        }
        private void WebBrowser1_ProgressChanged(Object sender,WebBrowserProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.MaximumProgress;
            progressBar1.Value = (int)e.CurrentProgress;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            url = txtUrl.Text;
            webbrowser1.Navigate(url);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void lbFav_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            url = txtUrl.Text;
            lbFav.Items.Add(url);
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            if (favclick == 0)
            {
                gbFav.Visible = true;
                favclick++;
            }
            else
            {
                gbFav.Visible = false;
                favclick = 0;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            if (history == 0)
            {
                //Making the group box containing the history box appear
                groupBox1.Visible = true;
                //setting the int history to 1 so that means we know if the history box it currently visable
                history++;
            }
            else if (history != 0)
            {
                groupBox1.Visible = false;
                history = 0;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl1.TabCount - 1;
            if (this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                this.tabControl1.TabPages.Insert(lastIndex, "New Tab");
                this.tabControl1.SelectedIndex = lastIndex;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl1.TabCount - 1)
            {
                e.Cancel = true;
            }
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (incognito == 0)
            {
                listBox1.Visible = false;
                txtHisDis.Visible = true;
                this.BackColor = Color.DarkGray;
                incognito++;
            }
            else if (incognito != 0)
            {
                listBox1.Visible = true;
                txtHisDis.Visible = false;
                this.BackColor = Color.LightGray;
                incognito = 0;
            }
        }
    }
}
