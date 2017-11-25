namespace OnlineMongo
{
    partial class postb
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.photo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.photo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 51);
            this.panel1.TabIndex = 0;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(9)))), ((int)(((byte)(191)))));
            this.line.LineThickness = 3;
            this.line.Location = new System.Drawing.Point(20, 38);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(95, 4);
            this.line.TabIndex = 12;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // photo
            // 
            this.photo.AutoSize = true;
            this.photo.BackColor = System.Drawing.Color.Transparent;
            this.photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.photo.Location = new System.Drawing.Point(17, 19);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(103, 19);
            this.photo.TabIndex = 13;
            this.photo.Text = "Upload Photo";
            this.photo.Click += new System.EventHandler(this.photo_Click);
            // 
            // postb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "postb";
            this.Size = new System.Drawing.Size(815, 349);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private Bunifu.Framework.UI.BunifuCustomLabel photo;
    }
}
