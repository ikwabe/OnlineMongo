namespace OnlineMongo
{
    partial class changePwd
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePwd));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.oldPwd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.changePwdBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.newPwd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtPwd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
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
            this.animator.SetDecoration(this.Headerpanel, BunifuAnimatorNS.DecorationType.None);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(569, 52);
            this.Headerpanel.TabIndex = 27;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(541, 12);
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
            // oldPwd
            // 
            this.oldPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.oldPwd.BorderColorFocused = System.Drawing.Color.Blue;
            this.oldPwd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldPwd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.oldPwd.BorderThickness = 1;
            this.oldPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.oldPwd, BunifuAnimatorNS.DecorationType.None);
            this.oldPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.oldPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.oldPwd.isPassword = true;
            this.oldPwd.Location = new System.Drawing.Point(114, 358);
            this.oldPwd.Margin = new System.Windows.Forms.Padding(4);
            this.oldPwd.Name = "oldPwd";
            this.oldPwd.Size = new System.Drawing.Size(295, 30);
            this.oldPwd.TabIndex = 35;
            this.oldPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.animator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(106, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 44);
            this.label7.TabIndex = 34;
            this.label7.Text = "Change Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.animator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(111, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Old Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(111, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Email";
            // 
            // changePwdBtn
            // 
            this.changePwdBtn.ActiveBorderThickness = 1;
            this.changePwdBtn.ActiveCornerRadius = 20;
            this.changePwdBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.changePwdBtn.ActiveForecolor = System.Drawing.Color.RosyBrown;
            this.changePwdBtn.ActiveLineColor = System.Drawing.Color.Blue;
            this.changePwdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.changePwdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePwdBtn.BackgroundImage")));
            this.changePwdBtn.ButtonText = "Change Password";
            this.changePwdBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.changePwdBtn, BunifuAnimatorNS.DecorationType.None);
            this.changePwdBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePwdBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.changePwdBtn.IdleBorderThickness = 1;
            this.changePwdBtn.IdleCornerRadius = 20;
            this.changePwdBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.changePwdBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.changePwdBtn.IdleLineColor = System.Drawing.Color.Honeydew;
            this.changePwdBtn.Location = new System.Drawing.Point(135, 545);
            this.changePwdBtn.Margin = new System.Windows.Forms.Padding(5);
            this.changePwdBtn.Name = "changePwdBtn";
            this.changePwdBtn.Size = new System.Drawing.Size(255, 41);
            this.changePwdBtn.TabIndex = 29;
            this.changePwdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePwdBtn.Click += new System.EventHandler(this.changePwdBtn_Click);
            // 
            // email
            // 
            this.email.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.email, BunifuAnimatorNS.DecorationType.None);
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.HintForeColor = System.Drawing.Color.DarkGray;
            this.email.HintText = "";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.Blue;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(114, 272);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(295, 33);
            this.email.TabIndex = 28;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newPwd
            // 
            this.newPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.newPwd.BorderColorFocused = System.Drawing.Color.Blue;
            this.newPwd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPwd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.newPwd.BorderThickness = 1;
            this.newPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.newPwd, BunifuAnimatorNS.DecorationType.None);
            this.newPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newPwd.isPassword = true;
            this.newPwd.Location = new System.Drawing.Point(114, 432);
            this.newPwd.Margin = new System.Windows.Forms.Padding(4);
            this.newPwd.Name = "newPwd";
            this.newPwd.Size = new System.Drawing.Size(295, 30);
            this.newPwd.TabIndex = 37;
            this.newPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(111, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "New Password";
            // 
            // rtPwd
            // 
            this.rtPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rtPwd.BorderColorFocused = System.Drawing.Color.Blue;
            this.rtPwd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtPwd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.rtPwd.BorderThickness = 1;
            this.rtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.animator.SetDecoration(this.rtPwd, BunifuAnimatorNS.DecorationType.None);
            this.rtPwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.rtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtPwd.isPassword = true;
            this.rtPwd.Location = new System.Drawing.Point(114, 506);
            this.rtPwd.Margin = new System.Windows.Forms.Padding(4);
            this.rtPwd.Name = "rtPwd";
            this.rtPwd.Size = new System.Drawing.Size(295, 30);
            this.rtPwd.TabIndex = 39;
            this.rtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(111, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Retype New Password";
            // 
            // logopic
            // 
            this.animator.SetDecoration(this.logopic, BunifuAnimatorNS.DecorationType.None);
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(136, 58);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(302, 114);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopic.TabIndex = 40;
            this.logopic.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // animator
            // 
            this.animator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.animator.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation2;
            this.animator.TimeStep = 0.08F;
            // 
            // changePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(569, 649);
            this.Controls.Add(this.logopic);
            this.Controls.Add(this.rtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPwd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.oldPwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.changePwdBtn);
            this.Controls.Add(this.email);
            this.animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changePwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "changePwd";
            this.Load += new System.EventHandler(this.changePwd_Load);
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Headerpanel;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMetroTextbox oldPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 changePwdBtn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMetroTextbox rtPwd;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox newPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logopic;
        private BunifuAnimatorNS.BunifuTransition animator;
        private System.Windows.Forms.Timer timer1;
    }
}