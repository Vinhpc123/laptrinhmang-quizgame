namespace Quiz_Maker.Forms
{
    partial class Play_Quiz_application
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play_Quiz_application));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.linepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.startplaybtn = new ns1.BunifuThinButton2();
            this.Label2 = new System.Windows.Forms.Label();
            this.playpanel = new ns1.BunifuCards();
            this.correctanswertbx = new System.Windows.Forms.TextBox();
            this.numlbl = new System.Windows.Forms.Label();
            this.questiontbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerpanel = new System.Windows.Forms.Panel();
            this.timerlbl = new System.Windows.Forms.Label();
            this.quiztimerprogressbar = new ns1.BunifuCircleProgressbar();
            this.label6 = new System.Windows.Forms.Label();
            this.nextanswerbtn = new ns1.BunifuThinButton2();
            this.answertbx = new ns1.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.easyrbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.mediumrbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.hardrbtn = new MaterialSkin.Controls.MaterialRadioButton();
            this.quiznametbx = new ns1.BunifuDropdown();
            this.playquizpanelTrainsition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.ViewResultGridview = new ns1.BunifuCustomDataGrid();
            this.IDNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDYourAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewresultpanel = new ns1.BunifuCards();
            this.scorelbl = new ns1.BunifuCustomLabel();
            this.exportexcelbtn = new ns1.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.donequizbtn = new ns1.BunifuThinButton2();
            this.cancelquizbtn = new ns1.BunifuThinButton2();
            this.quiztimer = new System.Windows.Forms.Timer(this.components);
            this.playpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.timerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewResultGridview)).BeginInit();
            this.viewresultpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linepanel
            // 
            this.linepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.playquizpanelTrainsition.SetDecoration(this.linepanel, BunifuAnimatorNS.DecorationType.None);
            this.linepanel.Location = new System.Drawing.Point(0, 103);
            this.linepanel.Name = "linepanel";
            this.linepanel.Size = new System.Drawing.Size(631, 5);
            this.linepanel.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.playquizpanelTrainsition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 64;
            this.label1.Text = "Select Quiz name:";
            // 
            // startplaybtn
            // 
            this.startplaybtn.ActiveBorderThickness = 1;
            this.startplaybtn.ActiveCornerRadius = 20;
            this.startplaybtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startplaybtn.ActiveForecolor = System.Drawing.Color.White;
            this.startplaybtn.ActiveLineColor = System.Drawing.Color.Black;
            this.startplaybtn.BackColor = System.Drawing.SystemColors.Control;
            this.startplaybtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startplaybtn.BackgroundImage")));
            this.startplaybtn.ButtonText = "Play";
            this.startplaybtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playquizpanelTrainsition.SetDecoration(this.startplaybtn, BunifuAnimatorNS.DecorationType.None);
            this.startplaybtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startplaybtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.startplaybtn.IdleBorderThickness = 1;
            this.startplaybtn.IdleCornerRadius = 20;
            this.startplaybtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.startplaybtn.IdleForecolor = System.Drawing.Color.White;
            this.startplaybtn.IdleLineColor = System.Drawing.Color.Black;
            this.startplaybtn.Location = new System.Drawing.Point(473, 55);
            this.startplaybtn.Margin = new System.Windows.Forms.Padding(5);
            this.startplaybtn.Name = "startplaybtn";
            this.startplaybtn.Size = new System.Drawing.Size(136, 48);
            this.startplaybtn.TabIndex = 62;
            this.startplaybtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startplaybtn.Click += new System.EventHandler(this.startplaybtn_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.playquizpanelTrainsition.SetDecoration(this.Label2, BunifuAnimatorNS.DecorationType.None);
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(13, 66);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(125, 23);
            this.Label2.TabIndex = 61;
            this.Label2.Text = "Select Level:";
            // 
            // playpanel
            // 
            this.playpanel.BackColor = System.Drawing.SystemColors.Control;
            this.playpanel.BorderRadius = 5;
            this.playpanel.BottomSahddow = true;
            this.playpanel.color = System.Drawing.Color.LimeGreen;
            this.playpanel.Controls.Add(this.correctanswertbx);
            this.playpanel.Controls.Add(this.numlbl);
            this.playpanel.Controls.Add(this.questiontbx);
            this.playpanel.Controls.Add(this.panel2);
            this.playpanel.Controls.Add(this.nextanswerbtn);
            this.playpanel.Controls.Add(this.answertbx);
            this.playpanel.Controls.Add(this.label3);
            this.playpanel.Controls.Add(this.label5);
            this.playquizpanelTrainsition.SetDecoration(this.playpanel, BunifuAnimatorNS.DecorationType.None);
            this.playpanel.LeftSahddow = false;
            this.playpanel.Location = new System.Drawing.Point(17, 125);
            this.playpanel.Name = "playpanel";
            this.playpanel.RightSahddow = true;
            this.playpanel.ShadowDepth = 20;
            this.playpanel.Size = new System.Drawing.Size(627, 299);
            this.playpanel.TabIndex = 73;
            this.playpanel.Visible = false;
            // 
            // correctanswertbx
            // 
            this.correctanswertbx.BackColor = System.Drawing.SystemColors.Control;
            this.playquizpanelTrainsition.SetDecoration(this.correctanswertbx, BunifuAnimatorNS.DecorationType.None);
            this.correctanswertbx.Location = new System.Drawing.Point(534, 96);
            this.correctanswertbx.Name = "correctanswertbx";
            this.correctanswertbx.ReadOnly = true;
            this.correctanswertbx.Size = new System.Drawing.Size(78, 20);
            this.correctanswertbx.TabIndex = 79;
            this.correctanswertbx.Visible = false;
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.numlbl, BunifuAnimatorNS.DecorationType.None);
            this.numlbl.Location = new System.Drawing.Point(85, 104);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(13, 13);
            this.numlbl.TabIndex = 78;
            this.numlbl.Text = "0";
            // 
            // questiontbx
            // 
            this.questiontbx.BackColor = System.Drawing.SystemColors.Control;
            this.playquizpanelTrainsition.SetDecoration(this.questiontbx, BunifuAnimatorNS.DecorationType.None);
            this.questiontbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questiontbx.Location = new System.Drawing.Point(16, 122);
            this.questiontbx.Multiline = true;
            this.questiontbx.Name = "questiontbx";
            this.questiontbx.ReadOnly = true;
            this.questiontbx.Size = new System.Drawing.Size(598, 110);
            this.questiontbx.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.timerpanel);
            this.panel2.Controls.Add(this.label6);
            this.playquizpanelTrainsition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 69);
            this.panel2.TabIndex = 74;
            // 
            // timerpanel
            // 
            this.timerpanel.Controls.Add(this.timerlbl);
            this.timerpanel.Controls.Add(this.quiztimerprogressbar);
            this.playquizpanelTrainsition.SetDecoration(this.timerpanel, BunifuAnimatorNS.DecorationType.None);
            this.timerpanel.Location = new System.Drawing.Point(527, -4);
            this.timerpanel.Name = "timerpanel";
            this.timerpanel.Size = new System.Drawing.Size(90, 71);
            this.timerpanel.TabIndex = 85;
            // 
            // timerlbl
            // 
            this.timerlbl.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.timerlbl, BunifuAnimatorNS.DecorationType.None);
            this.timerlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerlbl.Location = new System.Drawing.Point(28, 24);
            this.timerlbl.Name = "timerlbl";
            this.timerlbl.Size = new System.Drawing.Size(38, 25);
            this.timerlbl.TabIndex = 84;
            this.timerlbl.Text = "60";
            // 
            // quiztimerprogressbar
            // 
            this.quiztimerprogressbar.animated = false;
            this.quiztimerprogressbar.animationIterval = 5;
            this.quiztimerprogressbar.animationSpeed = 300;
            this.quiztimerprogressbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quiztimerprogressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quiztimerprogressbar.BackgroundImage")));
            this.playquizpanelTrainsition.SetDecoration(this.quiztimerprogressbar, BunifuAnimatorNS.DecorationType.None);
            this.quiztimerprogressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.quiztimerprogressbar.ForeColor = System.Drawing.Color.SeaGreen;
            this.quiztimerprogressbar.LabelVisible = false;
            this.quiztimerprogressbar.LineProgressThickness = 8;
            this.quiztimerprogressbar.LineThickness = 5;
            this.quiztimerprogressbar.Location = new System.Drawing.Point(9, 1);
            this.quiztimerprogressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.quiztimerprogressbar.MaxValue = 60;
            this.quiztimerprogressbar.Name = "quiztimerprogressbar";
            this.quiztimerprogressbar.ProgressBackColor = System.Drawing.Color.LimeGreen;
            this.quiztimerprogressbar.ProgressColor = System.Drawing.Color.Black;
            this.quiztimerprogressbar.Size = new System.Drawing.Size(74, 74);
            this.quiztimerprogressbar.TabIndex = 83;
            this.quiztimerprogressbar.Value = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enjoy playing";
            // 
            // nextanswerbtn
            // 
            this.nextanswerbtn.ActiveBorderThickness = 1;
            this.nextanswerbtn.ActiveCornerRadius = 20;
            this.nextanswerbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nextanswerbtn.ActiveForecolor = System.Drawing.Color.White;
            this.nextanswerbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.nextanswerbtn.BackColor = System.Drawing.SystemColors.Control;
            this.nextanswerbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextanswerbtn.BackgroundImage")));
            this.nextanswerbtn.ButtonText = "Next";
            this.nextanswerbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playquizpanelTrainsition.SetDecoration(this.nextanswerbtn, BunifuAnimatorNS.DecorationType.None);
            this.nextanswerbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextanswerbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextanswerbtn.IdleBorderThickness = 1;
            this.nextanswerbtn.IdleCornerRadius = 20;
            this.nextanswerbtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.nextanswerbtn.IdleForecolor = System.Drawing.Color.White;
            this.nextanswerbtn.IdleLineColor = System.Drawing.Color.Black;
            this.nextanswerbtn.Location = new System.Drawing.Point(476, 233);
            this.nextanswerbtn.Margin = new System.Windows.Forms.Padding(5);
            this.nextanswerbtn.Name = "nextanswerbtn";
            this.nextanswerbtn.Size = new System.Drawing.Size(136, 48);
            this.nextanswerbtn.TabIndex = 77;
            this.nextanswerbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextanswerbtn.Click += new System.EventHandler(this.nextanswerbtn_Click);
            // 
            // answertbx
            // 
            this.answertbx.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.answertbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answertbx.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.answertbx.BorderThickness = 3;
            this.answertbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.playquizpanelTrainsition.SetDecoration(this.answertbx, BunifuAnimatorNS.DecorationType.None);
            this.answertbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answertbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answertbx.isPassword = false;
            this.answertbx.Location = new System.Drawing.Point(86, 239);
            this.answertbx.Margin = new System.Windows.Forms.Padding(4);
            this.answertbx.Name = "answertbx";
            this.answertbx.Size = new System.Drawing.Size(380, 35);
            this.answertbx.TabIndex = 76;
            this.answertbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.answertbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answertbx_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(11, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Answer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Question";
            // 
            // easyrbtn
            // 
            this.easyrbtn.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.easyrbtn, BunifuAnimatorNS.DecorationType.None);
            this.easyrbtn.Depth = 0;
            this.easyrbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.easyrbtn.Location = new System.Drawing.Point(191, 63);
            this.easyrbtn.Margin = new System.Windows.Forms.Padding(0);
            this.easyrbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.easyrbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.easyrbtn.Name = "easyrbtn";
            this.easyrbtn.Ripple = true;
            this.easyrbtn.Size = new System.Drawing.Size(58, 30);
            this.easyrbtn.TabIndex = 74;
            this.easyrbtn.TabStop = true;
            this.easyrbtn.Text = "Easy";
            this.easyrbtn.UseVisualStyleBackColor = true;
            // 
            // mediumrbtn
            // 
            this.mediumrbtn.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.mediumrbtn, BunifuAnimatorNS.DecorationType.None);
            this.mediumrbtn.Depth = 0;
            this.mediumrbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.mediumrbtn.Location = new System.Drawing.Point(268, 63);
            this.mediumrbtn.Margin = new System.Windows.Forms.Padding(0);
            this.mediumrbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mediumrbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mediumrbtn.Name = "mediumrbtn";
            this.mediumrbtn.Ripple = true;
            this.mediumrbtn.Size = new System.Drawing.Size(79, 30);
            this.mediumrbtn.TabIndex = 75;
            this.mediumrbtn.TabStop = true;
            this.mediumrbtn.Text = "Medium";
            this.mediumrbtn.UseVisualStyleBackColor = true;
            // 
            // hardrbtn
            // 
            this.hardrbtn.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.hardrbtn, BunifuAnimatorNS.DecorationType.None);
            this.hardrbtn.Depth = 0;
            this.hardrbtn.Font = new System.Drawing.Font("Roboto", 10F);
            this.hardrbtn.Location = new System.Drawing.Point(363, 63);
            this.hardrbtn.Margin = new System.Windows.Forms.Padding(0);
            this.hardrbtn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hardrbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.hardrbtn.Name = "hardrbtn";
            this.hardrbtn.Ripple = true;
            this.hardrbtn.Size = new System.Drawing.Size(59, 30);
            this.hardrbtn.TabIndex = 76;
            this.hardrbtn.TabStop = true;
            this.hardrbtn.Text = "Hard";
            this.hardrbtn.UseVisualStyleBackColor = true;
            // 
            // quiznametbx
            // 
            this.quiznametbx.BackColor = System.Drawing.Color.Transparent;
            this.quiznametbx.BorderRadius = 3;
            this.quiznametbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playquizpanelTrainsition.SetDecoration(this.quiznametbx, BunifuAnimatorNS.DecorationType.None);
            this.quiznametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.quiznametbx.ForeColor = System.Drawing.Color.Black;
            this.quiznametbx.Items = new string[0];
            this.quiznametbx.Location = new System.Drawing.Point(197, 17);
            this.quiznametbx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quiznametbx.Name = "quiznametbx";
            this.quiznametbx.NomalColor = System.Drawing.SystemColors.Control;
            this.quiznametbx.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quiznametbx.selectedIndex = -1;
            this.quiznametbx.Size = new System.Drawing.Size(275, 25);
            this.quiznametbx.TabIndex = 77;
            // 
            // playquizpanelTrainsition
            // 
            this.playquizpanelTrainsition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.playquizpanelTrainsition.Cursor = null;
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
            this.playquizpanelTrainsition.DefaultAnimation = animation2;
            // 
            // ViewResultGridview
            // 
            this.ViewResultGridview.AllowUserToAddRows = false;
            this.ViewResultGridview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewResultGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.ViewResultGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ViewResultGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewResultGridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ViewResultGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewResultGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewResultGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ViewResultGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ViewResultGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNumber,
            this.IDQuestion,
            this.IDAnswer,
            this.IDYourAnswer,
            this.IDResult});
            this.playquizpanelTrainsition.SetDecoration(this.ViewResultGridview, BunifuAnimatorNS.DecorationType.None);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewResultGridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.ViewResultGridview.DoubleBuffered = true;
            this.ViewResultGridview.EnableHeadersVisualStyles = false;
            this.ViewResultGridview.HeaderBgColor = System.Drawing.SystemColors.Control;
            this.ViewResultGridview.HeaderForeColor = System.Drawing.Color.Black;
            this.ViewResultGridview.Location = new System.Drawing.Point(1, 75);
            this.ViewResultGridview.Name = "ViewResultGridview";
            this.ViewResultGridview.ReadOnly = true;
            this.ViewResultGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ViewResultGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ViewResultGridview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewResultGridview.Size = new System.Drawing.Size(624, 169);
            this.ViewResultGridview.TabIndex = 78;
            // 
            // IDNumber
            // 
            this.IDNumber.HeaderText = "Number";
            this.IDNumber.Name = "IDNumber";
            this.IDNumber.ReadOnly = true;
            this.IDNumber.Width = 88;
            // 
            // IDQuestion
            // 
            this.IDQuestion.HeaderText = "Questions";
            this.IDQuestion.Name = "IDQuestion";
            this.IDQuestion.ReadOnly = true;
            this.IDQuestion.Width = 104;
            // 
            // IDAnswer
            // 
            this.IDAnswer.HeaderText = "Answer";
            this.IDAnswer.Name = "IDAnswer";
            this.IDAnswer.ReadOnly = true;
            this.IDAnswer.Width = 85;
            // 
            // IDYourAnswer
            // 
            this.IDYourAnswer.HeaderText = "Your Answer";
            this.IDYourAnswer.Name = "IDYourAnswer";
            this.IDYourAnswer.ReadOnly = true;
            this.IDYourAnswer.Width = 123;
            // 
            // IDResult
            // 
            this.IDResult.HeaderText = "Checking";
            this.IDResult.Name = "IDResult";
            this.IDResult.ReadOnly = true;
            this.IDResult.Width = 98;
            // 
            // viewresultpanel
            // 
            this.viewresultpanel.BackColor = System.Drawing.SystemColors.Control;
            this.viewresultpanel.BorderRadius = 5;
            this.viewresultpanel.BottomSahddow = true;
            this.viewresultpanel.color = System.Drawing.Color.LimeGreen;
            this.viewresultpanel.Controls.Add(this.scorelbl);
            this.viewresultpanel.Controls.Add(this.exportexcelbtn);
            this.viewresultpanel.Controls.Add(this.ViewResultGridview);
            this.viewresultpanel.Controls.Add(this.panel1);
            this.viewresultpanel.Controls.Add(this.donequizbtn);
            this.playquizpanelTrainsition.SetDecoration(this.viewresultpanel, BunifuAnimatorNS.DecorationType.None);
            this.viewresultpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewresultpanel.LeftSahddow = false;
            this.viewresultpanel.Location = new System.Drawing.Point(17, 125);
            this.viewresultpanel.Name = "viewresultpanel";
            this.viewresultpanel.RightSahddow = true;
            this.viewresultpanel.ShadowDepth = 20;
            this.viewresultpanel.Size = new System.Drawing.Size(627, 299);
            this.viewresultpanel.TabIndex = 80;
            this.viewresultpanel.Visible = false;
            // 
            // scorelbl
            // 
            this.scorelbl.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.scorelbl, BunifuAnimatorNS.DecorationType.None);
            this.scorelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelbl.Location = new System.Drawing.Point(10, 254);
            this.scorelbl.Name = "scorelbl";
            this.scorelbl.Size = new System.Drawing.Size(166, 29);
            this.scorelbl.TabIndex = 82;
            this.scorelbl.Text = "Your score is :";
            // 
            // exportexcelbtn
            // 
            this.exportexcelbtn.ActiveBorderThickness = 1;
            this.exportexcelbtn.ActiveCornerRadius = 20;
            this.exportexcelbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exportexcelbtn.ActiveForecolor = System.Drawing.Color.White;
            this.exportexcelbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.exportexcelbtn.BackColor = System.Drawing.SystemColors.Control;
            this.exportexcelbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportexcelbtn.BackgroundImage")));
            this.exportexcelbtn.ButtonText = "Export to excel";
            this.exportexcelbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playquizpanelTrainsition.SetDecoration(this.exportexcelbtn, BunifuAnimatorNS.DecorationType.None);
            this.exportexcelbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportexcelbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exportexcelbtn.IdleBorderThickness = 1;
            this.exportexcelbtn.IdleCornerRadius = 20;
            this.exportexcelbtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.exportexcelbtn.IdleForecolor = System.Drawing.Color.White;
            this.exportexcelbtn.IdleLineColor = System.Drawing.Color.Black;
            this.exportexcelbtn.Location = new System.Drawing.Point(330, 243);
            this.exportexcelbtn.Margin = new System.Windows.Forms.Padding(5);
            this.exportexcelbtn.Name = "exportexcelbtn";
            this.exportexcelbtn.Size = new System.Drawing.Size(136, 48);
            this.exportexcelbtn.TabIndex = 81;
            this.exportexcelbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exportexcelbtn.Click += new System.EventHandler(this.exportexcelbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label7);
            this.playquizpanelTrainsition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 69);
            this.panel1.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.playquizpanelTrainsition.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quiz Result";
            // 
            // donequizbtn
            // 
            this.donequizbtn.ActiveBorderThickness = 1;
            this.donequizbtn.ActiveCornerRadius = 20;
            this.donequizbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.donequizbtn.ActiveForecolor = System.Drawing.Color.White;
            this.donequizbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.donequizbtn.BackColor = System.Drawing.SystemColors.Control;
            this.donequizbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("donequizbtn.BackgroundImage")));
            this.donequizbtn.ButtonText = "Done";
            this.donequizbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playquizpanelTrainsition.SetDecoration(this.donequizbtn, BunifuAnimatorNS.DecorationType.None);
            this.donequizbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donequizbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.donequizbtn.IdleBorderThickness = 1;
            this.donequizbtn.IdleCornerRadius = 20;
            this.donequizbtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.donequizbtn.IdleForecolor = System.Drawing.Color.White;
            this.donequizbtn.IdleLineColor = System.Drawing.Color.Black;
            this.donequizbtn.Location = new System.Drawing.Point(476, 244);
            this.donequizbtn.Margin = new System.Windows.Forms.Padding(5);
            this.donequizbtn.Name = "donequizbtn";
            this.donequizbtn.Size = new System.Drawing.Size(136, 48);
            this.donequizbtn.TabIndex = 77;
            this.donequizbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.donequizbtn.Click += new System.EventHandler(this.donequizbtn_Click);
            // 
            // cancelquizbtn
            // 
            this.cancelquizbtn.ActiveBorderThickness = 1;
            this.cancelquizbtn.ActiveCornerRadius = 20;
            this.cancelquizbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cancelquizbtn.ActiveForecolor = System.Drawing.Color.White;
            this.cancelquizbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.cancelquizbtn.BackColor = System.Drawing.SystemColors.Control;
            this.cancelquizbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelquizbtn.BackgroundImage")));
            this.cancelquizbtn.ButtonText = "Cancel";
            this.cancelquizbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playquizpanelTrainsition.SetDecoration(this.cancelquizbtn, BunifuAnimatorNS.DecorationType.None);
            this.cancelquizbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelquizbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelquizbtn.IdleBorderThickness = 1;
            this.cancelquizbtn.IdleCornerRadius = 20;
            this.cancelquizbtn.IdleFillColor = System.Drawing.Color.Brown;
            this.cancelquizbtn.IdleForecolor = System.Drawing.Color.White;
            this.cancelquizbtn.IdleLineColor = System.Drawing.Color.Black;
            this.cancelquizbtn.Location = new System.Drawing.Point(473, 55);
            this.cancelquizbtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelquizbtn.Name = "cancelquizbtn";
            this.cancelquizbtn.Size = new System.Drawing.Size(136, 48);
            this.cancelquizbtn.TabIndex = 81;
            this.cancelquizbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelquizbtn.Visible = false;
            this.cancelquizbtn.Click += new System.EventHandler(this.cancelquizbtn_Click);
            // 
            // quiztimer
            // 
            this.quiztimer.Interval = 1000;
            this.quiztimer.Tick += new System.EventHandler(this.quiztimer_Tick);
            // 
            // Play_Quiz_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.quiznametbx);
            this.Controls.Add(this.hardrbtn);
            this.Controls.Add(this.mediumrbtn);
            this.Controls.Add(this.easyrbtn);
            this.Controls.Add(this.linepanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.startplaybtn);
            this.Controls.Add(this.cancelquizbtn);
            this.Controls.Add(this.playpanel);
            this.Controls.Add(this.viewresultpanel);
            this.playquizpanelTrainsition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Play_Quiz_application";
            this.Size = new System.Drawing.Size(829, 450);
            this.Load += new System.EventHandler(this.Play_Quiz_application_Load);
            this.playpanel.ResumeLayout(false);
            this.playpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.timerpanel.ResumeLayout(false);
            this.timerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewResultGridview)).EndInit();
            this.viewresultpanel.ResumeLayout(false);
            this.viewresultpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel linepanel;
        internal System.Windows.Forms.Label label1;
        internal ns1.BunifuThinButton2 startplaybtn;
        internal System.Windows.Forms.Label Label2;
        private ns1.BunifuCards playpanel;
        internal ns1.BunifuThinButton2 nextanswerbtn;
        private ns1.BunifuMetroTextbox answertbx;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialRadioButton easyrbtn;
        private MaterialSkin.Controls.MaterialRadioButton mediumrbtn;
        private MaterialSkin.Controls.MaterialRadioButton hardrbtn;
        private System.Windows.Forms.TextBox questiontbx;
        private ns1.BunifuDropdown quiznametbx;
        private BunifuAnimatorNS.BunifuTransition playquizpanelTrainsition;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.TextBox correctanswertbx;
        private ns1.BunifuCustomDataGrid ViewResultGridview;
        private ns1.BunifuCards viewresultpanel;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label7;
        internal ns1.BunifuThinButton2 donequizbtn;
        internal ns1.BunifuThinButton2 exportexcelbtn;
        private ns1.BunifuCustomLabel scorelbl;
        private System.Windows.Forms.Label timerlbl;
        private ns1.BunifuCircleProgressbar quiztimerprogressbar;
        private System.Windows.Forms.Timer quiztimer;
        private System.Windows.Forms.Panel timerpanel;
        public ns1.BunifuThinButton2 cancelquizbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDYourAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDResult;
    }
}
