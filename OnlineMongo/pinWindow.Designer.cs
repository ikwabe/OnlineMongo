namespace OnlineMongo
{
    partial class pinWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pinWindow));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.optionBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pinBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pwdTextBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.logopic = new System.Windows.Forms.PictureBox();
            this.pinTextBox = new System.Windows.Forms.MaskedTextBox();
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
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(403, 52);
            this.Headerpanel.TabIndex = 40;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(369, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(31, 37);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(167, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Enter PIN";
            // 
            // optionBtn
            // 
            this.optionBtn.Activecolor = System.Drawing.Color.Transparent;
            this.optionBtn.BackColor = System.Drawing.Color.Transparent;
            this.optionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionBtn.BorderRadius = 0;
            this.optionBtn.ButtonText = "Switch to password";
            this.optionBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.optionBtn.DisabledColor = System.Drawing.Color.Gray;
            this.optionBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.optionBtn.Iconimage = null;
            this.optionBtn.Iconimage_right = null;
            this.optionBtn.Iconimage_right_Selected = null;
            this.optionBtn.Iconimage_Selected = null;
            this.optionBtn.IconMarginLeft = 0;
            this.optionBtn.IconMarginRight = 0;
            this.optionBtn.IconRightVisible = true;
            this.optionBtn.IconRightZoom = 0D;
            this.optionBtn.IconVisible = true;
            this.optionBtn.IconZoom = 90D;
            this.optionBtn.IsTab = false;
            this.optionBtn.Location = new System.Drawing.Point(130, 242);
            this.optionBtn.Name = "optionBtn";
            this.optionBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.optionBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.optionBtn.OnHoverTextColor = System.Drawing.Color.Blue;
            this.optionBtn.selected = false;
            this.optionBtn.Size = new System.Drawing.Size(154, 24);
            this.optionBtn.TabIndex = 48;
            this.optionBtn.Text = "Switch to password";
            this.optionBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optionBtn.Textcolor = System.Drawing.Color.DimGray;
            this.optionBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionBtn.Click += new System.EventHandler(this.optionBtn_Click);
            // 
            // pinBtn
            // 
            this.pinBtn.Activecolor = System.Drawing.Color.Transparent;
            this.pinBtn.BackColor = System.Drawing.Color.Transparent;
            this.pinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pinBtn.BorderRadius = 0;
            this.pinBtn.ButtonText = "Switch to PIN";
            this.pinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pinBtn.DisabledColor = System.Drawing.Color.Gray;
            this.pinBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.pinBtn.Iconimage = null;
            this.pinBtn.Iconimage_right = null;
            this.pinBtn.Iconimage_right_Selected = null;
            this.pinBtn.Iconimage_Selected = null;
            this.pinBtn.IconMarginLeft = 0;
            this.pinBtn.IconMarginRight = 0;
            this.pinBtn.IconRightVisible = true;
            this.pinBtn.IconRightZoom = 0D;
            this.pinBtn.IconVisible = true;
            this.pinBtn.IconZoom = 90D;
            this.pinBtn.IsTab = false;
            this.pinBtn.Location = new System.Drawing.Point(130, 242);
            this.pinBtn.Name = "pinBtn";
            this.pinBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.pinBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.pinBtn.OnHoverTextColor = System.Drawing.Color.Blue;
            this.pinBtn.selected = false;
            this.pinBtn.Size = new System.Drawing.Size(154, 24);
            this.pinBtn.TabIndex = 49;
            this.pinBtn.Text = "Switch to PIN";
            this.pinBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pinBtn.Textcolor = System.Drawing.Color.DimGray;
            this.pinBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinBtn.Click += new System.EventHandler(this.pinBtn_Click);
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.BorderColorFocused = System.Drawing.Color.Blue;
            this.pwdTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwdTextBox.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.pwdTextBox.BorderThickness = 3;
            this.pwdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdTextBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.pwdTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pwdTextBox.isPassword = true;
            this.pwdTextBox.Location = new System.Drawing.Point(83, 191);
            this.pwdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(240, 44);
            this.pwdTextBox.TabIndex = 51;
            this.pwdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pwdTextBox.OnValueChanged += new System.EventHandler(this.pwdTextBox_OnValueChanged);
            // 
            // logopic
            // 
            this.logopic.BackColor = System.Drawing.Color.Transparent;
            this.logopic.Image = ((System.Drawing.Image)(resources.GetObject("logopic.Image")));
            this.logopic.Location = new System.Drawing.Point(130, 58);
            this.logopic.Name = "logopic";
            this.logopic.Size = new System.Drawing.Size(154, 89);
            this.logopic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logopic.TabIndex = 52;
            this.logopic.TabStop = false;
            // 
            // pinTextBox
            // 
            this.pinTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.pinTextBox.BeepOnError = true;
            this.pinTextBox.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pinTextBox.Location = new System.Drawing.Point(130, 194);
            this.pinTextBox.Mask = "0000";
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.PasswordChar = '•';
            this.pinTextBox.PromptChar = '.';
            this.pinTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pinTextBox.Size = new System.Drawing.Size(154, 41);
            this.pinTextBox.TabIndex = 53;
            this.pinTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pinTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.pinTextBox.TextChanged += new System.EventHandler(this.pinTextBox_TextChanged);
            // 
            // pinWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(403, 373);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.logopic);
            this.Controls.Add(this.optionBtn);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinBtn);
            this.Controls.Add(this.pwdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pinWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "pinWindow";
            this.Load += new System.EventHandler(this.pinWindow_Load);
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logopic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Headerpanel;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton optionBtn;
        private Bunifu.Framework.UI.BunifuFlatButton pinBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox pwdTextBox;
        private System.Windows.Forms.PictureBox logopic;
        private System.Windows.Forms.MaskedTextBox pinTextBox;
    }
}