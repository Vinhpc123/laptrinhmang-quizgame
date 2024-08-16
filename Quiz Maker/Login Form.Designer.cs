namespace Quiz_Maker
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.Showregistrationbtn = new ns1.BunifuThinButton2();
            this.Showloginbtn = new ns1.BunifuThinButton2();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bprologoTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel = new ns1.BunifuCards();
            this.bpropanel = new ns1.BunifuCards();
            this.Label2 = new System.Windows.Forms.Label();
            this.mycodename = new ns1.BunifuCustomLabel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.createandlogintransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.exit_application1 = new Quiz_Maker.Forms.Exit_application();
            this.login_application1 = new Quiz_Maker.Forms.Login_application();
            this.registration_application1 = new Quiz_Maker.Forms.registration_application();
            this.bpropanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Showregistrationbtn
            // 
            this.Showregistrationbtn.ActiveBorderThickness = 1;
            this.Showregistrationbtn.ActiveCornerRadius = 20;
            this.Showregistrationbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Showregistrationbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Showregistrationbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.Showregistrationbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Showregistrationbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Showregistrationbtn.BackgroundImage")));
            this.Showregistrationbtn.ButtonText = "Register";
            this.Showregistrationbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createandlogintransition.SetDecoration(this.Showregistrationbtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.Showregistrationbtn, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this.Showregistrationbtn, BunifuAnimatorNS.DecorationType.None);
            this.Showregistrationbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showregistrationbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Showregistrationbtn.IdleBorderThickness = 1;
            this.Showregistrationbtn.IdleCornerRadius = 20;
            this.Showregistrationbtn.IdleFillColor = System.Drawing.Color.Brown;
            this.Showregistrationbtn.IdleForecolor = System.Drawing.Color.White;
            this.Showregistrationbtn.IdleLineColor = System.Drawing.Color.Black;
            this.Showregistrationbtn.Location = new System.Drawing.Point(608, 363);
            this.Showregistrationbtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Showregistrationbtn.Name = "Showregistrationbtn";
            this.Showregistrationbtn.Size = new System.Drawing.Size(181, 59);
            this.Showregistrationbtn.TabIndex = 54;
            this.Showregistrationbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Showregistrationbtn.Click += new System.EventHandler(this.Showregistrationbtn_Click);
            this.Showregistrationbtn.ClientSizeChanged += new System.EventHandler(this.Showregistrationbtn_Click);
            // 
            // Showloginbtn
            // 
            this.Showloginbtn.ActiveBorderThickness = 1;
            this.Showloginbtn.ActiveCornerRadius = 20;
            this.Showloginbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Showloginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.Showloginbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.Showloginbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Showloginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Showloginbtn.BackgroundImage")));
            this.Showloginbtn.ButtonText = "Back";
            this.Showloginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createandlogintransition.SetDecoration(this.Showloginbtn, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.Showloginbtn, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this.Showloginbtn, BunifuAnimatorNS.DecorationType.None);
            this.Showloginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Showloginbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.Showloginbtn.IdleBorderThickness = 1;
            this.Showloginbtn.IdleCornerRadius = 20;
            this.Showloginbtn.IdleFillColor = System.Drawing.Color.Brown;
            this.Showloginbtn.IdleForecolor = System.Drawing.Color.White;
            this.Showloginbtn.IdleLineColor = System.Drawing.Color.Black;
            this.Showloginbtn.Location = new System.Drawing.Point(608, 420);
            this.Showloginbtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Showloginbtn.Name = "Showloginbtn";
            this.Showloginbtn.Size = new System.Drawing.Size(181, 59);
            this.Showloginbtn.TabIndex = 55;
            this.Showloginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Showloginbtn.Visible = false;
            this.Showloginbtn.Click += new System.EventHandler(this.Showloginbtn_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bprologoTransition
            // 
            this.bprologoTransition.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bprologoTransition.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 1F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.bprologoTransition.DefaultAnimation = animation3;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.BorderRadius = 5;
            this.panel.BottomSahddow = true;
            this.panel.color = System.Drawing.Color.LimeGreen;
            this.bprologoTransition.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.createandlogintransition.SetDecoration(this.panel, BunifuAnimatorNS.DecorationType.None);
            this.panel.LeftSahddow = false;
            this.panel.Location = new System.Drawing.Point(0, -1);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel.Name = "panel";
            this.panel.RightSahddow = true;
            this.panel.ShadowDepth = 20;
            this.panel.Size = new System.Drawing.Size(535, 622);
            this.panel.TabIndex = 56;
            this.panel.Visible = false;
            // 
            // bpropanel
            // 
            this.bpropanel.BackColor = System.Drawing.Color.LimeGreen;
            this.bpropanel.BorderRadius = 5;
            this.bpropanel.BottomSahddow = true;
            this.bpropanel.color = System.Drawing.SystemColors.ActiveCaptionText;
            this.bpropanel.Controls.Add(this.Label2);
            this.bpropanel.Controls.Add(this.mycodename);
            this.bprologoTransition.SetDecoration(this.bpropanel, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.bpropanel, BunifuAnimatorNS.DecorationType.None);
            this.createandlogintransition.SetDecoration(this.bpropanel, BunifuAnimatorNS.DecorationType.None);
            this.bpropanel.LeftSahddow = false;
            this.bpropanel.Location = new System.Drawing.Point(83, 218);
            this.bpropanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bpropanel.Name = "bpropanel";
            this.bpropanel.RightSahddow = true;
            this.bpropanel.ShadowDepth = 20;
            this.bpropanel.Size = new System.Drawing.Size(357, 162);
            this.bpropanel.TabIndex = 1;
            this.bpropanel.Visible = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.LimeGreen;
            this.createandlogintransition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(93, 127);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(144, 28);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Quiz Game";
            // 
            // mycodename
            // 
            this.mycodename.AutoSize = true;
            this.createandlogintransition.SetDecoration(this.mycodename, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.mycodename, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this.mycodename, BunifuAnimatorNS.DecorationType.None);
            this.mycodename.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mycodename.Location = new System.Drawing.Point(39, 22);
            this.mycodename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mycodename.Name = "mycodename";
            this.mycodename.Size = new System.Drawing.Size(270, 114);
            this.mycodename.TabIndex = 0;
            this.mycodename.Text = "Gr-3";
            this.mycodename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mycodename.Click += new System.EventHandler(this.mycodename_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.panel2);
            this.bprologoTransition.SetDecoration(this.Panel1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.Panel1, BunifuAnimatorNS.DecorationType.None);
            this.createandlogintransition.SetDecoration(this.Panel1, BunifuAnimatorNS.DecorationType.None);
            this.Panel1.Location = new System.Drawing.Point(533, 571);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(560, 18);
            this.Panel1.TabIndex = 57;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.bprologoTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.createandlogintransition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(-1, -5);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 12);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.bprologoTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.createandlogintransition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(533, 593);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(569, 12);
            this.panel3.TabIndex = 2;
            // 
            // panelTransition
            // 
            this.panelTransition.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.panelTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
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
            this.panelTransition.DefaultAnimation = animation2;
            // 
            // createandlogintransition
            // 
            this.createandlogintransition.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.createandlogintransition.Cursor = null;
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
            this.createandlogintransition.DefaultAnimation = animation1;
            // 
            // exit_application1
            // 
            this.createandlogintransition.SetDecoration(this.exit_application1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.exit_application1, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this.exit_application1, BunifuAnimatorNS.DecorationType.None);
            this.exit_application1.Location = new System.Drawing.Point(-196, 0);
            this.exit_application1.Margin = new System.Windows.Forms.Padding(5);
            this.exit_application1.Name = "exit_application1";
            this.exit_application1.Size = new System.Drawing.Size(1268, 47);
            this.exit_application1.TabIndex = 0;
            // 
            // login_application1
            // 
            this.createandlogintransition.SetDecoration(this.login_application1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.login_application1, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this.login_application1, BunifuAnimatorNS.DecorationType.None);
            this.login_application1.Location = new System.Drawing.Point(533, 43);
            this.login_application1.Margin = new System.Windows.Forms.Padding(5);
            this.login_application1.Name = "login_application1";
            this.login_application1.Size = new System.Drawing.Size(537, 453);
            this.login_application1.TabIndex = 35;
            // 
            // registration_application1
            // 
            this.createandlogintransition.SetDecoration(this.registration_application1, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this.registration_application1, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this.registration_application1, BunifuAnimatorNS.DecorationType.None);
            this.registration_application1.Location = new System.Drawing.Point(533, 43);
            this.registration_application1.Margin = new System.Windows.Forms.Padding(5);
            this.registration_application1.Name = "registration_application1";
            this.registration_application1.Size = new System.Drawing.Size(537, 453);
            this.registration_application1.TabIndex = 36;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.bpropanel);
            this.Controls.Add(this.Showregistrationbtn);
            this.Controls.Add(this.Showloginbtn);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.exit_application1);
            this.Controls.Add(this.login_application1);
            this.Controls.Add(this.registration_application1);
            this.createandlogintransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bprologoTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.panelTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.bpropanel.ResumeLayout(false);
            this.bpropanel.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Forms.Exit_application exit_application1;
        private Forms.Login_application login_application1;
        private Forms.registration_application registration_application1;
        public ns1.BunifuThinButton2 Showregistrationbtn;
        public ns1.BunifuThinButton2 Showloginbtn;
        private ns1.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition bprologoTransition;
        private ns1.BunifuCards bpropanel;
        internal System.Windows.Forms.Label Label2;
        private ns1.BunifuCustomLabel mycodename;
        private ns1.BunifuCards panel;
        private BunifuAnimatorNS.BunifuTransition panelTransition;
        private BunifuAnimatorNS.BunifuTransition createandlogintransition;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel panel2;






    }
}