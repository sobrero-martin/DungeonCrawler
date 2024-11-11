namespace DungeonCrawler.FE
{
    partial class EditMenu
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
            this.btBack = new System.Windows.Forms.Button();
            this.btEditWeap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBack.Location = new System.Drawing.Point(-2, -2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(79, 39);
            this.btBack.TabIndex = 7;
            this.btBack.Text = "<- BACK";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btEditWeap
            // 
            this.btEditWeap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditWeap.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditWeap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEditWeap.Location = new System.Drawing.Point(321, 191);
            this.btEditWeap.Name = "btEditWeap";
            this.btEditWeap.Size = new System.Drawing.Size(152, 51);
            this.btEditWeap.TabIndex = 9;
            this.btEditWeap.Text = "EDIT WEAPONS";
            this.btEditWeap.UseVisualStyleBackColor = true;
            this.btEditWeap.Click += new System.EventHandler(this.btEditWeap_Click);
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btEditWeap);
            this.Controls.Add(this.btBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMenu";
            this.Text = "EditMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btEditWeap;
    }
}