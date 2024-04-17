
namespace HorseRacing
{
    partial class GameView
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.pbMario = new System.Windows.Forms.PictureBox();
            this.pbPeach = new System.Windows.Forms.PictureBox();
            this.pbLuigi = new System.Windows.Forms.PictureBox();
            this.pbBowser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLuigi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(906, 1099);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(825, 1099);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(416, 1067);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(47, 31);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y: ";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(273, 1067);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(47, 31);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "X: ";
            // 
            // pbMario
            // 
            this.pbMario.BackColor = System.Drawing.Color.Transparent;
            this.pbMario.Image = global::HorseRacing.Properties.Resources.background;
            this.pbMario.Location = new System.Drawing.Point(366, 151);
            this.pbMario.Name = "pbMario";
            this.pbMario.Size = new System.Drawing.Size(32, 32);
            this.pbMario.TabIndex = 5;
            this.pbMario.TabStop = false;
            // 
            // pbPeach
            // 
            this.pbPeach.BackColor = System.Drawing.Color.Transparent;
            this.pbPeach.Image = global::HorseRacing.Properties.Resources.background;
            this.pbPeach.Location = new System.Drawing.Point(442, 151);
            this.pbPeach.Name = "pbPeach";
            this.pbPeach.Size = new System.Drawing.Size(32, 32);
            this.pbPeach.TabIndex = 6;
            this.pbPeach.TabStop = false;
            // 
            // pbLuigi
            // 
            this.pbLuigi.BackColor = System.Drawing.Color.Transparent;
            this.pbLuigi.Image = global::HorseRacing.Properties.Resources.background;
            this.pbLuigi.Location = new System.Drawing.Point(404, 151);
            this.pbLuigi.Name = "pbLuigi";
            this.pbLuigi.Size = new System.Drawing.Size(32, 32);
            this.pbLuigi.TabIndex = 7;
            this.pbLuigi.TabStop = false;
            // 
            // pbBowser
            // 
            this.pbBowser.BackColor = System.Drawing.Color.Transparent;
            this.pbBowser.Image = global::HorseRacing.Properties.Resources.background;
            this.pbBowser.Location = new System.Drawing.Point(480, 151);
            this.pbBowser.Name = "pbBowser";
            this.pbBowser.Size = new System.Drawing.Size(32, 32);
            this.pbBowser.TabIndex = 8;
            this.pbBowser.TabStop = false;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 1100);
            this.Controls.Add(this.pbBowser);
            this.Controls.Add(this.pbLuigi);
            this.Controls.Add(this.pbPeach);
            this.Controls.Add(this.pbMario);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameView";
            this.Text = "HorseGame";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GameView_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GameView_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GameView_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbMario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPeach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLuigi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBowser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.PictureBox pbMario;
        private System.Windows.Forms.PictureBox pbPeach;
        private System.Windows.Forms.PictureBox pbLuigi;
        private System.Windows.Forms.PictureBox pbBowser;
    }
}