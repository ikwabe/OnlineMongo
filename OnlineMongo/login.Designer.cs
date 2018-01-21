namespace OnlineMongo
{
    partial class login
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.loginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.signUpLink = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pwd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.forgetPwdLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.animate = new System.Windows.Forms.Timer(this.components);
            this.annimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
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
            this.Headerpanel.Controls.Add(this.closeBtn);
            this.annimator.SetDecoration(this.Headerpanel, BunifuAnimatorNS.DecorationType.None);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(568, 52);
            this.Headerpanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annimator.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(529, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(36, 30);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // loginBtn
            // 
            this.loginBtn.ActiveBorderThickness = 1;
            this.loginBtn.ActiveCornerRadius = 20;
            this.loginBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.loginBtn.ActiveForecolor = System.Drawing.Color.RosyBrown;
            this.loginBtn.ActiveLineColor = System.Drawing.Color.Blue;
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.ButtonText = "Login";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.annimator.SetDecoration(this.loginBtn, BunifuAnimatorNS.DecorationType.None);
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.loginBtn.IdleBorderThickness = 1;
            this.loginBtn.IdleCornerRadius = 20;
            this.loginBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.loginBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.loginBtn.IdleLineColor = System.Drawing.Color.Honeydew;
            this.loginBtn.Location = new System.Drawing.Point(143, 431);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(255, 41);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.annimator.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(151, 477);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(183, 17);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Doesn`t have an account?";
            // 
            // signUpLink
            // 
            this.signUpLink.AutoSize = true;
            this.annimator.SetDecoration(this.signUpLink, BunifuAnimatorNS.DecorationType.None);
            this.signUpLink.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.signUpLink.Location = new System.Drawing.Point(340, 477);
            this.signUpLink.Name = "signUpLink";
            this.signUpLink.Size = new System.Drawing.Size(52, 17);
            this.signUpLink.TabIndex = 6;
            this.signUpLink.TabStop = true;
            this.signUpLink.Text = "Sign Up";
            this.signUpLink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.signUpLink_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.annimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(121, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.annimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(121, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.annimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(233, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 44);
            this.label7.TabIndex = 25;
            this.label7.Text = "Login";
            // 
            // pwd
            // 
            this.pwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pwd.BorderColorFocused = System.Drawing.Color.Blue;
            this.pwd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.pwd.BorderThickness = 1;
            this.pwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.annimator.SetDecoration(this.pwd, BunifuAnimatorNS.DecorationType.None);
            this.pwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwd.isPassword = true;
            this.pwd.Location = new System.Drawing.Point(124, 368);
            this.pwd.Margin = new System.Windows.Forms.Padding(4);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(295, 30);
            this.pwd.TabIndex = 26;
            this.pwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwd_KeyDown);
            // 
            // forgetPwdLink
            // 
            this.forgetPwdLink.AutoSize = true;
            this.annimator.SetDecoration(this.forgetPwdLink, BunifuAnimatorNS.DecorationType.None);
            this.forgetPwdLink.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetPwdLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.forgetPwdLink.Location = new System.Drawing.Point(214, 494);
            this.forgetPwdLink.Name = "forgetPwdLink";
            this.forgetPwdLink.Size = new System.Drawing.Size(105, 17);
            this.forgetPwdLink.TabIndex = 27;
            this.forgetPwdLink.TabStop = true;
            this.forgetPwdLink.Text = "Forget Password";
            this.forgetPwdLink.MouseClick += new System.Windows.Forms.MouseEventHandler(this.forgetPwdLink_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.annimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(151, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 28;
            // 
            // logopic
            // 
            this.logopic.BackColor = System.Drawing.Color.Transparent;
            this.annimator.SetDecoration(this.logopic, BunifuAnimatorNS.DecorationType.None);
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(124, 58);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(318, 128);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopic.TabIndex = 29;
            this.logopic.TabStop = false;
            // 
            // animate
            // 
            this.animate.Enabled = true;
            this.animate.Tick += new System.EventHandler(this.animate_Tick);
            // 
            // annimator
            // 
            this.annimator.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.annimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 20;
            animation1.Padding = new System.Windows.Forms.Padding(30);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.annimator.DefaultAnimation = animation1;
            this.annimator.TimeStep = 0.08F;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(568, 532);
            this.Controls.Add(this.logopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgetPwdLink);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUpLink);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.Headerpanel);
            this.annimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Headerpanel;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.LinkLabel signUpLink;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox pwd;
        private System.Windows.Forms.LinkLabel forgetPwdLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer animate;
        private BunifuAnimatorNS.BunifuTransition annimator;
        public System.Windows.Forms.PictureBox logopic;
    }
}

