namespace Simple21Maria
{
    partial class frmSimple21
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimple21));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStay = new System.Windows.Forms.Button();
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDisplayOutcome = new System.Windows.Forms.Label();
            this.lblPlayerCard1 = new System.Windows.Forms.Label();
            this.lblDealerCard1 = new System.Windows.Forms.Label();
            this.lblPlayerCard3 = new System.Windows.Forms.Label();
            this.lblPlayerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard3 = new System.Windows.Forms.Label();
            this.lblDTitle = new System.Windows.Forms.Label();
            this.lblPTitle = new System.Windows.Forms.Label();
            this.lbldealersubtotal = new System.Windows.Forms.Label();
            this.lblplayersubtotal = new System.Windows.Forms.Label();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(370, 141);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 44);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.UseWaitCursor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(532, 427);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(90, 33);
            this.btnHit.TabIndex = 1;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStay
            // 
            this.btnStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStay.Location = new System.Drawing.Point(244, 427);
            this.btnStay.Name = "btnStay";
            this.btnStay.Size = new System.Drawing.Size(87, 33);
            this.btnStay.TabIndex = 2;
            this.btnStay.Text = "Stay";
            this.btnStay.UseVisualStyleBackColor = true;
            this.btnStay.Click += new System.EventHandler(this.btnStay_Click);
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(659, 24);
            this.mnuFile.TabIndex = 4;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(132, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // lblDisplayOutcome
            // 
            this.lblDisplayOutcome.AutoSize = true;
            this.lblDisplayOutcome.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDisplayOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayOutcome.Location = new System.Drawing.Point(387, 384);
            this.lblDisplayOutcome.Name = "lblDisplayOutcome";
            this.lblDisplayOutcome.Size = new System.Drawing.Size(95, 24);
            this.lblDisplayOutcome.TabIndex = 7;
            this.lblDisplayOutcome.Text = "Outcome";
            // 
            // lblPlayerCard1
            // 
            this.lblPlayerCard1.AutoSize = true;
            this.lblPlayerCard1.BackColor = System.Drawing.Color.ForestGreen;
            this.lblPlayerCard1.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard1.Location = new System.Drawing.Point(208, 215);
            this.lblPlayerCard1.Name = "lblPlayerCard1";
            this.lblPlayerCard1.Size = new System.Drawing.Size(0, 75);
            this.lblPlayerCard1.TabIndex = 8;
            // 
            // lblDealerCard1
            // 
            this.lblDealerCard1.AutoSize = true;
            this.lblDealerCard1.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDealerCard1.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard1.Location = new System.Drawing.Point(543, 215);
            this.lblDealerCard1.Name = "lblDealerCard1";
            this.lblDealerCard1.Size = new System.Drawing.Size(0, 75);
            this.lblDealerCard1.TabIndex = 9;
            // 
            // lblPlayerCard3
            // 
            this.lblPlayerCard3.AutoSize = true;
            this.lblPlayerCard3.BackColor = System.Drawing.Color.ForestGreen;
            this.lblPlayerCard3.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard3.Location = new System.Drawing.Point(264, 311);
            this.lblPlayerCard3.Name = "lblPlayerCard3";
            this.lblPlayerCard3.Size = new System.Drawing.Size(0, 75);
            this.lblPlayerCard3.TabIndex = 11;
            // 
            // lblPlayerCard2
            // 
            this.lblPlayerCard2.AutoSize = true;
            this.lblPlayerCard2.BackColor = System.Drawing.Color.ForestGreen;
            this.lblPlayerCard2.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard2.Location = new System.Drawing.Point(315, 215);
            this.lblPlayerCard2.Name = "lblPlayerCard2";
            this.lblPlayerCard2.Size = new System.Drawing.Size(0, 75);
            this.lblPlayerCard2.TabIndex = 12;
            // 
            // lblDealerCard2
            // 
            this.lblDealerCard2.AutoSize = true;
            this.lblDealerCard2.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDealerCard2.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard2.Location = new System.Drawing.Point(597, 304);
            this.lblDealerCard2.Name = "lblDealerCard2";
            this.lblDealerCard2.Size = new System.Drawing.Size(0, 75);
            this.lblDealerCard2.TabIndex = 13;
            // 
            // lblDealerCard3
            // 
            this.lblDealerCard3.AutoSize = true;
            this.lblDealerCard3.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDealerCard3.Font = new System.Drawing.Font("Rosewood Std Regular", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard3.Location = new System.Drawing.Point(494, 304);
            this.lblDealerCard3.Name = "lblDealerCard3";
            this.lblDealerCard3.Size = new System.Drawing.Size(0, 75);
            this.lblDealerCard3.TabIndex = 14;
            // 
            // lblDTitle
            // 
            this.lblDTitle.AutoSize = true;
            this.lblDTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDTitle.Font = new System.Drawing.Font("Rosewood Std Regular", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblDTitle.Location = new System.Drawing.Point(509, 144);
            this.lblDTitle.Name = "lblDTitle";
            this.lblDTitle.Size = new System.Drawing.Size(138, 41);
            this.lblDTitle.TabIndex = 16;
            this.lblDTitle.Text = "Dealer";
            // 
            // lblPTitle
            // 
            this.lblPTitle.AutoSize = true;
            this.lblPTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.lblPTitle.Font = new System.Drawing.Font("Rosewood Std Regular", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPTitle.ForeColor = System.Drawing.Color.Maroon;
            this.lblPTitle.Location = new System.Drawing.Point(223, 144);
            this.lblPTitle.Name = "lblPTitle";
            this.lblPTitle.Size = new System.Drawing.Size(134, 41);
            this.lblPTitle.TabIndex = 15;
            this.lblPTitle.Text = "Player";
            // 
            // lbldealersubtotal
            // 
            this.lbldealersubtotal.AutoSize = true;
            this.lbldealersubtotal.BackColor = System.Drawing.Color.ForestGreen;
            this.lbldealersubtotal.Font = new System.Drawing.Font("Racer", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldealersubtotal.Location = new System.Drawing.Point(512, 383);
            this.lbldealersubtotal.Name = "lbldealersubtotal";
            this.lbldealersubtotal.Size = new System.Drawing.Size(0, 23);
            this.lbldealersubtotal.TabIndex = 17;
            // 
            // lblplayersubtotal
            // 
            this.lblplayersubtotal.AutoSize = true;
            this.lblplayersubtotal.BackColor = System.Drawing.Color.ForestGreen;
            this.lblplayersubtotal.Font = new System.Drawing.Font("Racer", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayersubtotal.Location = new System.Drawing.Point(357, 383);
            this.lblplayersubtotal.Name = "lblplayersubtotal";
            this.lblplayersubtotal.Size = new System.Drawing.Size(0, 23);
            this.lblplayersubtotal.TabIndex = 18;
            // 
            // frmSimple21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple21Maria.Properties.Resources.live_casino9;
            this.ClientSize = new System.Drawing.Size(659, 500);
            this.Controls.Add(this.lblplayersubtotal);
            this.Controls.Add(this.lbldealersubtotal);
            this.Controls.Add(this.lblDTitle);
            this.Controls.Add(this.lblPTitle);
            this.Controls.Add(this.lblDealerCard3);
            this.Controls.Add(this.lblDealerCard2);
            this.Controls.Add(this.lblPlayerCard2);
            this.Controls.Add(this.lblPlayerCard3);
            this.Controls.Add(this.lblDealerCard1);
            this.Controls.Add(this.lblPlayerCard1);
            this.Controls.Add(this.lblDisplayOutcome);
            this.Controls.Add(this.btnStay);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.mnuFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSimple21";
            this.Text = "Simple Blackjack";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStay;
        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Label lblDisplayOutcome;
        private System.Windows.Forms.Label lblPlayerCard1;
        private System.Windows.Forms.Label lblDealerCard1;
        private System.Windows.Forms.Label lblPlayerCard3;
        private System.Windows.Forms.Label lblPlayerCard2;
        private System.Windows.Forms.Label lblDealerCard2;
        private System.Windows.Forms.Label lblDealerCard3;
        private System.Windows.Forms.Label lblDTitle;
        private System.Windows.Forms.Label lblPTitle;
        private System.Windows.Forms.Label lbldealersubtotal;
        private System.Windows.Forms.Label lblplayersubtotal;
    }
}

