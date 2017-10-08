namespace OnlineMongo
{
    partial class changePIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePIN));
            this.pinTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.logopic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changePINBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pinTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).BeginInit();
            this.SuspendLayout();
            // 
            // pinTextBox1
            // 
            this.pinTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.pinTextBox1.BeepOnError = true;
            this.pinTextBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinTextBox1.Location = new System.Drawing.Point(119, 215);
            this.pinTextBox1.Mask = "0000";
            this.pinTextBox1.Name = "pinTextBox1";
            this.pinTextBox1.PasswordChar = '•';
            this.pinTextBox1.PromptChar = '.';
            this.pinTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pinTextBox1.Size = new System.Drawing.Size(154, 41);
            this.pinTextBox1.TabIndex = 64;
            this.pinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pinTextBox1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.pinTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pinTextBox1_KeyDown);
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
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(403, 52);
            this.Headerpanel.TabIndex = 61;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(377, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(16, 15);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Headerpanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // logopic
            // 
            this.logopic.BackColor = System.Drawing.Color.Transparent;
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(119, 63);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(154, 89);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopic.TabIndex = 63;
            this.logopic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(139, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Enter New PIN";
            // 
            // changePINBtn
            // 
            this.changePINBtn.ActiveBorderThickness = 1;
            this.changePINBtn.ActiveCornerRadius = 20;
            this.changePINBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.changePINBtn.ActiveForecolor = System.Drawing.Color.RosyBrown;
            this.changePINBtn.ActiveLineColor = System.Drawing.Color.Blue;
            this.changePINBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.changePINBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changePINBtn.BackgroundImage")));
            this.changePINBtn.ButtonText = "Change PIN";
            this.changePINBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePINBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePINBtn.ForeColor = System.Drawing.SystemColors.Menu;
            this.changePINBtn.IdleBorderThickness = 1;
            this.changePINBtn.IdleCornerRadius = 20;
            this.changePINBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.changePINBtn.IdleForecolor = System.Drawing.Color.Honeydew;
            this.changePINBtn.IdleLineColor = System.Drawing.Color.Honeydew;
            this.changePINBtn.Location = new System.Drawing.Point(119, 264);
            this.changePINBtn.Margin = new System.Windows.Forms.Padding(5);
            this.changePINBtn.Name = "changePINBtn";
            this.changePINBtn.Size = new System.Drawing.Size(154, 41);
            this.changePINBtn.TabIndex = 65;
            this.changePINBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.changePINBtn.Click += new System.EventHandler(this.changePINBtn_Click);
            // 
            // pinTextBox2
            // 
            this.pinTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.pinTextBox2.BeepOnError = true;
            this.pinTextBox2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinTextBox2.Location = new System.Drawing.Point(119, 215);
            this.pinTextBox2.Mask = "0000";
            this.pinTextBox2.Name = "pinTextBox2";
            this.pinTextBox2.PasswordChar = '•';
            this.pinTextBox2.PromptChar = '.';
            this.pinTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pinTextBox2.Size = new System.Drawing.Size(154, 41);
            this.pinTextBox2.TabIndex = 66;
            this.pinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pinTextBox2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // changePIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(403, 373);
            this.Controls.Add(this.pinTextBox2);
            this.Controls.Add(this.changePINBtn);
            this.Controls.Add(this.pinTextBox1);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.logopic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "changePIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "changePIN";
            this.Load += new System.EventHandler(this.changePIN_Load);
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox pinTextBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Headerpanel;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 changePINBtn;
        private System.Windows.Forms.MaskedTextBox pinTextBox2;
    }
}