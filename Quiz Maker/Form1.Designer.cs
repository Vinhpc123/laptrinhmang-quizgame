namespace Quiz_Maker
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.ProgressBar1 = new ns1.BunifuProgressBar();
            this.startbtn = new System.Windows.Forms.Button();
            this.initializinglbl = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.ProgressBar1.BorderRadius = 5;
            this.ProgressBar1.Location = new System.Drawing.Point(-1, 383);
            this.ProgressBar1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ProgressBar1.MaximumValue = 100;
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.ProgressBar1.Size = new System.Drawing.Size(737, 12);
            this.ProgressBar1.TabIndex = 0;
            this.ProgressBar1.Value = 0;
            // 
            // startbtn
            // 
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbtn.Location = new System.Drawing.Point(619, 4);
            this.startbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(100, 28);
            this.startbtn.TabIndex = 1;
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // initializinglbl
            // 
            this.initializinglbl.AutoSize = true;
            this.initializinglbl.Depth = 0;
            this.initializinglbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.initializinglbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.initializinglbl.Location = new System.Drawing.Point(269, 400);
            this.initializinglbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.initializinglbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.initializinglbl.Name = "initializinglbl";
            this.initializinglbl.Size = new System.Drawing.Size(167, 24);
            this.initializinglbl.TabIndex = 2;
            this.initializinglbl.Text = "Created by Group3";
            this.initializinglbl.Click += new System.EventHandler(this.initializinglbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 444);
            this.Controls.Add(this.initializinglbl);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.ProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuProgressBar ProgressBar1;
        private System.Windows.Forms.Button startbtn;
        private MaterialSkin.Controls.MaterialLabel initializinglbl;









    }
}

