namespace Quiz_Maker
{
    partial class Dashboard
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.opensidebarbtn = new ns1.BunifuImageButton();
            this.sidepanel = new ns1.BunifuCards();
            this.viewquizlistbtn = new ns1.BunifuFlatButton();
            this.closensidebarbtn = new ns1.BunifuImageButton();
            this.slidinglbl = new System.Windows.Forms.Label();
            this.BProLogoPanel = new ns1.BunifuCards();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.mycodename = new ns1.BunifuCustomLabel();
            this.logoutbtn = new ns1.BunifuFlatButton();
            this.playquizbtn = new ns1.BunifuFlatButton();
            this.myaccountbtn = new ns1.BunifuFlatButton();
            this.createquizbtn = new ns1.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidebaropenransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sidebarcloseTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.childformTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.slidinglabel = new System.Windows.Forms.Timer(this.components);
            this.exit_application1 = new Quiz_Maker.Forms.Exit_application();
            this.create_Quiz_application1 = new Quiz_Maker.Forms.Create_Quiz_application();
            this.show_Quiz_List_application1 = new Quiz_Maker.Forms.Show_Quiz_List_application();
            this.play_Quiz_application1 = new Quiz_Maker.Forms.Play_Quiz_application();
            this.my_Account_application1 = new Quiz_Maker.Forms.My_Account_application();
            ((System.ComponentModel.ISupportInitialize)(this.opensidebarbtn)).BeginInit();
            this.sidepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closensidebarbtn)).BeginInit();
            this.BProLogoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // opensidebarbtn
            // 
            this.opensidebarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.opensidebarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.opensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.opensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.opensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.opensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.opensidebarbtn.Image = ((System.Drawing.Image)(resources.GetObject("opensidebarbtn.Image")));
            this.opensidebarbtn.ImageActive = null;
            this.opensidebarbtn.Location = new System.Drawing.Point(8, 17);
            this.opensidebarbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opensidebarbtn.Name = "opensidebarbtn";
            this.opensidebarbtn.Size = new System.Drawing.Size(55, 43);
            this.opensidebarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opensidebarbtn.TabIndex = 6;
            this.opensidebarbtn.TabStop = false;
            this.opensidebarbtn.Visible = false;
            this.opensidebarbtn.Zoom = 10;
            this.opensidebarbtn.Click += new System.EventHandler(this.opensidebarbtn_Click);
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidepanel.BorderRadius = 5;
            this.sidepanel.BottomSahddow = true;
            this.sidepanel.color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sidepanel.Controls.Add(this.viewquizlistbtn);
            this.sidepanel.Controls.Add(this.opensidebarbtn);
            this.sidepanel.Controls.Add(this.closensidebarbtn);
            this.sidepanel.Controls.Add(this.slidinglbl);
            this.sidepanel.Controls.Add(this.BProLogoPanel);
            this.sidepanel.Controls.Add(this.logoutbtn);
            this.sidepanel.Controls.Add(this.playquizbtn);
            this.sidepanel.Controls.Add(this.myaccountbtn);
            this.sidepanel.Controls.Add(this.createquizbtn);
            this.sidepanel.Controls.Add(this.panel1);
            this.logoTransition.SetDecoration(this.sidepanel, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.sidepanel, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.sidepanel, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.sidepanel, BunifuAnimatorNS.DecorationType.None);
            this.sidepanel.LeftSahddow = false;
            this.sidepanel.Location = new System.Drawing.Point(0, 36);
            this.sidepanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.RightSahddow = true;
            this.sidepanel.ShadowDepth = 20;
            this.sidepanel.Size = new System.Drawing.Size(327, 633);
            this.sidepanel.TabIndex = 22;
            // 
            // viewquizlistbtn
            // 
            this.viewquizlistbtn.Activecolor = System.Drawing.Color.Gray;
            this.viewquizlistbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewquizlistbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewquizlistbtn.BorderRadius = 0;
            this.viewquizlistbtn.ButtonText = "    View Quiz List";
            this.viewquizlistbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.viewquizlistbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.viewquizlistbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.viewquizlistbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.viewquizlistbtn, BunifuAnimatorNS.DecorationType.None);
            this.viewquizlistbtn.DisabledColor = System.Drawing.Color.Gray;
            this.viewquizlistbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viewquizlistbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("viewquizlistbtn.Iconimage")));
            this.viewquizlistbtn.Iconimage_right = null;
            this.viewquizlistbtn.Iconimage_right_Selected = null;
            this.viewquizlistbtn.Iconimage_Selected = null;
            this.viewquizlistbtn.IconMarginLeft = 0;
            this.viewquizlistbtn.IconMarginRight = 0;
            this.viewquizlistbtn.IconRightVisible = true;
            this.viewquizlistbtn.IconRightZoom = 100D;
            this.viewquizlistbtn.IconVisible = true;
            this.viewquizlistbtn.IconZoom = 90D;
            this.viewquizlistbtn.IsTab = false;
            this.viewquizlistbtn.Location = new System.Drawing.Point(0, 330);
            this.viewquizlistbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.viewquizlistbtn.Name = "viewquizlistbtn";
            this.viewquizlistbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.viewquizlistbtn.OnHovercolor = System.Drawing.Color.Gray;
            this.viewquizlistbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viewquizlistbtn.selected = false;
            this.viewquizlistbtn.Size = new System.Drawing.Size(325, 64);
            this.viewquizlistbtn.TabIndex = 28;
            this.viewquizlistbtn.Text = "    View Quiz List";
            this.viewquizlistbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.viewquizlistbtn.Textcolor = System.Drawing.Color.White;
            this.viewquizlistbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.viewquizlistbtn.Click += new System.EventHandler(this.viewquizlistbtn_Click);
            // 
            // closensidebarbtn
            // 
            this.closensidebarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closensidebarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoTransition.SetDecoration(this.closensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.closensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.closensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.closensidebarbtn, BunifuAnimatorNS.DecorationType.None);
            this.closensidebarbtn.Image = ((System.Drawing.Image)(resources.GetObject("closensidebarbtn.Image")));
            this.closensidebarbtn.ImageActive = null;
            this.closensidebarbtn.Location = new System.Drawing.Point(265, 17);
            this.closensidebarbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closensidebarbtn.Name = "closensidebarbtn";
            this.closensidebarbtn.Size = new System.Drawing.Size(55, 43);
            this.closensidebarbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closensidebarbtn.TabIndex = 7;
            this.closensidebarbtn.TabStop = false;
            this.closensidebarbtn.Zoom = 10;
            this.closensidebarbtn.Click += new System.EventHandler(this.closensidebarbtn_Click);
            // 
            // slidinglbl
            // 
            this.slidinglbl.AutoSize = true;
            this.childformTransition.SetDecoration(this.slidinglbl, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.slidinglbl, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.slidinglbl, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.slidinglbl, BunifuAnimatorNS.DecorationType.None);
            this.slidinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slidinglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.slidinglbl.Location = new System.Drawing.Point(75, 22);
            this.slidinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.slidinglbl.Name = "slidinglbl";
            this.slidinglbl.Size = new System.Drawing.Size(165, 36);
            this.slidinglbl.TabIndex = 26;
            this.slidinglbl.Text = "SlideLabel";
            // 
            // BProLogoPanel
            // 
            this.BProLogoPanel.BackColor = System.Drawing.Color.LimeGreen;
            this.BProLogoPanel.BorderRadius = 5;
            this.BProLogoPanel.BottomSahddow = true;
            this.BProLogoPanel.color = System.Drawing.Color.Black;
            this.BProLogoPanel.Controls.Add(this.panel2);
            this.BProLogoPanel.Controls.Add(this.Label2);
            this.BProLogoPanel.Controls.Add(this.mycodename);
            this.logoTransition.SetDecoration(this.BProLogoPanel, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.BProLogoPanel, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.BProLogoPanel, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.BProLogoPanel, BunifuAnimatorNS.DecorationType.None);
            this.BProLogoPanel.LeftSahddow = false;
            this.BProLogoPanel.Location = new System.Drawing.Point(-3, 65);
            this.BProLogoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BProLogoPanel.Name = "BProLogoPanel";
            this.BProLogoPanel.RightSahddow = true;
            this.BProLogoPanel.ShadowDepth = 20;
            this.BProLogoPanel.Size = new System.Drawing.Size(329, 59);
            this.BProLogoPanel.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.logoTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(4, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 6);
            this.panel2.TabIndex = 28;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.LimeGreen;
            this.childformTransition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(231, 16);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(0, 28);
            this.Label2.TabIndex = 3;
            // 
            // mycodename
            // 
            this.mycodename.AutoSize = true;
            this.childformTransition.SetDecoration(this.mycodename, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.mycodename, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.mycodename, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.mycodename, BunifuAnimatorNS.DecorationType.None);
            this.mycodename.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mycodename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mycodename.Location = new System.Drawing.Point(76, 11);
            this.mycodename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mycodename.Name = "mycodename";
            this.mycodename.Size = new System.Drawing.Size(179, 48);
            this.mycodename.TabIndex = 0;
            this.mycodename.Text = "Group3";
            this.mycodename.Click += new System.EventHandler(this.mycodename_Click);
            // 
            // logoutbtn
            // 
            this.logoutbtn.Activecolor = System.Drawing.Color.Gray;
            this.logoutbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutbtn.BorderRadius = 0;
            this.logoutbtn.ButtonText = "      Log Out";
            this.logoutbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.logoutbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.logoutbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.logoutbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.logoutbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoutbtn.DisabledColor = System.Drawing.Color.Gray;
            this.logoutbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.logoutbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("logoutbtn.Iconimage")));
            this.logoutbtn.Iconimage_right = null;
            this.logoutbtn.Iconimage_right_Selected = null;
            this.logoutbtn.Iconimage_Selected = null;
            this.logoutbtn.IconMarginLeft = 0;
            this.logoutbtn.IconMarginRight = 0;
            this.logoutbtn.IconRightVisible = true;
            this.logoutbtn.IconRightZoom = 100D;
            this.logoutbtn.IconVisible = true;
            this.logoutbtn.IconZoom = 90D;
            this.logoutbtn.IsTab = false;
            this.logoutbtn.Location = new System.Drawing.Point(-3, 400);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutbtn.OnHovercolor = System.Drawing.Color.Gray;
            this.logoutbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.logoutbtn.selected = false;
            this.logoutbtn.Size = new System.Drawing.Size(325, 64);
            this.logoutbtn.TabIndex = 10;
            this.logoutbtn.Text = "      Log Out";
            this.logoutbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoutbtn.Textcolor = System.Drawing.Color.White;
            this.logoutbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // playquizbtn
            // 
            this.playquizbtn.Activecolor = System.Drawing.Color.Gray;
            this.playquizbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playquizbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playquizbtn.BorderRadius = 0;
            this.playquizbtn.ButtonText = "     Play Quiz";
            this.playquizbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.playquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.playquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.playquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.playquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.playquizbtn.DisabledColor = System.Drawing.Color.Gray;
            this.playquizbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.playquizbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("playquizbtn.Iconimage")));
            this.playquizbtn.Iconimage_right = null;
            this.playquizbtn.Iconimage_right_Selected = null;
            this.playquizbtn.Iconimage_Selected = null;
            this.playquizbtn.IconMarginLeft = 0;
            this.playquizbtn.IconMarginRight = 0;
            this.playquizbtn.IconRightVisible = true;
            this.playquizbtn.IconRightZoom = 100D;
            this.playquizbtn.IconVisible = true;
            this.playquizbtn.IconZoom = 90D;
            this.playquizbtn.IsTab = false;
            this.playquizbtn.Location = new System.Drawing.Point(0, 198);
            this.playquizbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.playquizbtn.Name = "playquizbtn";
            this.playquizbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.playquizbtn.OnHovercolor = System.Drawing.Color.Gray;
            this.playquizbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.playquizbtn.selected = false;
            this.playquizbtn.Size = new System.Drawing.Size(325, 64);
            this.playquizbtn.TabIndex = 9;
            this.playquizbtn.Text = "     Play Quiz";
            this.playquizbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playquizbtn.Textcolor = System.Drawing.Color.White;
            this.playquizbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.playquizbtn.Click += new System.EventHandler(this.playquizbtn_Click);
            // 
            // myaccountbtn
            // 
            this.myaccountbtn.Activecolor = System.Drawing.Color.Gray;
            this.myaccountbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myaccountbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myaccountbtn.BorderRadius = 0;
            this.myaccountbtn.ButtonText = "    My Account";
            this.myaccountbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.myaccountbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.myaccountbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.myaccountbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.myaccountbtn, BunifuAnimatorNS.DecorationType.None);
            this.myaccountbtn.DisabledColor = System.Drawing.Color.Gray;
            this.myaccountbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.myaccountbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("myaccountbtn.Iconimage")));
            this.myaccountbtn.Iconimage_right = null;
            this.myaccountbtn.Iconimage_right_Selected = null;
            this.myaccountbtn.Iconimage_Selected = null;
            this.myaccountbtn.IconMarginLeft = 0;
            this.myaccountbtn.IconMarginRight = 0;
            this.myaccountbtn.IconRightVisible = true;
            this.myaccountbtn.IconRightZoom = 100D;
            this.myaccountbtn.IconVisible = true;
            this.myaccountbtn.IconZoom = 90D;
            this.myaccountbtn.IsTab = false;
            this.myaccountbtn.Location = new System.Drawing.Point(1, 130);
            this.myaccountbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.myaccountbtn.Name = "myaccountbtn";
            this.myaccountbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.myaccountbtn.OnHovercolor = System.Drawing.Color.Gray;
            this.myaccountbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.myaccountbtn.selected = false;
            this.myaccountbtn.Size = new System.Drawing.Size(325, 64);
            this.myaccountbtn.TabIndex = 8;
            this.myaccountbtn.Text = "    My Account";
            this.myaccountbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.myaccountbtn.Textcolor = System.Drawing.Color.White;
            this.myaccountbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.myaccountbtn.Click += new System.EventHandler(this.myaccountbtn_Click);
            // 
            // createquizbtn
            // 
            this.createquizbtn.Activecolor = System.Drawing.Color.Gray;
            this.createquizbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createquizbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createquizbtn.BorderRadius = 0;
            this.createquizbtn.ButtonText = "    Create Quiz";
            this.createquizbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childformTransition.SetDecoration(this.createquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.createquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.createquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.createquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.createquizbtn.DisabledColor = System.Drawing.Color.Gray;
            this.createquizbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.createquizbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("createquizbtn.Iconimage")));
            this.createquizbtn.Iconimage_right = null;
            this.createquizbtn.Iconimage_right_Selected = null;
            this.createquizbtn.Iconimage_Selected = null;
            this.createquizbtn.IconMarginLeft = 0;
            this.createquizbtn.IconMarginRight = 0;
            this.createquizbtn.IconRightVisible = true;
            this.createquizbtn.IconRightZoom = 100D;
            this.createquizbtn.IconVisible = true;
            this.createquizbtn.IconZoom = 90D;
            this.createquizbtn.IsTab = false;
            this.createquizbtn.Location = new System.Drawing.Point(1, 265);
            this.createquizbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.createquizbtn.Name = "createquizbtn";
            this.createquizbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createquizbtn.OnHovercolor = System.Drawing.Color.Gray;
            this.createquizbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.createquizbtn.selected = false;
            this.createquizbtn.Size = new System.Drawing.Size(325, 64);
            this.createquizbtn.TabIndex = 0;
            this.createquizbtn.Text = "    Create Quiz";
            this.createquizbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createquizbtn.Textcolor = System.Drawing.Color.White;
            this.createquizbtn.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.createquizbtn.Click += new System.EventHandler(this.createquizbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.logoTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 12);
            this.panel1.TabIndex = 27;
            // 
            // sidebaropenransition
            // 
            this.sidebaropenransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.sidebaropenransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.sidebaropenransition.DefaultAnimation = animation2;
            this.sidebaropenransition.TimeStep = 0.04F;
            // 
            // sidebarcloseTransition
            // 
            this.sidebarcloseTransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.sidebarcloseTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.sidebarcloseTransition.DefaultAnimation = animation3;
            // 
            // childformTransition
            // 
            this.childformTransition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.childformTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.childformTransition.DefaultAnimation = animation1;
            // 
            // logoTransition
            // 
            this.logoTransition.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.logoTransition.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0.5F;
            animation4.RotateLimit = 0.2F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.logoTransition.DefaultAnimation = animation4;
            // 
            // slidinglabel
            // 
            this.slidinglabel.Enabled = true;
            this.slidinglabel.Interval = 40;
            this.slidinglabel.Tick += new System.EventHandler(this.slidinglabel_Tick);
            // 
            // exit_application1
            // 
            this.childformTransition.SetDecoration(this.exit_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.exit_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.exit_application1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.exit_application1, BunifuAnimatorNS.DecorationType.None);
            this.exit_application1.Location = new System.Drawing.Point(-65, 0);
            this.exit_application1.Margin = new System.Windows.Forms.Padding(5);
            this.exit_application1.Name = "exit_application1";
            this.exit_application1.Size = new System.Drawing.Size(1267, 46);
            this.exit_application1.TabIndex = 0;
            this.exit_application1.Load += new System.EventHandler(this.exit_application1_Load);
            // 
            // create_Quiz_application1
            // 
            this.create_Quiz_application1.AutoScroll = true;
            this.childformTransition.SetDecoration(this.create_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.create_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.create_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.create_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.create_Quiz_application1.Location = new System.Drawing.Point(327, 46);
            this.create_Quiz_application1.Margin = new System.Windows.Forms.Padding(5);
            this.create_Quiz_application1.Name = "create_Quiz_application1";
            this.create_Quiz_application1.Size = new System.Drawing.Size(1107, 566);
            this.create_Quiz_application1.TabIndex = 23;
            this.create_Quiz_application1.Visible = false;
            // 
            // show_Quiz_List_application1
            // 
            this.childformTransition.SetDecoration(this.show_Quiz_List_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.show_Quiz_List_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.show_Quiz_List_application1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.show_Quiz_List_application1, BunifuAnimatorNS.DecorationType.None);
            this.show_Quiz_List_application1.Location = new System.Drawing.Point(327, 46);
            this.show_Quiz_List_application1.Margin = new System.Windows.Forms.Padding(5);
            this.show_Quiz_List_application1.Name = "show_Quiz_List_application1";
            this.show_Quiz_List_application1.Size = new System.Drawing.Size(1105, 554);
            this.show_Quiz_List_application1.TabIndex = 26;
            this.show_Quiz_List_application1.Visible = false;
            // 
            // play_Quiz_application1
            // 
            this.childformTransition.SetDecoration(this.play_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.play_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.play_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.play_Quiz_application1, BunifuAnimatorNS.DecorationType.None);
            this.play_Quiz_application1.Location = new System.Drawing.Point(327, 46);
            this.play_Quiz_application1.Margin = new System.Windows.Forms.Padding(5);
            this.play_Quiz_application1.Name = "play_Quiz_application1";
            this.play_Quiz_application1.Size = new System.Drawing.Size(1105, 554);
            this.play_Quiz_application1.TabIndex = 25;
            this.play_Quiz_application1.Visible = false;
            // 
            // my_Account_application1
            // 
            this.childformTransition.SetDecoration(this.my_Account_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this.my_Account_application1, BunifuAnimatorNS.DecorationType.None);
            this.sidebarcloseTransition.SetDecoration(this.my_Account_application1, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this.my_Account_application1, BunifuAnimatorNS.DecorationType.None);
            this.my_Account_application1.Location = new System.Drawing.Point(327, 46);
            this.my_Account_application1.Margin = new System.Windows.Forms.Padding(5);
            this.my_Account_application1.Name = "my_Account_application1";
            this.my_Account_application1.Size = new System.Drawing.Size(1105, 554);
            this.my_Account_application1.TabIndex = 24;
            this.my_Account_application1.Visible = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.exit_application1);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.create_Quiz_application1);
            this.Controls.Add(this.show_Quiz_List_application1);
            this.Controls.Add(this.play_Quiz_application1);
            this.Controls.Add(this.my_Account_application1);
            this.sidebarcloseTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.sidebaropenransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.logoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.childformTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opensidebarbtn)).EndInit();
            this.sidepanel.ResumeLayout(false);
            this.sidepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closensidebarbtn)).EndInit();
            this.BProLogoPanel.ResumeLayout(false);
            this.BProLogoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.Exit_application exit_application1;
        private ns1.BunifuElipse bunifuElipse1;
        internal ns1.BunifuImageButton opensidebarbtn;
        private ns1.BunifuCards sidepanel;
        internal BunifuAnimatorNS.BunifuTransition sidebaropenransition;
        internal ns1.BunifuImageButton closensidebarbtn;
        private BunifuAnimatorNS.BunifuTransition sidebarcloseTransition;
        private ns1.BunifuFlatButton createquizbtn;
        private Forms.Create_Quiz_application create_Quiz_application1;
        private BunifuAnimatorNS.BunifuTransition childformTransition;
        private ns1.BunifuFlatButton myaccountbtn;
        private Forms.My_Account_application my_Account_application1;
        private ns1.BunifuFlatButton playquizbtn;
        private Forms.Play_Quiz_application play_Quiz_application1;
        private ns1.BunifuFlatButton logoutbtn;
        private ns1.BunifuCards BProLogoPanel;
        internal System.Windows.Forms.Label Label2;
        private ns1.BunifuCustomLabel mycodename;
        private BunifuAnimatorNS.BunifuTransition logoTransition;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label slidinglbl;
        private System.Windows.Forms.Timer slidinglabel;
        private ns1.BunifuFlatButton viewquizlistbtn;
        private Forms.Show_Quiz_List_application show_Quiz_List_application1;


    }
}