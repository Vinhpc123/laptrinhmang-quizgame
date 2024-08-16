namespace Quiz_Maker.Forms
{
    partial class Login_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_application));
            this.BunifuImageButton2 = new ns1.BunifuImageButton();
            this.showpasswordbtn = new ns1.BunifuImageButton();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.passwordtbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.usernametbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.loginbtn = new ns1.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpasswordbtn)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BunifuImageButton2
            // 
            this.BunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.BunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("BunifuImageButton2.Image")));
            this.BunifuImageButton2.ImageActive = null;
            this.BunifuImageButton2.Location = new System.Drawing.Point(316, 134);
            this.BunifuImageButton2.Name = "BunifuImageButton2";
            this.BunifuImageButton2.Size = new System.Drawing.Size(30, 33);
            this.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BunifuImageButton2.TabIndex = 50;
            this.BunifuImageButton2.TabStop = false;
            this.BunifuImageButton2.Zoom = 6;
            // 
            // showpasswordbtn
            // 
            this.showpasswordbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.showpasswordbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpasswordbtn.Image = global::Quiz_Maker.Properties.Resources.EyeHide;
            this.showpasswordbtn.ImageActive = null;
            this.showpasswordbtn.Location = new System.Drawing.Point(317, 205);
            this.showpasswordbtn.Name = "showpasswordbtn";
            this.showpasswordbtn.Size = new System.Drawing.Size(30, 27);
            this.showpasswordbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.showpasswordbtn.TabIndex = 49;
            this.showpasswordbtn.TabStop = false;
            this.showpasswordbtn.Zoom = 6;
            this.showpasswordbtn.Click += new System.EventHandler(this.showpasswordbtn_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(54, 189);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 19);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "Password";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(52, 114);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 19);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Username ";
            // 
            // passwordtbx
            // 
            this.passwordtbx.Depth = 0;
            this.passwordtbx.ForeColor = System.Drawing.Color.Silver;
            this.passwordtbx.Hint = "";
            this.passwordtbx.Location = new System.Drawing.Point(52, 220);
            this.passwordtbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordtbx.Name = "passwordtbx";
            this.passwordtbx.PasswordChar = '\0';
            this.passwordtbx.SelectedText = "";
            this.passwordtbx.SelectionLength = 0;
            this.passwordtbx.SelectionStart = 0;
            this.passwordtbx.Size = new System.Drawing.Size(255, 23);
            this.passwordtbx.TabIndex = 46;
            this.passwordtbx.UseSystemPasswordChar = true;
            this.passwordtbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // usernametbx
            // 
            this.usernametbx.Depth = 0;
            this.usernametbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametbx.ForeColor = System.Drawing.Color.Gray;
            this.usernametbx.Hint = "";
            this.usernametbx.Location = new System.Drawing.Point(52, 145);
            this.usernametbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernametbx.Name = "usernametbx";
            this.usernametbx.PasswordChar = '\0';
            this.usernametbx.SelectedText = "";
            this.usernametbx.SelectionLength = 0;
            this.usernametbx.SelectionStart = 0;
            this.usernametbx.Size = new System.Drawing.Size(255, 23);
            this.usernametbx.TabIndex = 45;
            this.usernametbx.UseSystemPasswordChar = false;
            this.usernametbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.No_Quotation_KeyPress);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Panel1.Controls.Add(this.panel2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(0, -1);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(420, 69);
            this.Panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LimeGreen;
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 10);
            this.panel2.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(10, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(195, 22);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Login your account.";
            // 
            // loginbtn
            // 
            this.loginbtn.ActiveBorderThickness = 1;
            this.loginbtn.ActiveCornerRadius = 20;
            this.loginbtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginbtn.ActiveLineColor = System.Drawing.Color.Black;
            this.loginbtn.BackColor = System.Drawing.SystemColors.Control;
            this.loginbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbtn.BackgroundImage")));
            this.loginbtn.ButtonText = "Login";
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginbtn.IdleBorderThickness = 1;
            this.loginbtn.IdleCornerRadius = 20;
            this.loginbtn.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.loginbtn.IdleForecolor = System.Drawing.Color.White;
            this.loginbtn.IdleLineColor = System.Drawing.Color.Black;
            this.loginbtn.Location = new System.Drawing.Point(204, 261);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(136, 48);
            this.loginbtn.TabIndex = 53;
            this.loginbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Login_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.BunifuImageButton2);
            this.Controls.Add(this.showpasswordbtn);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.passwordtbx);
            this.Controls.Add(this.usernametbx);
            this.Controls.Add(this.Panel1);
            this.Name = "Login_application";
            this.Size = new System.Drawing.Size(420, 315);
            ((System.ComponentModel.ISupportInitialize)(this.BunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showpasswordbtn)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal ns1.BunifuImageButton BunifuImageButton2;
        internal ns1.BunifuImageButton showpasswordbtn;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal MaterialSkin.Controls.MaterialSingleLineTextField passwordtbx;
        internal MaterialSkin.Controls.MaterialSingleLineTextField usernametbx;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label1;
        internal ns1.BunifuThinButton2 loginbtn;
        private System.Windows.Forms.Panel panel2;
    }
}
