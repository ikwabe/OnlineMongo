namespace OnlineMongo
{
    partial class pic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pic));
            this.addPic = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.refreshBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // addPic
            // 
            this.addPic.Activecolor = System.Drawing.Color.Transparent;
            this.addPic.BackColor = System.Drawing.Color.Transparent;
            this.addPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addPic.BorderRadius = 0;
            this.addPic.ButtonText = "AddPhoto";
            this.addPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPic.DisabledColor = System.Drawing.Color.Transparent;
            this.addPic.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPic.Iconcolor = System.Drawing.Color.Transparent;
            this.addPic.Iconimage = null;
            this.addPic.Iconimage_right = null;
            this.addPic.Iconimage_right_Selected = null;
            this.addPic.Iconimage_Selected = null;
            this.addPic.IconMarginLeft = 0;
            this.addPic.IconMarginRight = 0;
            this.addPic.IconRightVisible = true;
            this.addPic.IconRightZoom = 0D;
            this.addPic.IconVisible = true;
            this.addPic.IconZoom = 90D;
            this.addPic.IsTab = false;
            this.addPic.Location = new System.Drawing.Point(352, 13);
            this.addPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addPic.Name = "addPic";
            this.addPic.Normalcolor = System.Drawing.Color.Transparent;
            this.addPic.OnHovercolor = System.Drawing.Color.Transparent;
            this.addPic.OnHoverTextColor = System.Drawing.Color.DimGray;
            this.addPic.selected = false;
            this.addPic.Size = new System.Drawing.Size(78, 30);
            this.addPic.TabIndex = 0;
            this.addPic.Text = "AddPhoto";
            this.addPic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addPic.Textcolor = System.Drawing.Color.DarkSlateGray;
            this.addPic.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPic.Click += new System.EventHandler(this.addPic_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.addPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 59);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(815, 290);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageActive = null;
            this.refreshBtn.Location = new System.Drawing.Point(3, 13);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(26, 30);
            this.refreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBtn.TabIndex = 1;
            this.refreshBtn.TabStop = false;
            this.refreshBtn.Zoom = 10;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "pic";
            this.Size = new System.Drawing.Size(815, 349);
            this.Load += new System.EventHandler(this.pic_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton addPic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuImageButton refreshBtn;
    }
}
