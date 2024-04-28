
namespace HorseRacing
{
    partial class frmEndGameView
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
            this.pbFirst = new System.Windows.Forms.PictureBox();
            this.pboxBack4 = new System.Windows.Forms.PictureBox();
            this.pboxBack3 = new System.Windows.Forms.PictureBox();
            this.pboxBack2 = new System.Windows.Forms.PictureBox();
            this.pboxBack1 = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trackPicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // trackPicker
            // 
            this.trackPicker.BackColor = System.Drawing.Color.Transparent;
            this.trackPicker.BackgroundImage = global::HorseRacing.Properties.Resources.selection;
            this.trackPicker.Controls.Add(this.pictureBox3);
            this.trackPicker.Controls.Add(this.pictureBox2);
            this.trackPicker.Controls.Add(this.pictureBox1);
            this.trackPicker.Controls.Add(this.pbFirst);
            this.trackPicker.Controls.Add(this.pboxBack4);
            this.trackPicker.Controls.Add(this.pboxBack3);
            this.trackPicker.Controls.Add(this.pboxBack2);
            this.trackPicker.Controls.Add(this.pboxBack1);
            this.trackPicker.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackPicker.ForeColor = System.Drawing.Color.Transparent;
            this.trackPicker.Location = new System.Drawing.Point(5, 49);
            this.trackPicker.Name = "trackPicker";
            this.trackPicker.Size = new System.Drawing.Size(775, 281);
            this.trackPicker.TabIndex = 9;
            this.trackPicker.TabStop = false;
            this.trackPicker.Enter += new System.EventHandler(this.trackPicker_Enter);
            // 
            // pbFirst
            // 
            this.pbFirst.Image = global::HorseRacing.Properties.Resources.first;
            this.pbFirst.Location = new System.Drawing.Point(165, 210);
            this.pbFirst.Name = "pbFirst";
            this.pbFirst.Size = new System.Drawing.Size(65, 65);
            this.pbFirst.TabIndex = 11;
            this.pbFirst.TabStop = false;
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
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(56)))));
            this.lblWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.White;
            this.lblWinner.Location = new System.Drawing.Point(319, 19);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(135, 37);
            this.lblWinner.TabIndex = 10;
            this.lblWinner.Text = "Winners";
            this.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWinner.Click += new System.EventHandler(this.lblChoose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HorseRacing.Properties.Resources.second;
            this.pictureBox1.Location = new System.Drawing.Point(334, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HorseRacing.Properties.Resources.third;
            this.pictureBox2.Location = new System.Drawing.Point(501, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 65);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HorseRacing.Properties.Resources.fourth;
            this.pictureBox3.Location = new System.Drawing.Point(666, 210);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 65);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // frmEndGameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HorseRacing.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.trackPicker);
            this.Controls.Add(this.lblWinner);
            this.Name = "frmEndGameView";
            this.Text = "End Game View";
            this.trackPicker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBack1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox trackPicker;
        private System.Windows.Forms.PictureBox pboxBack4;
        private System.Windows.Forms.PictureBox pboxBack3;
        private System.Windows.Forms.PictureBox pboxBack2;
        private System.Windows.Forms.PictureBox pboxBack1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.PictureBox pbFirst;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}