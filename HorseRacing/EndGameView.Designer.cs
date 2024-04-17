
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
            this.pboxBack4 = new System.Windows.Forms.PictureBox();
            this.pboxBack3 = new System.Windows.Forms.PictureBox();
            this.pboxBack2 = new System.Windows.Forms.PictureBox();
            this.pboxBack1 = new System.Windows.Forms.PictureBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblThird = new System.Windows.Forms.Label();
            this.lblFourth = new System.Windows.Forms.Label();
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
            this.trackPicker.Controls.Add(this.lblFourth);
            this.trackPicker.Controls.Add(this.lblThird);
            this.trackPicker.Controls.Add(this.lblSec);
            this.trackPicker.Controls.Add(this.lblFirst);
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
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(62, 69);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(51, 31);
            this.lblFirst.TabIndex = 11;
            this.lblFirst.Text = "1st";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.Location = new System.Drawing.Point(230, 69);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(59, 31);
            this.lblSec.TabIndex = 12;
            this.lblSec.Text = "2nd";
            // 
            // lblThird
            // 
            this.lblThird.AutoSize = true;
            this.lblThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThird.Location = new System.Drawing.Point(398, 69);
            this.lblThird.Name = "lblThird";
            this.lblThird.Size = new System.Drawing.Size(53, 31);
            this.lblThird.TabIndex = 13;
            this.lblThird.Text = "3rd";
            // 
            // lblFourth
            // 
            this.lblFourth.AutoSize = true;
            this.lblFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourth.Location = new System.Drawing.Point(565, 69);
            this.lblFourth.Name = "lblFourth";
            this.lblFourth.Size = new System.Drawing.Size(52, 31);
            this.lblFourth.TabIndex = 14;
            this.lblFourth.Text = "4th";
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
        private System.Windows.Forms.PictureBox pboxBack4;
        private System.Windows.Forms.PictureBox pboxBack3;
        private System.Windows.Forms.PictureBox pboxBack2;
        private System.Windows.Forms.PictureBox pboxBack1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblFourth;
        private System.Windows.Forms.Label lblThird;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblFirst;
    }
}