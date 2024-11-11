namespace DungeonCrawler.FE
{
    partial class PracticeBattle
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.btAttack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btBack.Location = new System.Drawing.Point(-2, -2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(116, 32);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "<- MAIN MENU";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btAttack);
            this.panel1.Location = new System.Drawing.Point(-2, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 175);
            this.panel1.TabIndex = 10;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.Transparent;
            this.pbMain.Location = new System.Drawing.Point(307, 57);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(200, 223);
            this.pbMain.TabIndex = 9;
            this.pbMain.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Image = global::DungeonCrawler.FE.Properties.Resources.battleStage;
            this.pbBackground.Location = new System.Drawing.Point(-2, -2);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(803, 282);
            this.pbBackground.TabIndex = 11;
            this.pbBackground.TabStop = false;
            // 
            // btAttack
            // 
            this.btAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAttack.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAttack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAttack.Location = new System.Drawing.Point(329, 114);
            this.btAttack.Name = "btAttack";
            this.btAttack.Size = new System.Drawing.Size(132, 35);
            this.btAttack.TabIndex = 10;
            this.btAttack.Text = "ATTACK";
            this.btAttack.UseVisualStyleBackColor = true;
            this.btAttack.Click += new System.EventHandler(this.btAttack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "SKELETON";
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHP.Location = new System.Drawing.Point(12, 80);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(82, 24);
            this.lblHP.TabIndex = 12;
            this.lblHP.Text = "HP: 10";
            // 
            // PracticeBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PracticeBattle";
            this.Text = "PracticeBattle";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Button btAttack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHP;
    }
}