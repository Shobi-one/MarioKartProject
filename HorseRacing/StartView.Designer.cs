namespace HorseRacing
{
    partial class StartView
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
            this.btnRace = new System.Windows.Forms.Button();
            this.btnGrandPrix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRace
            // 
            this.btnRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRace.Location = new System.Drawing.Point(113, 118);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(244, 122);
            this.btnRace.TabIndex = 0;
            this.btnRace.Text = "Race";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.Start);
            // 
            // btnGrandPrix
            // 
            this.btnGrandPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrandPrix.Location = new System.Drawing.Point(465, 118);
            this.btnGrandPrix.Name = "btnGrandPrix";
            this.btnGrandPrix.Size = new System.Drawing.Size(244, 122);
            this.btnGrandPrix.TabIndex = 1;
            this.btnGrandPrix.Text = "Grand Prix";
            this.btnGrandPrix.UseVisualStyleBackColor = true;
            this.btnGrandPrix.Click += new System.EventHandler(this.Start);
            // 
            // StartView
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Button btnGrandPrix;
    }
}