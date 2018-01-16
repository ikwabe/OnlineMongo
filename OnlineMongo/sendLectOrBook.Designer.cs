namespace OnlineMongo
{
    partial class sendLectOrBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendLectOrBook));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.uploadBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.sendBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.closeBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.uploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.uploadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uploadBtn.BorderRadius = 5;
            this.uploadBtn.ButtonText = "Load";
            this.uploadBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uploadBtn.DisabledColor = System.Drawing.Color.Gray;
            this.uploadBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.uploadBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("uploadBtn.Iconimage")));
            this.uploadBtn.Iconimage_right = null;
            this.uploadBtn.Iconimage_right_Selected = null;
            this.uploadBtn.Iconimage_Selected = null;
            this.uploadBtn.IconMarginLeft = 0;
            this.uploadBtn.IconMarginRight = 0;
            this.uploadBtn.IconRightVisible = true;
            this.uploadBtn.IconRightZoom = 0D;
            this.uploadBtn.IconVisible = true;
            this.uploadBtn.IconZoom = 40D;
            this.uploadBtn.IsTab = false;
            this.uploadBtn.Location = new System.Drawing.Point(375, 24);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.uploadBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(9)))), ((int)(((byte)(191)))));
            this.uploadBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.uploadBtn.selected = false;
            this.uploadBtn.Size = new System.Drawing.Size(97, 30);
            this.uploadBtn.TabIndex = 47;
            this.uploadBtn.Text = "Load";
            this.uploadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uploadBtn.Textcolor = System.Drawing.Color.White;
            this.uploadBtn.TextFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Click += new System.EventHandler(this.uploadBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 23);
            this.textBox1.TabIndex = 48;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(50, 148);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(321, 30);
            this.emailTxt.TabIndex = 50;
            // 
            // sendBtn
            // 
            this.sendBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.sendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendBtn.BorderRadius = 5;
            this.sendBtn.ButtonText = "Send";
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sendBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.sendBtn.Iconimage = null;
            this.sendBtn.Iconimage_right = null;
            this.sendBtn.Iconimage_right_Selected = null;
            this.sendBtn.Iconimage_Selected = null;
            this.sendBtn.IconMarginLeft = 0;
            this.sendBtn.IconMarginRight = 0;
            this.sendBtn.IconRightVisible = true;
            this.sendBtn.IconRightZoom = 0D;
            this.sendBtn.IconVisible = true;
            this.sendBtn.IconZoom = 40D;
            this.sendBtn.IsTab = false;
            this.sendBtn.Location = new System.Drawing.Point(375, 154);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.sendBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(9)))), ((int)(((byte)(191)))));
            this.sendBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sendBtn.selected = false;
            this.sendBtn.Size = new System.Drawing.Size(97, 30);
            this.sendBtn.TabIndex = 51;
            this.sendBtn.Text = "Send";
            this.sendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendBtn.Textcolor = System.Drawing.Color.White;
            this.sendBtn.TextFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.BorderRadius = 5;
            this.closeBtn.ButtonText = "Close";
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.DisabledColor = System.Drawing.Color.Gray;
            this.closeBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.closeBtn.Iconimage = null;
            this.closeBtn.Iconimage_right = null;
            this.closeBtn.Iconimage_right_Selected = null;
            this.closeBtn.Iconimage_Selected = null;
            this.closeBtn.IconMarginLeft = 0;
            this.closeBtn.IconMarginRight = 0;
            this.closeBtn.IconRightVisible = true;
            this.closeBtn.IconRightZoom = 0D;
            this.closeBtn.IconVisible = true;
            this.closeBtn.IconZoom = 40D;
            this.closeBtn.IsTab = false;
            this.closeBtn.Location = new System.Drawing.Point(375, 257);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.closeBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(9)))), ((int)(((byte)(191)))));
            this.closeBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.closeBtn.selected = false;
            this.closeBtn.Size = new System.Drawing.Size(97, 30);
            this.closeBtn.TabIndex = 52;
            this.closeBtn.Text = "Close";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBtn.Textcolor = System.Drawing.Color.White;
            this.closeBtn.TextFont = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 17);
            this.label12.TabIndex = 90;
            this.label12.Text = "To:";
            // 
            // sendLectOrBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 299);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uploadBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sendLectOrBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sendLectOrBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Bunifu.Framework.UI.BunifuFlatButton closeBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sendBtn;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuFlatButton uploadBtn;
        private System.Windows.Forms.Label label12;
    }
}