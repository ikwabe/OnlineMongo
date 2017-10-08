namespace OnlineMongo
{
    partial class verifyEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(verifyEmail));
            this.emailBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.emailPassPic = new System.Windows.Forms.PictureBox();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.emailTxt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.emailPassPic)).BeginInit();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBar
            // 
            this.emailBar.animated = false;
            this.emailBar.animationIterval = 20;
            this.emailBar.animationSpeed = 1;
            this.emailBar.BackColor = System.Drawing.Color.Transparent;
            this.emailBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emailBar.BackgroundImage")));
            this.emailBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.emailBar.ForeColor = System.Drawing.Color.SeaGreen;
            this.emailBar.LabelVisible = false;
            this.emailBar.LineProgressThickness = 2;
            this.emailBar.LineThickness = 3;
            this.emailBar.Location = new System.Drawing.Point(386, 67);
            this.emailBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.emailBar.MaxValue = 100;
            this.emailBar.Name = "emailBar";
            this.emailBar.ProgressBackColor = System.Drawing.Color.DimGray;
            this.emailBar.ProgressColor = System.Drawing.Color.WhiteSmoke;
            this.emailBar.Size = new System.Drawing.Size(33, 33);
            this.emailBar.TabIndex = 53;
            this.emailBar.Value = 50;
            this.emailBar.Visible = false;
            // 
            // emailPassPic
            // 
            this.emailPassPic.Image = ((System.Drawing.Image)(resources.GetObject("emailPassPic.Image")));
            this.emailPassPic.Location = new System.Drawing.Point(389, 77);
            this.emailPassPic.Name = "emailPassPic";
            this.emailPassPic.Size = new System.Drawing.Size(30, 23);
            this.emailPassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailPassPic.TabIndex = 52;
            this.emailPassPic.TabStop = false;
            this.emailPassPic.Visible = false;
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(9)))), ((int)(((byte)(191)))));
            this.Headerpanel.Controls.Add(this.bunifuImageButton1);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(444, 23);
            this.Headerpanel.TabIndex = 47;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(425, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(16, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Enter the registerd Email";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // emailTxt
            // 
            this.emailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTxt.HintForeColor = System.Drawing.Color.Gray;
            this.emailTxt.HintText = "";
            this.emailTxt.isPassword = false;
            this.emailTxt.LineFocusedColor = System.Drawing.Color.Blue;
            this.emailTxt.LineIdleColor = System.Drawing.Color.Gray;
            this.emailTxt.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.emailTxt.LineThickness = 3;
            this.emailTxt.Location = new System.Drawing.Point(26, 67);
            this.emailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(346, 33);
            this.emailTxt.TabIndex = 54;
            this.emailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.emailTxt_KeyDown);
            // 
            // verifyEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(444, 117);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.emailBar);
            this.Controls.Add(this.emailPassPic);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "verifyEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verifyEmail";
            this.Load += new System.EventHandler(this.verifyEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailPassPic)).EndInit();
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCircleProgressbar emailBar;
        private System.Windows.Forms.PictureBox emailPassPic;
        private System.Windows.Forms.Panel Headerpanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox emailTxt;
    }
}