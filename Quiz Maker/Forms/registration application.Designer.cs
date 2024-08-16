namespace Quiz_Maker.Forms
{
    partial class registration_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration_application));
            this.createbtn = new ns1.BunifuThinButton2();
            this.showpasswordbtn = new ns1.BunifuImageButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.passwordtbx2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernametbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.defaultImage = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.showhidelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtbx1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.nametbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.showpasswordbtn)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultImage)).BeginInit();
            this.SuspendLayout();
            // 
            // createbtn
            // 
            this.createbtn.ActiveBorderThickness = 1;
            this.createbtn.ActiveCornerRadius = 20;
            this.createbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createbtn.ActiveForecolor = System.Drawing.Color.White;
            this.createbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.createbtn.BackColor = System.Drawing.SystemColors.Control;
            this.createbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createbtn.BackgroundImage")));
            this.createbtn.ButtonText = "Create";
            this.createbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.createbtn.IdleBorderThickness = 1;
            this.createbtn.IdleCornerRadius = 20;
            this.createbtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.createbtn.IdleForecolor = System.Drawing.Color.White;
            this.createbtn.IdleLineColor = System.Drawing.Color.Black;
            this.createbtn.Location = new System.Drawing.Point(204, 307);
            this.createbtn.Margin = new System.Windows.Forms.Padding(5);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(136, 48);
            this.createbtn.TabIndex = 63;
            this.createbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // showpasswordbtn
            // 
            this.showpasswordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.showpasswordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpasswordbtn.Image = ((System.Drawing.Image)(resources.GetObject("showpasswordbtn.Image")));
            this.showpasswordbtn.ImageActive = null;
            this.showpasswordbtn.Location = new System.Drawing.Point(318, 223);
            this.showpasswordbtn.Name = "showpasswordbtn";
            this.showpasswordbtn.Size = new System.Drawing.Size(30, 27);
            this.showpasswordbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showpasswordbtn.TabIndex = 59;
            this.showpasswordbtn.TabStop = false;
            this.showpasswordbtn.Zoom = 6;
            this.showpasswordbtn.Click += new System.EventHandler(this.showpasswordbtn_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(54, 253);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(146, 19);
            this.Label4.TabIndex = 58;
            this.Label4.Text = "Re-type password";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(52, 144);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 19);
            this.Label3.TabIndex = 57;
            this.Label3.Text = "Username ";
            // 
            // passwordtbx2
            // 
            this.passwordtbx2.Depth = 0;
            this.passwordtbx2.ForeColor = System.Drawing.Color.Silver;
            this.passwordtbx2.Hint = "";
            this.passwordtbx2.Location = new System.Drawing.Point(52, 280);
            this.passwordtbx2.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordtbx2.Name = "passwordtbx2";
            this.passwordtbx2.PasswordChar = '\0';
            this.passwordtbx2.SelectedText = "";
            this.passwordtbx2.SelectionLength = 0;
            this.passwordtbx2.SelectionStart = 0;
            this.passwordtbx2.Size = new System.Drawing.Size(255, 23);
            this.passwordtbx2.TabIndex = 56;
            this.passwordtbx2.UseSystemPasswordChar = true;
            this.passwordtbx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // usernametbx
            // 
            this.usernametbx.Depth = 0;
            this.usernametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametbx.ForeColor = System.Drawing.Color.Gray;
            this.usernametbx.Hint = "";
            this.usernametbx.Location = new System.Drawing.Point(52, 168);
            this.usernametbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernametbx.Name = "usernametbx";
            this.usernametbx.PasswordChar = '\0';
            this.usernametbx.SelectedText = "";
            this.usernametbx.SelectionLength = 0;
            this.usernametbx.SelectionStart = 0;
            this.usernametbx.Size = new System.Drawing.Size(255, 23);
            this.usernametbx.TabIndex = 55;
            this.usernametbx.UseSystemPasswordChar = false;
            this.usernametbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.panel2);
            this.Panel1.Controls.Add(this.defaultImage);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(0, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(420, 69);
            this.Panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 10);
            this.panel2.TabIndex = 67;
            // 
            // defaultImage
            // 
            this.defaultImage.Image = ((System.Drawing.Image)(resources.GetObject("defaultImage.Image")));
            this.defaultImage.Location = new System.Drawing.Point(321, 13);
            this.defaultImage.Name = "defaultImage";
            this.defaultImage.Size = new System.Drawing.Size(68, 53);
            this.defaultImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.defaultImage.TabIndex = 66;
            this.defaultImage.TabStop = false;
            this.defaultImage.Visible = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(10, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(211, 22);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Create your account.";
            // 
            // showhidelbl
            // 
            this.showhidelbl.AutoSize = true;
            this.showhidelbl.Location = new System.Drawing.Point(315, 252);
            this.showhidelbl.Name = "showhidelbl";
            this.showhidelbl.Size = new System.Drawing.Size(34, 13);
            this.showhidelbl.TabIndex = 61;
            this.showhidelbl.Text = "Show";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(55, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 65;
            this.label2.Text = "Password";
            // 
            // passwordtbx1
            // 
            this.passwordtbx1.Depth = 0;
            this.passwordtbx1.ForeColor = System.Drawing.Color.Silver;
            this.passwordtbx1.Hint = "";
            this.passwordtbx1.Location = new System.Drawing.Point(53, 224);
            this.passwordtbx1.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordtbx1.Name = "passwordtbx1";
            this.passwordtbx1.PasswordChar = '\0';
            this.passwordtbx1.SelectedText = "";
            this.passwordtbx1.SelectionLength = 0;
            this.passwordtbx1.SelectionStart = 0;
            this.passwordtbx1.Size = new System.Drawing.Size(255, 23);
            this.passwordtbx1.TabIndex = 64;
            this.passwordtbx1.UseSystemPasswordChar = true;
            this.passwordtbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(53, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Name ";
            // 
            // nametbx
            // 
            this.nametbx.Depth = 0;
            this.nametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametbx.ForeColor = System.Drawing.Color.Gray;
            this.nametbx.Hint = "";
            this.nametbx.Location = new System.Drawing.Point(53, 118);
            this.nametbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.nametbx.Name = "nametbx";
            this.nametbx.PasswordChar = '\0';
            this.nametbx.SelectedText = "";
            this.nametbx.SelectionLength = 0;
            this.nametbx.SelectionStart = 0;
            this.nametbx.Size = new System.Drawing.Size(255, 23);
            this.nametbx.TabIndex = 66;
            this.nametbx.UseSystemPasswordChar = false;
            this.nametbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // registration_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nametbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordtbx1);
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.showpasswordbtn);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.passwordtbx2);
            this.Controls.Add(this.usernametbx);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.showhidelbl);
            this.Name = "registration_application";
            this.Size = new System.Drawing.Size(420, 371);
            ((System.ComponentModel.ISupportInitialize)(this.showpasswordbtn)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.defaultImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ns1.BunifuThinButton2 createbtn;
        internal ns1.BunifuImageButton showpasswordbtn;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal MaterialSkin.Controls.MaterialSingleLineTextField passwordtbx2;
        internal MaterialSkin.Controls.MaterialSingleLineTextField usernametbx;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label showhidelbl;
        internal System.Windows.Forms.Label label2;
        internal MaterialSkin.Controls.MaterialSingleLineTextField passwordtbx1;
        private System.Windows.Forms.PictureBox defaultImage;
        internal System.Windows.Forms.Label label5;
        internal MaterialSkin.Controls.MaterialSingleLineTextField nametbx;
        private System.Windows.Forms.Panel panel2;
    }
}
