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
            this.lblDealerAnswer = new System.Windows.Forms.Label();
            this.lblDisplayOutcome = new System.Windows.Forms.Label();
            this.lblPlayerCard1 = new System.Windows.Forms.Label();
            this.lblDealerCard1 = new System.Windows.Forms.Label();
            this.lblPlayerCard3 = new System.Windows.Forms.Label();
            this.lblPlayerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard2 = new System.Windows.Forms.Label();
            this.lblDealerCard3 = new System.Windows.Forms.Label();
            this.lblPlayerCard5 = new System.Windows.Forms.Label();
            this.lblDealerCard4 = new System.Windows.Forms.Label();
            this.lblDealerCard5 = new System.Windows.Forms.Label();
            this.lblDealerCard6 = new System.Windows.Forms.Label();
            this.lblPlayerCard4 = new System.Windows.Forms.Label();
            this.lblPlayerCard6 = new System.Windows.Forms.Label();
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
            this.btnHit.Location = new System.Drawing.Point(544, 427);
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
            this.btnStay.Location = new System.Drawing.Point(227, 427);
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
            // lblDealerAnswer
            // 
            this.lblDealerAnswer.AutoSize = true;
            this.lblDealerAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerAnswer.Location = new System.Drawing.Point(397, 360);
            this.lblDealerAnswer.Name = "lblDealerAnswer";
            this.lblDealerAnswer.Size = new System.Drawing.Size(0, 24);
            this.lblDealerAnswer.TabIndex = 6;
            // 
            // lblDisplayOutcome
            // 
            this.lblDisplayOutcome.AutoSize = true;
            this.lblDisplayOutcome.BackColor = System.Drawing.Color.ForestGreen;
            this.lblDisplayOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayOutcome.Location = new System.Drawing.Point(384, 384);
            this.lblDisplayOutcome.Name = "lblDisplayOutcome";
            this.lblDisplayOutcome.Size = new System.Drawing.Size(95, 24);
            this.lblDisplayOutcome.TabIndex = 7;
            this.lblDisplayOutcome.Text = "Outcome";
            // 
            // lblPlayerCard1
            // 
            this.lblPlayerCard1.AutoSize = true;
            this.lblPlayerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard1.Location = new System.Drawing.Point(230, 215);
            this.lblPlayerCard1.Name = "lblPlayerCard1";
            this.lblPlayerCard1.Size = new System.Drawing.Size(37, 55);
            this.lblPlayerCard1.TabIndex = 8;
            this.lblPlayerCard1.Text = ".";
            // 
            // lblDealerCard1
            // 
            this.lblDealerCard1.AutoSize = true;
            this.lblDealerCard1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard1.Location = new System.Drawing.Point(464, 215);
            this.lblDealerCard1.Name = "lblDealerCard1";
            this.lblDealerCard1.Size = new System.Drawing.Size(37, 55);
            this.lblDealerCard1.TabIndex = 9;
            this.lblDealerCard1.Text = ".";
            // 
            // lblPlayerCard3
            // 
            this.lblPlayerCard3.AutoSize = true;
            this.lblPlayerCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard3.Location = new System.Drawing.Point(360, 215);
            this.lblPlayerCard3.Name = "lblPlayerCard3";
            this.lblPlayerCard3.Size = new System.Drawing.Size(37, 55);
            this.lblPlayerCard3.TabIndex = 11;
            this.lblPlayerCard3.Text = ".";
            // 
            // lblPlayerCard2
            // 
            this.lblPlayerCard2.AutoSize = true;
            this.lblPlayerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard2.Location = new System.Drawing.Point(302, 215);
            this.lblPlayerCard2.Name = "lblPlayerCard2";
            this.lblPlayerCard2.Size = new System.Drawing.Size(37, 55);
            this.lblPlayerCard2.TabIndex = 12;
            this.lblPlayerCard2.Text = ".";
            // 
            // lblDealerCard2
            // 
            this.lblDealerCard2.AutoSize = true;
            this.lblDealerCard2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard2.Location = new System.Drawing.Point(534, 215);
            this.lblDealerCard2.Name = "lblDealerCard2";
            this.lblDealerCard2.Size = new System.Drawing.Size(37, 55);
            this.lblDealerCard2.TabIndex = 13;
            this.lblDealerCard2.Text = ".";
            // 
            // lblDealerCard3
            // 
            this.lblDealerCard3.AutoSize = true;
            this.lblDealerCard3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard3.Location = new System.Drawing.Point(601, 215);
            this.lblDealerCard3.Name = "lblDealerCard3";
            this.lblDealerCard3.Size = new System.Drawing.Size(37, 55);
            this.lblDealerCard3.TabIndex = 14;
            this.lblDealerCard3.Text = ".";
            // 
            // lblPlayerCard5
            // 
            this.lblPlayerCard5.AutoSize = true;
            this.lblPlayerCard5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard5.Location = new System.Drawing.Point(298, 297);
            this.lblPlayerCard5.Name = "lblPlayerCard5";
            this.lblPlayerCard5.Size = new System.Drawing.Size(37, 55);
            this.lblPlayerCard5.TabIndex = 15;
            this.lblPlayerCard5.Text = ".";
            // 
            // lblDealerCard4
            // 
            this.lblDealerCard4.AutoSize = true;
            this.lblDealerCard4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard4.Location = new System.Drawing.Point(464, 298);
            this.lblDealerCard4.Name = "lblDealerCard4";
            this.lblDealerCard4.Size = new System.Drawing.Size(37, 55);
            this.lblDealerCard4.TabIndex = 16;
            this.lblDealerCard4.Text = ".";
            // 
            // lblDealerCard5
            // 
            this.lblDealerCard5.AutoSize = true;
            this.lblDealerCard5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard5.Location = new System.Drawing.Point(534, 298);
            this.lblDealerCard5.Name = "lblDealerCard5";
            this.lblDealerCard5.Size = new System.Drawing.Size(37, 55);
            this.lblDealerCard5.TabIndex = 17;
            this.lblDealerCard5.Text = ".";
            // 
            // lblDealerCard6
            // 
            this.lblDealerCard6.AutoSize = true;
            this.lblDealerCard6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerCard6.Location = new System.Drawing.Point(601, 297);
            this.lblDealerCard6.Name = "lblDealerCard6";
            this.lblDealerCard6.Size = new System.Drawing.Size(37, 55);
            this.lblDealerCard6.TabIndex = 18;
            this.lblDealerCard6.Text = ".";
            // 
            // lblPlayerCard4
            // 
            this.lblPlayerCard4.AutoSize = true;
            this.lblPlayerCard4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard4.Location = new System.Drawing.Point(230, 297);
            this.lblPlayerCard4.Name = "lblPlayerCard4";
            this.lblPlayerCard4.Size = new System.Drawing.Size(37, 55);
            this.lblPlayerCard4.TabIndex = 19;
            this.lblPlayerCard4.Text = ".";
            // 
            // lblPlayerCard6
            // 
            this.lblPlayerCard6.AutoSize = true;
            this.lblPlayerCard6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerCard6.Location = new System.Drawing.Point(360, 297);
            this.lblPlayerCard6.Name = "lblPlayerCard6";
            this.lblPlayerCard6.Size = new System.Drawing.Size(37, 55);
            this.lblPlayerCard6.TabIndex = 20;
            this.lblPlayerCard6.Text = ".";
            // 
            // frmSimple21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple21Maria.Properties.Resources.live_casino9;
            this.ClientSize = new System.Drawing.Size(659, 500);
            this.Controls.Add(this.lblPlayerCard6);
            this.Controls.Add(this.lblPlayerCard4);
            this.Controls.Add(this.lblDealerCard6);
            this.Controls.Add(this.lblDealerCard5);
            this.Controls.Add(this.lblDealerCard4);
            this.Controls.Add(this.lblPlayerCard5);
            this.Controls.Add(this.lblDealerCard3);
            this.Controls.Add(this.lblDealerCard2);
            this.Controls.Add(this.lblPlayerCard2);
            this.Controls.Add(this.lblPlayerCard3);
            this.Controls.Add(this.lblDealerCard1);
            this.Controls.Add(this.lblPlayerCard1);
            this.Controls.Add(this.lblDisplayOutcome);
            this.Controls.Add(this.lblDealerAnswer);
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
        private System.Windows.Forms.Label lblDealerAnswer;
        private System.Windows.Forms.Label lblDisplayOutcome;
        private System.Windows.Forms.Label lblPlayerCard1;
        private System.Windows.Forms.Label lblDealerCard1;
        private System.Windows.Forms.Label lblPlayerCard3;
        private System.Windows.Forms.Label lblPlayerCard2;
        private System.Windows.Forms.Label lblDealerCard2;
        private System.Windows.Forms.Label lblDealerCard3;
        private System.Windows.Forms.Label lblPlayerCard5;
        private System.Windows.Forms.Label lblDealerCard4;
        private System.Windows.Forms.Label lblDealerCard5;
        private System.Windows.Forms.Label lblDealerCard6;
        private System.Windows.Forms.Label lblPlayerCard4;
        private System.Windows.Forms.Label lblPlayerCard6;
    }
}

