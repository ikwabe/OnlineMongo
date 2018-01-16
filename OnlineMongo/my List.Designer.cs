namespace OnlineMongo
{
    partial class my_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(my_List));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.sendBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.emailTxt);
            this.panel2.Controls.Add(this.sendBtn);
            this.panel2.Controls.Add(this.CancelBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 98);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 347);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 347);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Activecolor = System.Drawing.Color.Gray;
            this.CancelBtn.BackColor = System.Drawing.Color.Silver;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.BorderRadius = 5;
            this.CancelBtn.ButtonText = "Cancel";
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CancelBtn.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CancelBtn.Iconimage = null;
            this.CancelBtn.Iconimage_right = null;
            this.CancelBtn.Iconimage_right_Selected = null;
            this.CancelBtn.Iconimage_Selected = null;
            this.CancelBtn.IconMarginLeft = 0;
            this.CancelBtn.IconMarginRight = 0;
            this.CancelBtn.IconRightVisible = true;
            this.CancelBtn.IconRightZoom = 0D;
            this.CancelBtn.IconVisible = true;
            this.CancelBtn.IconZoom = 70D;
            this.CancelBtn.IsTab = false;
            this.CancelBtn.Location = new System.Drawing.Point(13, 44);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Normalcolor = System.Drawing.Color.Silver;
            this.CancelBtn.OnHovercolor = System.Drawing.Color.DarkGray;
            this.CancelBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CancelBtn.selected = false;
            this.CancelBtn.Size = new System.Drawing.Size(85, 38);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelBtn.Textcolor = System.Drawing.Color.DimGray;
            this.CancelBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_1);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageActive = null;
            this.refreshBtn.Location = new System.Drawing.Point(295, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(36, 23);
            this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBtn.TabIndex = 15;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Zoom = 10;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Activecolor = System.Drawing.Color.Gray;
            this.sendBtn.BackColor = System.Drawing.Color.Silver;
            this.sendBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendBtn.BorderRadius = 5;
            this.sendBtn.ButtonText = "Send";
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.DisabledColor = System.Drawing.Color.Gray;
            this.sendBtn.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.sendBtn.IconZoom = 70D;
            this.sendBtn.IsTab = false;
            this.sendBtn.Location = new System.Drawing.Point(533, 41);
            this.sendBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Normalcolor = System.Drawing.Color.Silver;
            this.sendBtn.OnHovercolor = System.Drawing.Color.DarkGray;
            this.sendBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.sendBtn.selected = false;
            this.sendBtn.Size = new System.Drawing.Size(85, 38);
            this.sendBtn.TabIndex = 12;
            this.sendBtn.Text = "Send";
            this.sendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sendBtn.Textcolor = System.Drawing.Color.DimGray;
            this.sendBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailTxt.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(187, 52);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(340, 30);
            this.emailTxt.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(155, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 17);
            this.label12.TabIndex = 91;
            this.label12.Text = "To:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Silver;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(183, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 23);
            this.textBox1.TabIndex = 92;
            // 
            // my_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(628, 497);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "my_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "my_List";
            this.Load += new System.EventHandler(this.my_List_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton CancelBtn;
        private Bunifu.Framework.UI.BunifuImageButton refreshBtn;
        private Bunifu.Framework.UI.BunifuFlatButton sendBtn;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
    }
}