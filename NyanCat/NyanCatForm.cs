/*
    Programmeurs:   Janie Bérubé et André Doucet 
    Date:           2023-05-31
 
    Solution:       NyanCat.sln
    Projet:		      NyanCat.csproj
    Classe:         NyanCatForm.cs
 
    But:            Projet 2

    Sujet:          Manipulation variées avec dessins, polices et animations.
*/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace NyanCat
{
    public partial class NyanCatForm : Form
    {
        #region Initialisation
        public NyanCatForm()
        {
            InitializeComponent();
        }
        private void NyanCatForm_Load(object sender, EventArgs e)
        {
            initPolices();

            styleQuatorzeRadioButton.Checked = true;

            nyanCatPictureBox.Location = new Point(-nyanCatPictureBox.Width,
            this.ClientSize.Height - nyanCatPictureBox.Height);

        }
        #endregion

        #region Polices

        #region Initialisation du ComboBox 
        private void initPolices()
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                policesComboBox.Items.Add(font.Name.ToString());
            }

            FontFamily startFontFamily = new FontFamily("Arial");

            policesComboBox.SelectedItem = startFontFamily.Name.ToString();

            policesComboBox.DropDownHeight = this.ClientSize.Height / 2;
        }
        #endregion


        #region Changement de la police (label)
        private void policesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Font changeFont = new Font(policesComboBox.SelectedItem.ToString(), nyanCatInfoLabel.Font.Size, nyanCatInfoLabel.Font.Style);
                nyanCatInfoLabel.Font = changeFont;
            }

            catch
            {
                nyanCatInfoLabel.Font = this.Font;
            }
        }
        #endregion


        #region Style (Bold, Italic)
        private void nyanCatStyles_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender == boldCheckBox)
                {
                    nyanCatInfoLabel.Font = new Font(nyanCatInfoLabel.Font.Name, nyanCatInfoLabel.Font.Size, nyanCatInfoLabel.Font.Style ^ FontStyle.Bold);
                }

                if (sender == italicCheckBox)
                {
                    nyanCatInfoLabel.Font = new Font(nyanCatInfoLabel.Font.Name, nyanCatInfoLabel.Font.Size, nyanCatInfoLabel.Font.Style ^ FontStyle.Italic);
                }
            }

            catch
            {
                nyanCatInfoLabel.Font = this.Font;
            }
        }
        #endregion


        #region Changement de la taille
        private void nyanCatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (styleHuitRadioButton.Checked)
            {
                nyanCatInfoLabel.Font = new Font(nyanCatInfoLabel.Font.Name, 8, nyanCatInfoLabel.Font.Style);
            }

            else if (styleDixRadioButton.Checked)
            {
                nyanCatInfoLabel.Font = new Font(nyanCatInfoLabel.Font.Name, 10, nyanCatInfoLabel.Font.Style);
            }

            else if (styleDouzeRadioButton.Checked)
            {
                nyanCatInfoLabel.Font = new Font(nyanCatInfoLabel.Font.Name, 12, nyanCatInfoLabel.Font.Style);
            }

            else
            {
                nyanCatInfoLabel.Font = new Font(nyanCatInfoLabel.Font.Name, 14, nyanCatInfoLabel.Font.Style);
            }
        }
        #endregion


        #endregion

        #region Paint
        private void nyanCatPictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point OgPoint = new Point();

            OgPoint.X = nyanCatPictureBox2.Width / 2;
            OgPoint.Y = nyanCatPictureBox2.Height / 2;

            for (int i = 0; i <= nyanCatPictureBox2.Height; i += 10)
                g.DrawLine(new Pen(Color.Pink, 2), OgPoint, new Point(0, i));

            string catStr = "Nyan Cat";
            Font catFont = new Font("Arial", 50, FontStyle.Bold);

            g.DrawString(catStr, catFont, Brushes.LightBlue, new Point(5, 5));

            g.DrawImage(nyanCatPictureBox.Image,
                nyanCatPictureBox2.Width - (nyanCatPictureBox.Width + 20), 5,
                nyanCatPictureBox.Width, nyanCatPictureBox.Height);
        }
        #endregion

        #region Animation
        private void nyanCatTimer_Tik(object sender, EventArgs e)
        {
            int xPos = nyanCatPictureBox.Location.X + 10;
            int yPos = nyanCatPictureBox.Location.Y;

            if (nyanCatPictureBox.Height > this.ClientSize.Height - yPos || nyanCatPictureBox.Height < this.ClientSize.Height - yPos)
                yPos = this.ClientSize.Height - nyanCatPictureBox.Height;


            if (xPos > this.ClientSize.Width)
                xPos = -nyanCatPictureBox.Width;

            nyanCatPictureBox.Location = new Point(xPos, yPos);
        }

        #endregion


    }
}
