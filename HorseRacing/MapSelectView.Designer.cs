using System.ComponentModel;

namespace HorseRacing
{
    partial class MapSelectView
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
            this.btnRace = new System.Windows.Forms.Button();
            this.btnGrandPrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(167, 151);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(195, 110);
            this.btnRace.TabIndex = 1;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.Start);
            // 
            // btnGrandPrix
            // 
            this.btnGrandPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrandPrix.Location = new System.Drawing.Point(426, 151);
            this.btnGrandPrix.Name = "btnGrandPrix";
            this.btnGrandPrix.Size = new System.Drawing.Size(195, 110);
            this.btnGrandPrix.TabIndex = 2;
            this.btnGrandPrix.Text = "Grand Prix";
            this.btnGrandPrix.UseVisualStyleBackColor = true;
            this.btnGrandPrix.Click += new System.EventHandler(this.Start);

            this.rdbMariocircuit = new System.Windows.Forms.RadioButton();
            this.trackPicker = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdbRainbowRoad = new System.Windows.Forms.RadioButton();
            this.rdbBowsersCastle = new System.Windows.Forms.RadioButton();
            this.rdbChocoIsland = new System.Windows.Forms.RadioButton();
            this.pboxBowsersCastle = new System.Windows.Forms.PictureBox();
            this.pboxRainbowRoad = new System.Windows.Forms.PictureBox();
            this.pboxChocoIsland = new System.Windows.Forms.PictureBox();
            this.pboxMarioCircuit = new System.Windows.Forms.PictureBox();
            this.lblChoose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarioCircuit)).BeginInit();
            this.trackPicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBowsersCastle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRainbowRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxChocoIsland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarioCircuit)).BeginInit();
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
            this.rdbMariocircuit.ForeColor = System.Drawing.Color.White;
            this.rdbMariocircuit.Location = new System.Drawing.Point(59, 85);
            this.rdbMariocircuit.Name = "rdbMariocircuit";
            this.rdbMariocircuit.Size = new System.Drawing.Size(83, 17);
            this.rdbMariocircuit.TabIndex = 1;
            this.rdbMariocircuit.TabStop = true;
            this.rdbMariocircuit.Text = "Mario Circuit";
            this.rdbMariocircuit.UseVisualStyleBackColor = true;
            // 
            // trackPicker
            // 
            this.trackPicker.BackColor = System.Drawing.Color.Transparent;
            this.trackPicker.BackgroundImage = global::HorseRacing.Properties.Resources.selection;
            this.trackPicker.Controls.Add(this.btnStart);
            this.trackPicker.Controls.Add(this.rdbRainbowRoad);
            this.trackPicker.Controls.Add(this.rdbBowsersCastle);
            this.trackPicker.Controls.Add(this.rdbChocoIsland);
            this.trackPicker.Controls.Add(this.pboxBowsersCastle);
            this.trackPicker.Controls.Add(this.pboxRainbowRoad);
            this.trackPicker.Controls.Add(this.pboxChocoIsland);
            this.trackPicker.Controls.Add(this.pboxMarioCircuit);
            this.trackPicker.Controls.Add(this.rdbMariocircuit);
            this.trackPicker.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackPicker.ForeColor = System.Drawing.Color.Transparent;
            this.trackPicker.Location = new System.Drawing.Point(13, 58);
            this.trackPicker.Name = "trackPicker";
            this.trackPicker.Size = new System.Drawing.Size(775, 281);
            this.trackPicker.TabIndex = 2;
            this.trackPicker.TabStop = false;
            this.trackPicker.Enter += new System.EventHandler(this.trackPicker_Enter);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(354, 252);
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
            this.rdbRainbowRoad.ForeColor = System.Drawing.Color.White;
            this.rdbRainbowRoad.Location = new System.Drawing.Point(566, 85);
            this.rdbRainbowRoad.Name = "rdbRainbowRoad";
            this.rdbRainbowRoad.Size = new System.Drawing.Size(96, 17);
            this.rdbRainbowRoad.TabIndex = 7;
            this.rdbRainbowRoad.TabStop = true;
            this.rdbRainbowRoad.Text = "Rainbow Road";
            this.rdbRainbowRoad.UseVisualStyleBackColor = true;
            // 
            // rdbBowsersCastle
            // 
            this.rdbBowsersCastle.AutoSize = true;
            this.rdbBowsersCastle.ForeColor = System.Drawing.Color.White;
            this.rdbBowsersCastle.Location = new System.Drawing.Point(393, 85);
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
            this.rdbChocoIsland.ForeColor = System.Drawing.Color.White;
            this.rdbChocoIsland.Location = new System.Drawing.Point(232, 85);
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
            this.pboxBowsersCastle.Location = new System.Drawing.Point(405, 112);
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
            this.pboxRainbowRoad.Location = new System.Drawing.Point(571, 112);
            this.pboxRainbowRoad.Name = "pboxRainbowRoad";
            this.pboxRainbowRoad.Size = new System.Drawing.Size(150, 150);
            this.pboxRainbowRoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxRainbowRoad.TabIndex = 3;
            this.pboxRainbowRoad.TabStop = false;
            this.pboxRainbowRoad.Click += new System.EventHandler(this.pboxRainbowRoad_Click);
            // 
            // pboxChocoIsland
            // 
            this.pboxChocoIsland.BackColor = System.Drawing.Color.Transparent;
            this.pboxChocoIsland.Image = global::HorseRacing.Properties.Resources.chocoisland_1;
            this.pboxChocoIsland.Location = new System.Drawing.Point(236, 112);
            this.pboxChocoIsland.Name = "pboxChocoIsland";
            this.pboxChocoIsland.Size = new System.Drawing.Size(150, 150);
            this.pboxChocoIsland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxChocoIsland.TabIndex = 2;
            this.pboxChocoIsland.TabStop = false;
            this.pboxChocoIsland.Click += new System.EventHandler(this.pboxChocoIsland_Click);
            // 
            // pboxMarioCircuit
            // 
            this.pboxMarioCircuit.Image = global::HorseRacing.Properties.Resources.mariocircuit_1;
            this.pboxMarioCircuit.Location = new System.Drawing.Point(68, 111);
            this.pboxMarioCircuit.Name = "pboxMarioCircuit";
            this.pboxMarioCircuit.Size = new System.Drawing.Size(150, 150);
            this.pboxMarioCircuit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxMarioCircuit.TabIndex = 0;
            this.pboxMarioCircuit.TabStop = false;
            this.pboxMarioCircuit.Click += new System.EventHandler(this.pboxMarioCircuit_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(56)))));
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.White;
            this.lblChoose.Location = new System.Drawing.Point(293, 41);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(194, 37);
            this.lblChoose.TabIndex = 3;
            this.lblChoose.Text = "Select Track";
            this.lblChoose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChoose.Click += new System.EventHandler(this.lblChoose_Click);
            // 
            // MapSelectView
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGrandPrix);
            this.Controls.Add(this.btnRace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartView";
            this.Text = "StartView";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartView_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartView_MouseUp);

            this.BackgroundImage = global::HorseRacing.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.trackPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MapSelectView";
            this.Text = "Pick your track";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapSelectView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapSelectView_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapSelectView_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarioCircuit)).EndInit();
            this.trackPicker.ResumeLayout(false);
            this.trackPicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBowsersCastle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRainbowRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxChocoIsland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMarioCircuit)).EndInit();
>>>>>>>> coresystems:HorseRacing/MapSelectView.Designer.cs
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.PictureBox pboxMarioCircuit;

        #endregion

<<<<<<<< HEAD:HorseRacing/StartView.Designer.cs
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnGrandPrix;
========
        private System.Windows.Forms.RadioButton rdbMariocircuit;
        private System.Windows.Forms.GroupBox trackPicker;
        private System.Windows.Forms.RadioButton rdbChocoIsland;
        private System.Windows.Forms.PictureBox pboxBowsersCastle;
        private System.Windows.Forms.PictureBox pboxRainbowRoad;
        private System.Windows.Forms.PictureBox pboxChocoIsland;
        private System.Windows.Forms.RadioButton rdbBowsersCastle;
        private System.Windows.Forms.RadioButton rdbRainbowRoad;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblChoose;
    }
}