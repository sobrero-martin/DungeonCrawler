namespace DungeonCrawler.FE
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btStart = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btPractice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStart.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btStart.Location = new System.Drawing.Point(174, 361);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(132, 39);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "START";
            this.btStart.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEdit.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEdit.Location = new System.Drawing.Point(341, 361);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(132, 39);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "EDIT";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btPractice
            // 
            this.btPractice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPractice.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPractice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btPractice.Location = new System.Drawing.Point(505, 361);
            this.btPractice.Name = "btPractice";
            this.btPractice.Size = new System.Drawing.Size(132, 39);
            this.btPractice.TabIndex = 3;
            this.btPractice.Text = "PRACTICE";
            this.btPractice.UseVisualStyleBackColor = true;
            this.btPractice.Click += new System.EventHandler(this.btPractice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DungeonCrawler.FE.Properties.Resources.title_letters;
            this.pictureBox1.Location = new System.Drawing.Point(271, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 236);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPractice);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btPractice;
    }
}