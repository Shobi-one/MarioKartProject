
namespace HorseRacing
{
    partial class CharacterSelectView
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
            this.trackPicker = new System.Windows.Forms.GroupBox();
            this.pboxBack4 = new System.Windows.Forms.PictureBox();
            this.pboxBack3 = new System.Windows.Forms.PictureBox();
            this.pboxBack2 = new System.Windows.Forms.PictureBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.rdbRainbowRoad = new System.Windows.Forms.RadioButton();
            this.rdbBowsersCastle = new System.Windows.Forms.RadioButton();
            this.rdbChocoIsland = new System.Windows.Forms.RadioButton();
            this.pboxBack1 = new System.Windows.Forms.PictureBox();
            this.rdbMariocircuit = new System.Windows.Forms.RadioButton();
            this.lblChoose = new System.Windows.Forms.Label();
            this.txtBetAmount = new System.Windows.Forms.TextBox();
            this.trackPicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackPicker
            // 
            this.trackPicker.BackColor = System.Drawing.Color.Transparent;
            this.trackPicker.BackgroundImage = global::HorseRacing.Properties.Resources.selection;
            this.trackPicker.Controls.Add(this.txtBetAmount);
            this.trackPicker.Controls.Add(this.pboxBack4);
            this.trackPicker.Controls.Add(this.pboxBack3);
            this.trackPicker.Controls.Add(this.pboxBack2);
            this.trackPicker.Controls.Add(this.btnBet);
            this.trackPicker.Controls.Add(this.rdbRainbowRoad);
            this.trackPicker.Controls.Add(this.rdbBowsersCastle);
            this.trackPicker.Controls.Add(this.rdbChocoIsland);
            this.trackPicker.Controls.Add(this.pboxBack1);
            this.trackPicker.Controls.Add(this.rdbMariocircuit);
            this.trackPicker.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackPicker.ForeColor = System.Drawing.Color.Transparent;
            this.trackPicker.Location = new System.Drawing.Point(5, 40);
            this.trackPicker.Name = "trackPicker";
            this.trackPicker.Size = new System.Drawing.Size(775, 281);
            this.trackPicker.TabIndex = 3;
            this.trackPicker.TabStop = false;
            // 
            // pboxBack4
            // 
            this.pboxBack4.BackgroundImage = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack4.Image = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack4.Location = new System.Drawing.Point(571, 111);
            this.pboxBack4.Name = "pboxBack4";
            this.pboxBack4.Size = new System.Drawing.Size(150, 150);
            this.pboxBack4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBack4.TabIndex = 10;
            this.pboxBack4.TabStop = false;
            // 
            // pboxBack3
            // 
            this.pboxBack3.BackgroundImage = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack3.Image = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack3.Location = new System.Drawing.Point(404, 111);
            this.pboxBack3.Name = "pboxBack3";
            this.pboxBack3.Size = new System.Drawing.Size(150, 150);
            this.pboxBack3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBack3.TabIndex = 9;
            this.pboxBack3.TabStop = false;
            // 
            // pboxBack2
            // 
            this.pboxBack2.BackgroundImage = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack2.Image = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack2.Location = new System.Drawing.Point(236, 111);
            this.pboxBack2.Name = "pboxBack2";
            this.pboxBack2.Size = new System.Drawing.Size(150, 150);
            this.pboxBack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBack2.TabIndex = 8;
            this.pboxBack2.TabStop = false;
            // 
            // btnBet
            // 
            this.btnBet.BackgroundImage = global::HorseRacing.Properties.Resources.background;
            this.btnBet.Location = new System.Drawing.Point(112, 55);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(75, 23);
            this.btnBet.TabIndex = 3;
            this.btnBet.Text = "Bet";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // rdbRainbowRoad
            // 
            this.rdbRainbowRoad.AutoSize = true;
            this.rdbRainbowRoad.ForeColor = System.Drawing.Color.White;
            this.rdbRainbowRoad.Location = new System.Drawing.Point(566, 85);
            this.rdbRainbowRoad.Name = "rdbRainbowRoad";
            this.rdbRainbowRoad.Size = new System.Drawing.Size(60, 17);
            this.rdbRainbowRoad.TabIndex = 7;
            this.rdbRainbowRoad.TabStop = true;
            this.rdbRainbowRoad.Text = "Bowser";
            this.rdbRainbowRoad.UseVisualStyleBackColor = true;
            this.rdbRainbowRoad.CheckedChanged += new System.EventHandler(this.rdbRainbowRoad_CheckedChanged);
            // 
            // rdbBowsersCastle
            // 
            this.rdbBowsersCastle.AutoSize = true;
            this.rdbBowsersCastle.ForeColor = System.Drawing.Color.White;
            this.rdbBowsersCastle.Location = new System.Drawing.Point(393, 85);
            this.rdbBowsersCastle.Name = "rdbBowsersCastle";
            this.rdbBowsersCastle.Size = new System.Drawing.Size(56, 17);
            this.rdbBowsersCastle.TabIndex = 6;
            this.rdbBowsersCastle.TabStop = true;
            this.rdbBowsersCastle.Text = "Peach";
            this.rdbBowsersCastle.UseVisualStyleBackColor = true;
            this.rdbBowsersCastle.CheckedChanged += new System.EventHandler(this.rdbBowsersCastle_CheckedChanged);
            // 
            // rdbChocoIsland
            // 
            this.rdbChocoIsland.AutoSize = true;
            this.rdbChocoIsland.ForeColor = System.Drawing.Color.White;
            this.rdbChocoIsland.Location = new System.Drawing.Point(232, 85);
            this.rdbChocoIsland.Name = "rdbChocoIsland";
            this.rdbChocoIsland.Size = new System.Drawing.Size(47, 17);
            this.rdbChocoIsland.TabIndex = 5;
            this.rdbChocoIsland.TabStop = true;
            this.rdbChocoIsland.Text = "Luigi";
            this.rdbChocoIsland.UseVisualStyleBackColor = true;
            this.rdbChocoIsland.CheckedChanged += new System.EventHandler(this.rdbChocoIsland_CheckedChanged);
            // 
            // pboxBack1
            // 
            this.pboxBack1.BackgroundImage = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack1.Image = global::HorseRacing.Properties.Resources.charselectback;
            this.pboxBack1.Location = new System.Drawing.Point(68, 111);
            this.pboxBack1.Name = "pboxBack1";
            this.pboxBack1.Size = new System.Drawing.Size(150, 150);
            this.pboxBack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBack1.TabIndex = 0;
            this.pboxBack1.TabStop = false;
            // 
            // rdbMariocircuit
            // 
            this.rdbMariocircuit.AutoSize = true;
            this.rdbMariocircuit.ForeColor = System.Drawing.Color.White;
            this.rdbMariocircuit.Location = new System.Drawing.Point(59, 85);
            this.rdbMariocircuit.Name = "rdbMariocircuit";
            this.rdbMariocircuit.Size = new System.Drawing.Size(51, 17);
            this.rdbMariocircuit.TabIndex = 1;
            this.rdbMariocircuit.TabStop = true;
            this.rdbMariocircuit.Text = "Mario";
            this.rdbMariocircuit.UseVisualStyleBackColor = true;
            this.rdbMariocircuit.CheckedChanged += new System.EventHandler(this.rdbMariocircuit_CheckedChanged);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(56)))));
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.White;
            this.lblChoose.Location = new System.Drawing.Point(303, 21);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(202, 37);
            this.lblChoose.TabIndex = 8;
            this.lblChoose.Text = "Bet on Racer";
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBetAmount
            // 
            this.txtBetAmount.Location = new System.Drawing.Point(6, 56);
            this.txtBetAmount.Name = "txtBetAmount";
            this.txtBetAmount.Size = new System.Drawing.Size(100, 20);
            this.txtBetAmount.TabIndex = 11;
            // 
            // CharacterSelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HorseRacing.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.trackPicker);
            this.Name = "CharacterSelectView";
            this.Text = "CharacterSelectView";
            this.Load += new System.EventHandler(this.CharacterSelectView_Load);
            this.trackPicker.ResumeLayout(false);
            this.trackPicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox trackPicker;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.RadioButton rdbRainbowRoad;
        private System.Windows.Forms.RadioButton rdbBowsersCastle;
        private System.Windows.Forms.RadioButton rdbChocoIsland;
        private System.Windows.Forms.PictureBox pboxBack1;
        private System.Windows.Forms.RadioButton rdbMariocircuit;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.PictureBox pboxBack4;
        private System.Windows.Forms.PictureBox pboxBack3;
        private System.Windows.Forms.PictureBox pboxBack2;
        private System.Windows.Forms.TextBox txtBetAmount;
    }
}