namespace Quiz_Maker.Forms
{
    partial class Show_Quiz_List_application
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Quiz_List_application));
            this.viewresultpanel = new ns1.BunifuCards();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ViewQuizListGridview = new ns1.BunifuCustomDataGrid();
            this.IDQuizName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHighScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewCommand = new System.Windows.Forms.DataGridViewButtonColumn();
            this.linepanel = new System.Windows.Forms.Panel();
            this.showquizpanel = new ns1.BunifuCards();
            this.IDNumlbl = new System.Windows.Forms.Label();
            this.updatebtn = new ns1.BunifuThinButton2();
            this.closebtnbtn = new ns1.BunifuThinButton2();
            this.backbtn = new ns1.BunifuThinButton2();
            this.nextbtn = new ns1.BunifuThinButton2();
            this.numlbl = new System.Windows.Forms.Label();
            this.questiontbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.answertbx = new ns1.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchtbx = new ns1.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewresultpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewQuizListGridview)).BeginInit();
            this.showquizpanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewresultpanel
            // 
            this.viewresultpanel.BackColor = System.Drawing.SystemColors.Control;
            this.viewresultpanel.BorderRadius = 5;
            this.viewresultpanel.BottomSahddow = true;
            this.viewresultpanel.color = System.Drawing.Color.LimeGreen;
            this.viewresultpanel.Controls.Add(this.searchtbx);
            this.viewresultpanel.Controls.Add(this.pictureBox1);
            this.viewresultpanel.Controls.Add(this.label1);
            this.viewresultpanel.Controls.Add(this.panel1);
            this.viewresultpanel.Controls.Add(this.ViewQuizListGridview);
            this.viewresultpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewresultpanel.LeftSahddow = false;
            this.viewresultpanel.Location = new System.Drawing.Point(17, 39);
            this.viewresultpanel.Name = "viewresultpanel";
            this.viewresultpanel.RightSahddow = true;
            this.viewresultpanel.ShadowDepth = 20;
            this.viewresultpanel.Size = new System.Drawing.Size(627, 384);
            this.viewresultpanel.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 69);
            this.panel1.TabIndex = 74;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "List Of Your Quiz";
            // 
            // ViewQuizListGridview
            // 
            this.ViewQuizListGridview.AllowUserToAddRows = false;
            this.ViewQuizListGridview.AllowUserToDeleteRows = false;
            this.ViewQuizListGridview.AllowUserToResizeColumns = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewQuizListGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.ViewQuizListGridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewQuizListGridview.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewQuizListGridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.ViewQuizListGridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewQuizListGridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.ViewQuizListGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.ViewQuizListGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewQuizListGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDQuizName,
            this.IDUsername,
            this.IDHighScore,
            this.DeleteCommand,
            this.ViewCommand});
            this.ViewQuizListGridview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ViewQuizListGridview.DoubleBuffered = true;
            this.ViewQuizListGridview.EnableHeadersVisualStyles = false;
            this.ViewQuizListGridview.HeaderBgColor = System.Drawing.Color.Black;
            this.ViewQuizListGridview.HeaderForeColor = System.Drawing.Color.White;
            this.ViewQuizListGridview.Location = new System.Drawing.Point(1, 111);
            this.ViewQuizListGridview.MultiSelect = false;
            this.ViewQuizListGridview.Name = "ViewQuizListGridview";
            this.ViewQuizListGridview.ReadOnly = true;
            this.ViewQuizListGridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ViewQuizListGridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ViewQuizListGridview.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ViewQuizListGridview.Size = new System.Drawing.Size(624, 257);
            this.ViewQuizListGridview.TabIndex = 78;
            this.ViewQuizListGridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewQuizListGridview_CellClick);
            // 
            // IDQuizName
            // 
            this.IDQuizName.DataPropertyName = "IDQuizName";
            this.IDQuizName.HeaderText = "Quiz Name";
            this.IDQuizName.Name = "IDQuizName";
            this.IDQuizName.ReadOnly = true;
            // 
            // IDUsername
            // 
            this.IDUsername.DataPropertyName = "IDTotal";
            this.IDUsername.HeaderText = "Total Items";
            this.IDUsername.Name = "IDUsername";
            this.IDUsername.ReadOnly = true;
            // 
            // IDHighScore
            // 
            this.IDHighScore.DataPropertyName = "IDHighScore";
            this.IDHighScore.HeaderText = "High Scores";
            this.IDHighScore.Name = "IDHighScore";
            this.IDHighScore.ReadOnly = true;
            // 
            // DeleteCommand
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteCommand.DefaultCellStyle = dataGridViewCellStyle11;
            this.DeleteCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteCommand.HeaderText = "";
            this.DeleteCommand.Name = "DeleteCommand";
            this.DeleteCommand.ReadOnly = true;
            this.DeleteCommand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DeleteCommand.Text = "Delete";
            this.DeleteCommand.UseColumnTextForButtonValue = true;
            // 
            // ViewCommand
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.DodgerBlue;
            this.ViewCommand.DefaultCellStyle = dataGridViewCellStyle12;
            this.ViewCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCommand.HeaderText = "";
            this.ViewCommand.Name = "ViewCommand";
            this.ViewCommand.ReadOnly = true;
            this.ViewCommand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ViewCommand.Text = "View Quiz";
            this.ViewCommand.UseColumnTextForButtonValue = true;
            // 
            // linepanel
            // 
            this.linepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linepanel.Location = new System.Drawing.Point(15, 18);
            this.linepanel.Name = "linepanel";
            this.linepanel.Size = new System.Drawing.Size(631, 5);
            this.linepanel.TabIndex = 85;
            // 
            // showquizpanel
            // 
            this.showquizpanel.BackColor = System.Drawing.SystemColors.Control;
            this.showquizpanel.BorderRadius = 5;
            this.showquizpanel.BottomSahddow = true;
            this.showquizpanel.color = System.Drawing.Color.LimeGreen;
            this.showquizpanel.Controls.Add(this.IDNumlbl);
            this.showquizpanel.Controls.Add(this.updatebtn);
            this.showquizpanel.Controls.Add(this.closebtnbtn);
            this.showquizpanel.Controls.Add(this.backbtn);
            this.showquizpanel.Controls.Add(this.nextbtn);
            this.showquizpanel.Controls.Add(this.numlbl);
            this.showquizpanel.Controls.Add(this.questiontbx);
            this.showquizpanel.Controls.Add(this.panel2);
            this.showquizpanel.Controls.Add(this.answertbx);
            this.showquizpanel.Controls.Add(this.label3);
            this.showquizpanel.Controls.Add(this.label5);
            this.showquizpanel.LeftSahddow = false;
            this.showquizpanel.Location = new System.Drawing.Point(17, 39);
            this.showquizpanel.Name = "showquizpanel";
            this.showquizpanel.RightSahddow = true;
            this.showquizpanel.ShadowDepth = 20;
            this.showquizpanel.Size = new System.Drawing.Size(627, 384);
            this.showquizpanel.TabIndex = 86;
            this.showquizpanel.Visible = false;
            // 
            // IDNumlbl
            // 
            this.IDNumlbl.AutoSize = true;
            this.IDNumlbl.Location = new System.Drawing.Point(131, 304);
            this.IDNumlbl.Name = "IDNumlbl";
            this.IDNumlbl.Size = new System.Drawing.Size(90, 13);
            this.IDNumlbl.TabIndex = 89;
            this.IDNumlbl.Text = "IDNumForUpdate";
            this.IDNumlbl.Visible = false;
            // 
            // updatebtn
            // 
            this.updatebtn.ActiveBorderThickness = 1;
            this.updatebtn.ActiveCornerRadius = 20;
            this.updatebtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.updatebtn.ActiveForecolor = System.Drawing.Color.White;
            this.updatebtn.ActiveLineColor = System.Drawing.Color.Black;
            this.updatebtn.BackColor = System.Drawing.SystemColors.Control;
            this.updatebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updatebtn.BackgroundImage")));
            this.updatebtn.ButtonText = "Update";
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.updatebtn.IdleBorderThickness = 1;
            this.updatebtn.IdleCornerRadius = 20;
            this.updatebtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.updatebtn.IdleForecolor = System.Drawing.Color.White;
            this.updatebtn.IdleLineColor = System.Drawing.Color.Black;
            this.updatebtn.Location = new System.Drawing.Point(124, 260);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(5);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(103, 48);
            this.updatebtn.TabIndex = 88;
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // closebtnbtn
            // 
            this.closebtnbtn.ActiveBorderThickness = 1;
            this.closebtnbtn.ActiveCornerRadius = 20;
            this.closebtnbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.closebtnbtn.ActiveForecolor = System.Drawing.Color.White;
            this.closebtnbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.closebtnbtn.BackColor = System.Drawing.SystemColors.Control;
            this.closebtnbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closebtnbtn.BackgroundImage")));
            this.closebtnbtn.ButtonText = "Close";
            this.closebtnbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtnbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtnbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.closebtnbtn.IdleBorderThickness = 1;
            this.closebtnbtn.IdleCornerRadius = 20;
            this.closebtnbtn.IdleFillColor = System.Drawing.Color.Brown;
            this.closebtnbtn.IdleForecolor = System.Drawing.Color.White;
            this.closebtnbtn.IdleLineColor = System.Drawing.Color.Black;
            this.closebtnbtn.Location = new System.Drawing.Point(16, 260);
            this.closebtnbtn.Margin = new System.Windows.Forms.Padding(5);
            this.closebtnbtn.Name = "closebtnbtn";
            this.closebtnbtn.Size = new System.Drawing.Size(97, 48);
            this.closebtnbtn.TabIndex = 87;
            this.closebtnbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closebtnbtn.Click += new System.EventHandler(this.closebtnbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.ActiveBorderThickness = 1;
            this.backbtn.ActiveCornerRadius = 20;
            this.backbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.backbtn.ActiveForecolor = System.Drawing.Color.White;
            this.backbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.backbtn.BackColor = System.Drawing.SystemColors.Control;
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backbtn.BackgroundImage")));
            this.backbtn.ButtonText = "Back";
            this.backbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.backbtn.IdleBorderThickness = 1;
            this.backbtn.IdleCornerRadius = 20;
            this.backbtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.backbtn.IdleForecolor = System.Drawing.Color.White;
            this.backbtn.IdleLineColor = System.Drawing.Color.Black;
            this.backbtn.Location = new System.Drawing.Point(237, 260);
            this.backbtn.Margin = new System.Windows.Forms.Padding(5);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(103, 48);
            this.backbtn.TabIndex = 79;
            this.backbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // nextbtn
            // 
            this.nextbtn.ActiveBorderThickness = 1;
            this.nextbtn.ActiveCornerRadius = 20;
            this.nextbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nextbtn.ActiveForecolor = System.Drawing.Color.White;
            this.nextbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.nextbtn.BackColor = System.Drawing.SystemColors.Control;
            this.nextbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextbtn.BackgroundImage")));
            this.nextbtn.ButtonText = "Next";
            this.nextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.nextbtn.IdleBorderThickness = 1;
            this.nextbtn.IdleCornerRadius = 20;
            this.nextbtn.IdleFillColor = System.Drawing.Color.Gray;
            this.nextbtn.IdleForecolor = System.Drawing.Color.White;
            this.nextbtn.IdleLineColor = System.Drawing.Color.Black;
            this.nextbtn.Location = new System.Drawing.Point(347, 260);
            this.nextbtn.Margin = new System.Windows.Forms.Padding(5);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(103, 48);
            this.nextbtn.TabIndex = 77;
            this.nextbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // numlbl
            // 
            this.numlbl.AutoSize = true;
            this.numlbl.Location = new System.Drawing.Point(85, 104);
            this.numlbl.Name = "numlbl";
            this.numlbl.Size = new System.Drawing.Size(13, 13);
            this.numlbl.TabIndex = 78;
            this.numlbl.Text = "0";
            // 
            // questiontbx
            // 
            this.questiontbx.BackColor = System.Drawing.SystemColors.Control;
            this.questiontbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questiontbx.Location = new System.Drawing.Point(16, 122);
            this.questiontbx.Multiline = true;
            this.questiontbx.Name = "questiontbx";
            this.questiontbx.Size = new System.Drawing.Size(598, 131);
            this.questiontbx.TabIndex = 77;
            this.questiontbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 69);
            this.panel2.TabIndex = 74;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quiz Review";
            // 
            // answertbx
            // 
            this.answertbx.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.answertbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answertbx.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.answertbx.BorderThickness = 3;
            this.answertbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.answertbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answertbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.answertbx.isPassword = false;
            this.answertbx.Location = new System.Drawing.Point(86, 317);
            this.answertbx.Margin = new System.Windows.Forms.Padding(4);
            this.answertbx.Name = "answertbx";
            this.answertbx.Size = new System.Drawing.Size(426, 35);
            this.answertbx.TabIndex = 76;
            this.answertbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.answertbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(11, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 75;
            this.label3.Text = "Answer :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(15, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Question";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 87;
            this.label1.Text = "Search";
            // 
            // searchtbx
            // 
            this.searchtbx.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.searchtbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchtbx.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.searchtbx.BorderThickness = 3;
            this.searchtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchtbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchtbx.isPassword = false;
            this.searchtbx.Location = new System.Drawing.Point(115, 78);
            this.searchtbx.Margin = new System.Windows.Forms.Padding(4);
            this.searchtbx.Name = "searchtbx";
            this.searchtbx.Size = new System.Drawing.Size(322, 26);
            this.searchtbx.TabIndex = 88;
            this.searchtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchtbx.OnValueChanged += new System.EventHandler(this.searchtbx_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(93, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // Show_Quiz_List_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linepanel);
            this.Controls.Add(this.viewresultpanel);
            this.Controls.Add(this.showquizpanel);
            this.Name = "Show_Quiz_List_application";
            this.Size = new System.Drawing.Size(829, 450);
            this.Load += new System.EventHandler(this.Show_Quiz_List_application_Load);
            this.viewresultpanel.ResumeLayout(false);
            this.viewresultpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewQuizListGridview)).EndInit();
            this.showquizpanel.ResumeLayout(false);
            this.showquizpanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuCards viewresultpanel;
        private ns1.BunifuCustomDataGrid ViewQuizListGridview;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel linepanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDQuizName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHighScore;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteCommand;
        private System.Windows.Forms.DataGridViewButtonColumn ViewCommand;
        private ns1.BunifuCards showquizpanel;
        private System.Windows.Forms.Label numlbl;
        private System.Windows.Forms.TextBox questiontbx;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label6;
        internal ns1.BunifuThinButton2 nextbtn;
        private ns1.BunifuMetroTextbox answertbx;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label5;
        internal ns1.BunifuThinButton2 backbtn;
        internal ns1.BunifuThinButton2 updatebtn;
        public ns1.BunifuThinButton2 closebtnbtn;
        private System.Windows.Forms.Label IDNumlbl;
        internal System.Windows.Forms.Label label1;
        private ns1.BunifuMetroTextbox searchtbx;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
