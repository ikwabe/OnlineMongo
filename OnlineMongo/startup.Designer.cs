namespace OnlineMongo
{
    partial class startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startup));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressB = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressB
            // 
            this.progressB.animated = false;
            this.progressB.animationIterval = 20;
            this.progressB.animationSpeed = 10;
            this.progressB.BackColor = System.Drawing.Color.Transparent;
            this.progressB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressB.BackgroundImage")));
            this.progressB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progressB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressB.LabelVisible = false;
            this.progressB.LineProgressThickness = 12;
            this.progressB.LineThickness = 8;
            this.progressB.Location = new System.Drawing.Point(70, 65);
            this.progressB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progressB.MaxValue = 100;
            this.progressB.Name = "progressB";
            this.progressB.ProgressBackColor = System.Drawing.Color.DimGray;
            this.progressB.ProgressColor = System.Drawing.Color.LightGray;
            this.progressB.Size = new System.Drawing.Size(148, 148);
            this.progressB.TabIndex = 0;
            this.progressB.Value = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 45;
            this.label1.Text = "Loading...";
            // 
            // startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(293, 231);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "startup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "startup";
            this.Load += new System.EventHandler(this.startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progressB;
        private System.Windows.Forms.Label label1;
    }
}