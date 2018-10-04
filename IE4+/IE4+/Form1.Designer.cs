namespace _18_10_02_Crappy_browser
{
    partial class Form1
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.History = new System.DirectoryServices.DirectoryEntry();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnFav = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.webbrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnFoward = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtHisDis = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.gbFav = new System.Windows.Forms.GroupBox();
            this.lbFav = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbFav.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1215, 874);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "    +";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.btnHistory);
            this.tabPage2.Controls.Add(this.btnBack);
            this.tabPage2.Controls.Add(this.gbFav);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnFoward);
            this.tabPage2.Controls.Add(this.webbrowser1);
            this.tabPage2.Controls.Add(this.txtUrl);
            this.tabPage2.Controls.Add(this.btnRefresh);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btnHome);
            this.tabPage2.Controls.Add(this.btnFav);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1215, 874);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Home";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtUrl
            // 
            this.txtUrl.AcceptsReturn = true;
            this.txtUrl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUrl.Location = new System.Drawing.Point(278, 14);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(643, 20);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnFav
            // 
            this.btnFav.Image = global::_18_10_02_Crappy_browser.Properties.Resources.if_star_115793;
            this.btnFav.Location = new System.Drawing.Point(220, 3);
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(44, 41);
            this.btnFav.TabIndex = 10;
            this.btnFav.UseVisualStyleBackColor = true;
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = global::_18_10_02_Crappy_browser.Properties.Resources.if_Streamline_18_185038;
            this.btnHome.Location = new System.Drawing.Point(170, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(44, 41);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(944, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::_18_10_02_Crappy_browser.Properties.Resources.if_icon_ios7_refresh_211814;
            this.btnRefresh.Location = new System.Drawing.Point(120, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(44, 41);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // webbrowser1
            // 
            this.webbrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webbrowser1.Location = new System.Drawing.Point(-4, 57);
            this.webbrowser1.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.webbrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbrowser1.Name = "webbrowser1";
            this.webbrowser1.Size = new System.Drawing.Size(1223, 796);
            this.webbrowser1.TabIndex = 0;
            this.webbrowser1.Url = new System.Uri("https://google.com", System.UriKind.Absolute);
            this.webbrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnFoward
            // 
            this.btnFoward.Image = global::_18_10_02_Crappy_browser.Properties.Resources.image;
            this.btnFoward.Location = new System.Drawing.Point(70, 3);
            this.btnFoward.Name = "btnFoward";
            this.btnFoward.Size = new System.Drawing.Size(44, 41);
            this.btnFoward.TabIndex = 5;
            this.btnFoward.UseVisualStyleBackColor = true;
            this.btnFoward.Click += new System.EventHandler(this.btnFoward_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.txtHisDis);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(881, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 368);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "History";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(298, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtHisDis
            // 
            this.txtHisDis.Location = new System.Drawing.Point(38, 81);
            this.txtHisDis.Name = "txtHisDis";
            this.txtHisDis.Size = new System.Drawing.Size(235, 20);
            this.txtHisDis.TabIndex = 2;
            this.txtHisDis.Text = "History is disabled";
            this.txtHisDis.Visible = false;
            this.txtHisDis.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Image = global::_18_10_02_Crappy_browser.Properties.Resources.detective;
            this.button5.Location = new System.Drawing.Point(1037, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 40);
            this.button5.TabIndex = 17;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gbFav
            // 
            this.gbFav.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gbFav.Controls.Add(this.button4);
            this.gbFav.Controls.Add(this.lbFav);
            this.gbFav.Location = new System.Drawing.Point(881, 51);
            this.gbFav.Name = "gbFav";
            this.gbFav.Size = new System.Drawing.Size(200, 230);
            this.gbFav.TabIndex = 16;
            this.gbFav.TabStop = false;
            this.gbFav.Text = "favourite";
            this.gbFav.Visible = false;
            // 
            // lbFav
            // 
            this.lbFav.FormattingEnabled = true;
            this.lbFav.Location = new System.Drawing.Point(6, 14);
            this.lbFav.Name = "lbFav";
            this.lbFav.Size = new System.Drawing.Size(188, 212);
            this.lbFav.TabIndex = 15;
            this.lbFav.SelectedIndexChanged += new System.EventHandler(this.lbFav_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(43, 207);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "add to favourite";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::_18_10_02_Crappy_browser.Properties.Resources.if_Previous_2_372909_1_;
            this.btnBack.Location = new System.Drawing.Point(22, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 41);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(1089, 14);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 18;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(292, 814);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 23);
            this.progressBar1.TabIndex = 19;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1223, 900);
            this.tabControl1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 861);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "IE4+ POC";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFav.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.DirectoryServices.DirectoryEntry History;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbFav;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbFav;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHisDis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnFoward;
        private System.Windows.Forms.WebBrowser webbrowser1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnFav;
        private System.Windows.Forms.TabPage tabPage1;
    }
}

