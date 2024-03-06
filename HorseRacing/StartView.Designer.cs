using System.ComponentModel;

namespace HorseRacing
{
    partial class StartView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.pboxMarioCircuit = new System.Windows.Forms.PictureBox();
            this.rdbMariocircuit = new System.Windows.Forms.RadioButton();
            this.trackPicker = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdbRainbowRoad = new System.Windows.Forms.RadioButton();
            this.rdbBowsersCastle = new System.Windows.Forms.RadioButton();
            this.rdbChocoIsland = new System.Windows.Forms.RadioButton();
            this.pboxBowsersCastle = new System.Windows.Forms.PictureBox();
            this.pboxRainbowRoad = new System.Windows.Forms.PictureBox();
            this.pboxChocoIsland = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarioCircuit)).BeginInit();
            this.trackPicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBowsersCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRainbowRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxChocoIsland)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxMarioCircuit
            // 
            this.pboxMarioCircuit.Image = global::HorseRacing.Properties.Resources.mariocircuit_1;
            this.pboxMarioCircuit.Location = new System.Drawing.Point(21, 136);
            this.pboxMarioCircuit.Name = "pboxMarioCircuit";
            this.pboxMarioCircuit.Size = new System.Drawing.Size(150, 150);
            this.pboxMarioCircuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMarioCircuit.TabIndex = 0;
            this.pboxMarioCircuit.TabStop = false;
            this.pboxMarioCircuit.Click += new System.EventHandler(this.pboxMarioCircuit_Click);
            // 
            // rdbMariocircuit
            // 
            this.rdbMariocircuit.AutoSize = true;
            this.rdbMariocircuit.Location = new System.Drawing.Point(55, 113);
            this.rdbMariocircuit.Name = "rdbMariocircuit";
            this.rdbMariocircuit.Size = new System.Drawing.Size(83, 17);
            this.rdbMariocircuit.TabIndex = 1;
            this.rdbMariocircuit.TabStop = true;
            this.rdbMariocircuit.Text = "Mario Circuit";
            this.rdbMariocircuit.UseVisualStyleBackColor = true;
            // 
            // trackPicker
            // 
            this.trackPicker.Controls.Add(this.btnStart);
            this.trackPicker.Controls.Add(this.rdbRainbowRoad);
            this.trackPicker.Controls.Add(this.rdbBowsersCastle);
            this.trackPicker.Controls.Add(this.rdbChocoIsland);
            this.trackPicker.Controls.Add(this.pboxBowsersCastle);
            this.trackPicker.Controls.Add(this.pboxRainbowRoad);
            this.trackPicker.Controls.Add(this.pboxChocoIsland);
            this.trackPicker.Controls.Add(this.pboxMarioCircuit);
            this.trackPicker.Controls.Add(this.rdbMariocircuit);
            this.trackPicker.Location = new System.Drawing.Point(12, 12);
            this.trackPicker.Name = "trackPicker";
            this.trackPicker.Size = new System.Drawing.Size(776, 426);
            this.trackPicker.TabIndex = 2;
            this.trackPicker.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(351, 359);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdbRainbowRoad
            // 
            this.rdbRainbowRoad.AutoSize = true;
            this.rdbRainbowRoad.Location = new System.Drawing.Point(616, 113);
            this.rdbRainbowRoad.Name = "rdbRainbowRoad";
            this.rdbRainbowRoad.Size = new System.Drawing.Size(99, 17);
            this.rdbRainbowRoad.TabIndex = 7;
            this.rdbRainbowRoad.TabStop = true;
            this.rdbRainbowRoad.Text = "Bowser\'s Castle";
            this.rdbRainbowRoad.UseVisualStyleBackColor = true;
            // 
            // rdbBowsersCastle
            // 
            this.rdbBowsersCastle.AutoSize = true;
            this.rdbBowsersCastle.Location = new System.Drawing.Point(427, 113);
            this.rdbBowsersCastle.Name = "rdbBowsersCastle";
            this.rdbBowsersCastle.Size = new System.Drawing.Size(99, 17);
            this.rdbBowsersCastle.TabIndex = 6;
            this.rdbBowsersCastle.TabStop = true;
            this.rdbBowsersCastle.Text = "Bowser\'s Castle";
            this.rdbBowsersCastle.UseVisualStyleBackColor = true;
            // 
            // rdbChocoIsland
            // 
            this.rdbChocoIsland.AutoSize = true;
            this.rdbChocoIsland.Location = new System.Drawing.Point(243, 113);
            this.rdbChocoIsland.Name = "rdbChocoIsland";
            this.rdbChocoIsland.Size = new System.Drawing.Size(87, 17);
            this.rdbChocoIsland.TabIndex = 5;
            this.rdbChocoIsland.TabStop = true;
            this.rdbChocoIsland.Text = "Choco Island";
            this.rdbChocoIsland.UseVisualStyleBackColor = true;
            // 
            // pboxBowsersCastle
            // 
            this.pboxBowsersCastle.Image = global::HorseRacing.Properties.Resources.bowsercastle_3;
            this.pboxBowsersCastle.Location = new System.Drawing.Point(401, 136);
            this.pboxBowsersCastle.Name = "pboxBowsersCastle";
            this.pboxBowsersCastle.Size = new System.Drawing.Size(150, 150);
            this.pboxBowsersCastle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxBowsersCastle.TabIndex = 4;
            this.pboxBowsersCastle.TabStop = false;
            this.pboxBowsersCastle.Click += new System.EventHandler(this.pboxBowsersCastle_Click);
            // 
            // pboxRainbowRoad
            // 
            this.pboxRainbowRoad.Image = global::HorseRacing.Properties.Resources.rainbowroad;
            this.pboxRainbowRoad.Location = new System.Drawing.Point(588, 136);
            this.pboxRainbowRoad.Name = "pboxRainbowRoad";
            this.pboxRainbowRoad.Size = new System.Drawing.Size(150, 150);
            this.pboxRainbowRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxRainbowRoad.TabIndex = 3;
            this.pboxRainbowRoad.TabStop = false;
            this.pboxRainbowRoad.Click += new System.EventHandler(this.pboxRainbowRoad_Click);
            // 
            // pboxChocoIsland
            // 
            this.pboxChocoIsland.Image = global::HorseRacing.Properties.Resources.chocoisland_1;
            this.pboxChocoIsland.Location = new System.Drawing.Point(213, 136);
            this.pboxChocoIsland.Name = "pboxChocoIsland";
            this.pboxChocoIsland.Size = new System.Drawing.Size(150, 150);
            this.pboxChocoIsland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxChocoIsland.TabIndex = 2;
            this.pboxChocoIsland.TabStop = false;
            this.pboxChocoIsland.Click += new System.EventHandler(this.pboxChocoIsland_Click);
            // 
            // StartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackPicker);
            this.Name = "StartView";
            this.Text = "Pick your track";
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarioCircuit)).EndInit();
            this.trackPicker.ResumeLayout(false);
            this.trackPicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBowsersCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRainbowRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxChocoIsland)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pboxMarioCircuit;

        #endregion

        private System.Windows.Forms.RadioButton rdbMariocircuit;
        private System.Windows.Forms.GroupBox trackPicker;
        private System.Windows.Forms.RadioButton rdbChocoIsland;
        private System.Windows.Forms.PictureBox pboxBowsersCastle;
        private System.Windows.Forms.PictureBox pboxRainbowRoad;
        private System.Windows.Forms.PictureBox pboxChocoIsland;
        private System.Windows.Forms.RadioButton rdbBowsersCastle;
        private System.Windows.Forms.RadioButton rdbRainbowRoad;
        private System.Windows.Forms.Button btnStart;
    }
}