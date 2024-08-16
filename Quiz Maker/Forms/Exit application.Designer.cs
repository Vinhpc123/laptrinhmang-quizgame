namespace Quiz_Maker.Forms
{
    partial class Exit_application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit_application));
            this.Label2 = new System.Windows.Forms.Label();
            this.exitbtn = new ns1.BunifuImageButton();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.dragline = new ns1.BunifuCards();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            this.dragline.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(75, 6);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(187, 37);
            this.Label2.TabIndex = 38;
            this.Label2.Text = "Quiz Game";
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("exitbtn.Image")));
            this.exitbtn.ImageActive = null;
            this.exitbtn.Location = new System.Drawing.Point(1220, -2);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(47, 53);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitbtn.TabIndex = 37;
            this.exitbtn.TabStop = false;
            this.exitbtn.Zoom = 6;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.dragline;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dragline
            // 
            this.dragline.BackColor = System.Drawing.Color.ForestGreen;
            this.dragline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dragline.BackgroundImage")));
            this.dragline.BorderRadius = 5;
            this.dragline.BottomSahddow = true;
            this.dragline.color = System.Drawing.Color.LimeGreen;
            this.dragline.Controls.Add(this.Label2);
            this.dragline.Controls.Add(this.exitbtn);
            this.dragline.LeftSahddow = false;
            this.dragline.Location = new System.Drawing.Point(-5, -1);
            this.dragline.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dragline.Name = "dragline";
            this.dragline.RightSahddow = true;
            this.dragline.ShadowDepth = 20;
            this.dragline.Size = new System.Drawing.Size(1284, 59);
            this.dragline.TabIndex = 4;
            // 
            // Exit_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dragline);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Exit_application";
            this.Size = new System.Drawing.Size(1267, 58);
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            this.dragline.ResumeLayout(false);
            this.dragline.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal ns1.BunifuImageButton exitbtn;
        internal System.Windows.Forms.Label Label2;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuCards dragline;
    }
}
