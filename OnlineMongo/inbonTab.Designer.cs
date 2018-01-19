namespace OnlineMongo
{
    partial class inbonTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inbonTab));
            this.refreshBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.refreshBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.replyBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.emailNumberLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.backBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageActive = null;
            this.refreshBtn.Location = new System.Drawing.Point(10, 13);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(29, 24);
            this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Zoom = 10;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // refreshBar
            // 
            this.refreshBar.animated = false;
            this.refreshBar.animationIterval = 30;
            this.refreshBar.animationSpeed = 1;
            this.refreshBar.BackColor = System.Drawing.Color.Transparent;
            this.refreshBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshBar.BackgroundImage")));
            this.refreshBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.refreshBar.ForeColor = System.Drawing.Color.SeaGreen;
            this.refreshBar.LabelVisible = false;
            this.refreshBar.LineProgressThickness = 3;
            this.refreshBar.LineThickness = 3;
            this.refreshBar.Location = new System.Drawing.Point(496, 13);
            this.refreshBar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.refreshBar.MaxValue = 100;
            this.refreshBar.Name = "refreshBar";
            this.refreshBar.ProgressBackColor = System.Drawing.SystemColors.Control;
            this.refreshBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.refreshBar.Size = new System.Drawing.Size(36, 36);
            this.refreshBar.TabIndex = 2;
            this.refreshBar.Value = 50;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.replyBtn);
            this.panel1.Controls.Add(this.emailNumberLabel);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.refreshBar);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 90);
            this.panel1.TabIndex = 4;
            // 
            // replyBtn
            // 
            this.replyBtn.ActiveBorderThickness = 1;
            this.replyBtn.ActiveCornerRadius = 20;
            this.replyBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.replyBtn.ActiveForecolor = System.Drawing.Color.Gray;
            this.replyBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.replyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.replyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("replyBtn.BackgroundImage")));
            this.replyBtn.ButtonText = "Reply";
            this.replyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.replyBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replyBtn.ForeColor = System.Drawing.Color.DimGray;
            this.replyBtn.IdleBorderThickness = 1;
            this.replyBtn.IdleCornerRadius = 20;
            this.replyBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.replyBtn.IdleForecolor = System.Drawing.Color.Black;
            this.replyBtn.IdleLineColor = System.Drawing.Color.DarkSlateBlue;
            this.replyBtn.Location = new System.Drawing.Point(392, 50);
            this.replyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replyBtn.Name = "replyBtn";
            this.replyBtn.Size = new System.Drawing.Size(76, 34);
            this.replyBtn.TabIndex = 89;
            this.replyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.replyBtn.Visible = false;
            this.replyBtn.Click += new System.EventHandler(this.replyBtn_Click);
            // 
            // emailNumberLabel
            // 
            this.emailNumberLabel.AutoSize = true;
            this.emailNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailNumberLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailNumberLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.emailNumberLabel.Location = new System.Drawing.Point(123, 56);
            this.emailNumberLabel.Name = "emailNumberLabel";
            this.emailNumberLabel.Size = new System.Drawing.Size(0, 25);
            this.emailNumberLabel.TabIndex = 7;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageActive = null;
            this.deleteBtn.Location = new System.Drawing.Point(45, 13);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(29, 24);
            this.deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Zoom = 10;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageActive = null;
            this.backBtn.Location = new System.Drawing.Point(10, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(29, 24);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 5;
            this.backBtn.TabStop = false;
            this.backBtn.Visible = false;
            this.backBtn.Zoom = 10;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inbox";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 248);
            this.panel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1238, 248);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(189, 6);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(880, 211);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inbonTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "inbonTab";
            this.Size = new System.Drawing.Size(1238, 338);
            this.Load += new System.EventHandler(this.inbonTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton refreshBtn;
        private Bunifu.Framework.UI.BunifuCircleProgressbar refreshBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuImageButton backBtn;
        private Bunifu.Framework.UI.BunifuImageButton deleteBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label emailNumberLabel;
        private Bunifu.Framework.UI.BunifuThinButton2 replyBtn;
    }
}
