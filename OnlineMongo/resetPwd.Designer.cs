namespace OnlineMongo
{
    partial class resetPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resetPwd));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.resLb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.resetPwdBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.secword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.secwordLb = new System.Windows.Forms.Label();
            this.secwordPassPic = new System.Windows.Forms.PictureBox();
            this.secwordBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.emailBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.emailPassPic = new System.Windows.Forms.PictureBox();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secwordPassPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPassPic)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(9)))), ((int)(((byte)(191)))));
            this.Headerpanel.Controls.Add(this.bunifuImageButton1);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(444, 52);
            this.Headerpanel.TabIndex = 29;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(418, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(16, 15);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(85, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(111, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 36);
            this.label7.TabIndex = 36;
            this.label7.Text = "Reset Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Enter the registerd Email";
            // 
            // resLb
            // 
            this.resLb.AutoSize = true;
            this.resLb.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLb.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.resLb.Location = new System.Drawing.Point(95, 406);
            this.resLb.Name = "resLb";
            this.resLb.Size = new System.Drawing.Size(234, 17);
            this.resLb.TabIndex = 32;
            this.resLb.Text = "Remember to keep your password.";
            this.resLb.Visible = false;
            // 
            // resetPwdBtn
            // 
            this.resetPwdBtn.ActiveBorderThickness = 1;
            this.resetPwdBtn.ActiveCornerRadius = 20;
            this.resetPwdBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.resetPwdBtn.ActiveForecolor = System.Drawing.Color.RosyBrown;
            this.resetPwdBtn.ActiveLineColor = System.Drawing.Color.Blue;
            this.resetPwdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.resetPwdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetPwdBtn.BackgroundImage")));
            this.resetPwdBtn.ButtonText = "Reset Password";
            this.resetPwdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetPwdBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPwdBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.resetPwdBtn.IdleBorderThickness = 1;
            this.resetPwdBtn.IdleCornerRadius = 20;
            this.resetPwdBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.resetPwdBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.resetPwdBtn.IdleLineColor = System.Drawing.Color.Honeydew;
            this.resetPwdBtn.Location = new System.Drawing.Point(55, 360);
            this.resetPwdBtn.Margin = new System.Windows.Forms.Padding(5);
            this.resetPwdBtn.Name = "resetPwdBtn";
            this.resetPwdBtn.Size = new System.Drawing.Size(310, 41);
            this.resetPwdBtn.TabIndex = 31;
            this.resetPwdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetPwdBtn.Visible = false;
            this.resetPwdBtn.Click += new System.EventHandler(this.resetPwdBtn_Click);
            // 
            // email
            // 
            this.email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.HintForeColor = System.Drawing.Color.DarkGray;
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Blue;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(31, 211);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(350, 33);
            this.email.TabIndex = 30;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.email.OnValueChanged += new System.EventHandler(this.email_OnValueChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // secword
            // 
            this.secword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.secword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.secword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secword.HintForeColor = System.Drawing.Color.DarkGray;
            this.secword.HintText = "";
            this.secword.isPassword = false;
            this.secword.LineFocusedColor = System.Drawing.Color.Blue;
            this.secword.LineIdleColor = System.Drawing.Color.Gray;
            this.secword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.secword.LineThickness = 3;
            this.secword.Location = new System.Drawing.Point(31, 300);
            this.secword.Margin = new System.Windows.Forms.Padding(4);
            this.secword.Name = "secword";
            this.secword.Size = new System.Drawing.Size(350, 33);
            this.secword.TabIndex = 41;
            this.secword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.secword.Visible = false;
            this.secword.OnValueChanged += new System.EventHandler(this.secword_OnValueChanged);
            // 
            // secwordLb
            // 
            this.secwordLb.AutoSize = true;
            this.secwordLb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secwordLb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.secwordLb.Location = new System.Drawing.Point(28, 267);
            this.secwordLb.Name = "secwordLb";
            this.secwordLb.Size = new System.Drawing.Size(165, 17);
            this.secwordLb.TabIndex = 42;
            this.secwordLb.Text = "What is your Childish name";
            this.secwordLb.Visible = false;
            // 
            // secwordPassPic
            // 
            this.secwordPassPic.Image = ((System.Drawing.Image)(resources.GetObject("secwordPassPic.Image")));
            this.secwordPassPic.Location = new System.Drawing.Point(391, 310);
            this.secwordPassPic.Name = "secwordPassPic";
            this.secwordPassPic.Size = new System.Drawing.Size(30, 23);
            this.secwordPassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.secwordPassPic.TabIndex = 43;
            this.secwordPassPic.TabStop = false;
            this.secwordPassPic.Visible = false;
            // 
            // secwordBar
            // 
            this.secwordBar.animated = false;
            this.secwordBar.animationIterval = 20;
            this.secwordBar.animationSpeed = 1;
            this.secwordBar.BackColor = System.Drawing.Color.Transparent;
            this.secwordBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secwordBar.BackgroundImage")));
            this.secwordBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.secwordBar.ForeColor = System.Drawing.Color.SeaGreen;
            this.secwordBar.LabelVisible = false;
            this.secwordBar.LineProgressThickness = 2;
            this.secwordBar.LineThickness = 3;
            this.secwordBar.Location = new System.Drawing.Point(388, 300);
            this.secwordBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.secwordBar.MaxValue = 100;
            this.secwordBar.Name = "secwordBar";
            this.secwordBar.ProgressBackColor = System.Drawing.Color.DimGray;
            this.secwordBar.ProgressColor = System.Drawing.Color.WhiteSmoke;
            this.secwordBar.Size = new System.Drawing.Size(33, 33);
            this.secwordBar.TabIndex = 44;
            this.secwordBar.Value = 50;
            this.secwordBar.Visible = false;
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
            this.emailBar.Location = new System.Drawing.Point(388, 211);
            this.emailBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.emailBar.MaxValue = 100;
            this.emailBar.Name = "emailBar";
            this.emailBar.ProgressBackColor = System.Drawing.Color.DimGray;
            this.emailBar.ProgressColor = System.Drawing.Color.WhiteSmoke;
            this.emailBar.Size = new System.Drawing.Size(33, 33);
            this.emailBar.TabIndex = 46;
            this.emailBar.Value = 50;
            this.emailBar.Visible = false;
            // 
            // emailPassPic
            // 
            this.emailPassPic.Image = ((System.Drawing.Image)(resources.GetObject("emailPassPic.Image")));
            this.emailPassPic.Location = new System.Drawing.Point(391, 221);
            this.emailPassPic.Name = "emailPassPic";
            this.emailPassPic.Size = new System.Drawing.Size(30, 23);
            this.emailPassPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailPassPic.TabIndex = 45;
            this.emailPassPic.TabStop = false;
            this.emailPassPic.Visible = false;
            // 
            // resetPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(444, 459);
            this.Controls.Add(this.emailBar);
            this.Controls.Add(this.emailPassPic);
            this.Controls.Add(this.resetPwdBtn);
            this.Controls.Add(this.resLb);
            this.Controls.Add(this.secwordBar);
            this.Controls.Add(this.secwordPassPic);
            this.Controls.Add(this.secwordLb);
            this.Controls.Add(this.secword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "resetPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "resetPwd";
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secwordPassPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPassPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Headerpanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel resLb;
        private Bunifu.Framework.UI.BunifuThinButton2 resetPwdBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox secword;
        private System.Windows.Forms.Label secwordLb;
        private Bunifu.Framework.UI.BunifuCircleProgressbar secwordBar;
        private System.Windows.Forms.PictureBox secwordPassPic;
        private Bunifu.Framework.UI.BunifuCircleProgressbar emailBar;
        private System.Windows.Forms.PictureBox emailPassPic;
    }
}