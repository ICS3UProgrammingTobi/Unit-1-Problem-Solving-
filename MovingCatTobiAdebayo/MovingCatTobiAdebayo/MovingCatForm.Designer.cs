namespace MovingCatTobiAdebayo
{
    partial class frmMovingCat
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
            this.mnuExitCat = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.mnuExitCat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuExitCat
            // 
            this.mnuExitCat.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuExitCat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.mnuExitCat.Location = new System.Drawing.Point(0, 0);
            this.mnuExitCat.Name = "mnuExitCat";
            this.mnuExitCat.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuExitCat.Size = new System.Drawing.Size(264, 28);
            this.mnuExitCat.TabIndex = 1;
            this.mnuExitCat.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(46, 24);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(116, 26);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(45, 24);
            this.mniCat.Text = "Cat";
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(126, 26);
            this.mniCat1.Text = "cat 1";
            this.mniCat1.Click += new System.EventHandler(this.MniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(126, 26);
            this.mniCat2.Text = "Cat 2";
            this.mniCat2.Click += new System.EventHandler(this.MniCat2_Click);
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatTobiAdebayo.Properties.Resources.cat1;
            this.picCat.Location = new System.Drawing.Point(55, 62);
            this.picCat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(148, 161);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 2;
            this.picCat.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 289);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuExitCat);
            this.MainMenuStrip = this.mnuExitCat;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat ";
            this.mnuExitCat.ResumeLayout(false);
            this.mnuExitCat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuExitCat;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox picCat;
    }
}

