namespace Quiz_Maker.Forms
{
    partial class Create_Quiz_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Quiz_application));
            this.Label2 = new System.Windows.Forms.Label();
            this.itemsbtn = new ns1.BunifuThinButton2();
            this.cancelquizbtn = new ns1.BunifuThinButton2();
            this.createquizbtn = new ns1.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.quiznametbx = new ns1.BunifuMetroTextbox();
            this.itemnumtbx = new ns1.BunifuMetroTextbox();
            this.linepanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(11, 60);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(172, 23);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "How many items :";
            // 
            // itemsbtn
            // 
            this.itemsbtn.ActiveBorderThickness = 1;
            this.itemsbtn.ActiveCornerRadius = 20;
            this.itemsbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemsbtn.ActiveForecolor = System.Drawing.Color.White;
            this.itemsbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.itemsbtn.BackColor = System.Drawing.SystemColors.Control;
            this.itemsbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemsbtn.BackgroundImage")));
            this.itemsbtn.ButtonText = "Add";
            this.itemsbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemsbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.itemsbtn.IdleBorderThickness = 1;
            this.itemsbtn.IdleCornerRadius = 20;
            this.itemsbtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.itemsbtn.IdleForecolor = System.Drawing.Color.White;
            this.itemsbtn.IdleLineColor = System.Drawing.Color.Black;
            this.itemsbtn.Location = new System.Drawing.Point(471, 49);
            this.itemsbtn.Margin = new System.Windows.Forms.Padding(5);
            this.itemsbtn.Name = "itemsbtn";
            this.itemsbtn.Size = new System.Drawing.Size(136, 48);
            this.itemsbtn.TabIndex = 54;
            this.itemsbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.itemsbtn.Click += new System.EventHandler(this.itemsbtn_Click);
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
            this.cancelquizbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelquizbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.cancelquizbtn.IdleBorderThickness = 1;
            this.cancelquizbtn.IdleCornerRadius = 20;
            this.cancelquizbtn.IdleFillColor = System.Drawing.Color.Brown;
            this.cancelquizbtn.IdleForecolor = System.Drawing.Color.White;
            this.cancelquizbtn.IdleLineColor = System.Drawing.Color.Black;
            this.cancelquizbtn.Location = new System.Drawing.Point(471, 49);
            this.cancelquizbtn.Margin = new System.Windows.Forms.Padding(5);
            this.cancelquizbtn.Name = "cancelquizbtn";
            this.cancelquizbtn.Size = new System.Drawing.Size(136, 48);
            this.cancelquizbtn.TabIndex = 55;
            this.cancelquizbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cancelquizbtn.Visible = false;
            this.cancelquizbtn.Click += new System.EventHandler(this.cancelquizbtn_Click);
            // 
            // createquizbtn
            // 
            this.createquizbtn.ActiveBorderThickness = 1;
            this.createquizbtn.ActiveCornerRadius = 20;
            this.createquizbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createquizbtn.ActiveForecolor = System.Drawing.Color.White;
            this.createquizbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.createquizbtn.BackColor = System.Drawing.SystemColors.Control;
            this.createquizbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createquizbtn.BackgroundImage")));
            this.createquizbtn.ButtonText = "Create";
            this.createquizbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createquizbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createquizbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.createquizbtn.IdleBorderThickness = 1;
            this.createquizbtn.IdleCornerRadius = 20;
            this.createquizbtn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.createquizbtn.IdleForecolor = System.Drawing.Color.White;
            this.createquizbtn.IdleLineColor = System.Drawing.Color.Black;
            this.createquizbtn.Location = new System.Drawing.Point(42, 384);
            this.createquizbtn.Margin = new System.Windows.Forms.Padding(5);
            this.createquizbtn.Name = "createquizbtn";
            this.createquizbtn.Size = new System.Drawing.Size(600, 48);
            this.createquizbtn.TabIndex = 56;
            this.createquizbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createquizbtn.Visible = false;
            this.createquizbtn.Click += new System.EventHandler(this.createquizbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "Quiz name:";
            // 
            // quiznametbx
            // 
            this.quiznametbx.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.quiznametbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quiznametbx.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.quiznametbx.BorderThickness = 3;
            this.quiznametbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.quiznametbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.quiznametbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quiznametbx.isPassword = false;
            this.quiznametbx.Location = new System.Drawing.Point(189, 7);
            this.quiznametbx.Margin = new System.Windows.Forms.Padding(4);
            this.quiznametbx.Name = "quiznametbx";
            this.quiznametbx.Size = new System.Drawing.Size(274, 35);
            this.quiznametbx.TabIndex = 58;
            this.quiznametbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.quiznametbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // itemnumtbx
            // 
            this.itemnumtbx.BorderColorFocused = System.Drawing.Color.LimeGreen;
            this.itemnumtbx.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemnumtbx.BorderColorMouseHover = System.Drawing.Color.LimeGreen;
            this.itemnumtbx.BorderThickness = 3;
            this.itemnumtbx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.itemnumtbx.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.itemnumtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.itemnumtbx.isPassword = false;
            this.itemnumtbx.Location = new System.Drawing.Point(190, 55);
            this.itemnumtbx.Margin = new System.Windows.Forms.Padding(4);
            this.itemnumtbx.Name = "itemnumtbx";
            this.itemnumtbx.Size = new System.Drawing.Size(274, 35);
            this.itemnumtbx.TabIndex = 59;
            this.itemnumtbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.itemnumtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Not_Zero_First);
            this.itemnumtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Number_Only);
            this.itemnumtbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Not_Zero_First);
            // 
            // linepanel
            // 
            this.linepanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linepanel.Location = new System.Drawing.Point(-2, 97);
            this.linepanel.Name = "linepanel";
            this.linepanel.Size = new System.Drawing.Size(631, 5);
            this.linepanel.TabIndex = 60;
            // 
            // Create_Quiz_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.linepanel);
            this.Controls.Add(this.itemnumtbx);
            this.Controls.Add(this.quiznametbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createquizbtn);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.cancelquizbtn);
            this.Controls.Add(this.itemsbtn);
            this.Name = "Create_Quiz_application";
            this.Size = new System.Drawing.Size(829, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal ns1.BunifuThinButton2 itemsbtn;
        public ns1.BunifuThinButton2 cancelquizbtn;
        internal ns1.BunifuThinButton2 createquizbtn;
        internal System.Windows.Forms.Label label1;
        private ns1.BunifuMetroTextbox quiznametbx;
        private ns1.BunifuMetroTextbox itemnumtbx;
        private System.Windows.Forms.Panel linepanel;





    }
}
