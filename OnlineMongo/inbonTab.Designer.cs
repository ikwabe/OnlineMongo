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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.refreshBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.refreshBar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.backBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emailsList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailsList)).BeginInit();
            this.SuspendLayout();
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageActive = null;
            this.refreshBtn.Location = new System.Drawing.Point(155, 18);
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
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.refreshBar);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 56);
            this.panel1.TabIndex = 4;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageActive = null;
            this.deleteBtn.Location = new System.Drawing.Point(190, 18);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(29, 24);
            this.deleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.TabStop = false;
            this.deleteBtn.Zoom = 10;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageActive = null;
            this.backBtn.Location = new System.Drawing.Point(155, 18);
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
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inbox";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.emailsList);
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1238, 282);
            this.panel2.TabIndex = 5;
            // 
            // emailsList
            // 
            this.emailsList.AllowUserToAddRows = false;
            this.emailsList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.emailsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.emailsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.emailsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.emailsList.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.emailsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.emailsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.emailsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.emailsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.emailsList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.emailsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailsList.DoubleBuffered = true;
            this.emailsList.EnableHeadersVisualStyles = false;
            this.emailsList.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.emailsList.HeaderForeColor = System.Drawing.Color.Gray;
            this.emailsList.Location = new System.Drawing.Point(0, 0);
            this.emailsList.MultiSelect = false;
            this.emailsList.Name = "emailsList";
            this.emailsList.ReadOnly = true;
            this.emailsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.emailsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.emailsList.Size = new System.Drawing.Size(1238, 282);
            this.emailsList.TabIndex = 5;
            this.emailsList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.emailsList_CellClick_1);
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
            this.richTextBox1.Size = new System.Drawing.Size(880, 245);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
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
            ((System.ComponentModel.ISupportInitialize)(this.emailsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton refreshBtn;
        private Bunifu.Framework.UI.BunifuCircleProgressbar refreshBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid emailsList;
        private Bunifu.Framework.UI.BunifuImageButton backBtn;
        private Bunifu.Framework.UI.BunifuImageButton deleteBtn;
        private System.Windows.Forms.Timer timer1;
    }
}
