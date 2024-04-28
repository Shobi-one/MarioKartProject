using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class PreviousRaceView : Form
    {
        public PreviousRaceView()
        {
            InitializeComponent();
            InitializeCustomPanels();
        }

        private void InitializeCustomPanels()
        {
            int panelWidth = 390;
            int panelHeight = 150;
            int horizontalSpacing = 5;
            int verticalSpacing = 20;

            for (int panelIndex = 0; panelIndex < 4; panelIndex++)
            {
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(horizontalSpacing + (panelIndex % 2) * (panelWidth + horizontalSpacing),
                                         verticalSpacing + (panelIndex / 2) * (panelHeight + verticalSpacing)),
                    Size = new Size(panelWidth, panelHeight)
                };

                // Add labels
                for (int labelIndex = 0; labelIndex < 4; labelIndex++)
                {
                    Label label = new Label
                    {
                        Text = $"Label {labelIndex + 1}",
                        Location = new Point(10, 10 + labelIndex * 30),
                        Size = new Size(100, 20),
                        AutoSize = true
                    };
                    panel.Controls.Add(label);
                }

                // Add picture boxes
                for (int pictureBoxIndex = 0; pictureBoxIndex < 8; pictureBoxIndex++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(120 + (pictureBoxIndex % 4) * 60, 10 + (pictureBoxIndex / 4) * 60),
                        Size = new Size(50, 50),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    panel.Controls.Add(pictureBox);
                }

                // Add panel to the form
                this.Controls.Add(panel);
            }
        }
    }
}
