namespace NyanCat
{
    partial class NyanCatForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NyanCatForm));
            this.nyanCatGroupBox = new System.Windows.Forms.GroupBox();
            this.nyanCatInfoLabel = new System.Windows.Forms.Label();
            this.styleGroupBox = new System.Windows.Forms.GroupBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.policesComboBox = new System.Windows.Forms.ComboBox();
            this.styleQuatorzeRadioButton = new System.Windows.Forms.RadioButton();
            this.styleDixRadioButton = new System.Windows.Forms.RadioButton();
            this.styleDouzeRadioButton = new System.Windows.Forms.RadioButton();
            this.styleHuitRadioButton = new System.Windows.Forms.RadioButton();
            this.nyanCatPictureBox = new System.Windows.Forms.PictureBox();
            this.nyanCatPictureBox2 = new System.Windows.Forms.PictureBox();
            this.nyanCatTimer = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.nyanCatGroupBox.SuspendLayout();
            this.styleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nyanCatPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyanCatPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // nyanCatGroupBox
            // 
            this.nyanCatGroupBox.Controls.Add(this.nyanCatInfoLabel);
            this.nyanCatGroupBox.Location = new System.Drawing.Point(27, 41);
            this.nyanCatGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nyanCatGroupBox.Name = "nyanCatGroupBox";
            this.nyanCatGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nyanCatGroupBox.Size = new System.Drawing.Size(640, 244);
            this.nyanCatGroupBox.TabIndex = 0;
            this.nyanCatGroupBox.TabStop = false;
            this.nyanCatGroupBox.Text = "Nyan Cat";
            // 
            // nyanCatInfoLabel
            // 
            this.nyanCatInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyanCatInfoLabel.Location = new System.Drawing.Point(16, 21);
            this.nyanCatInfoLabel.Name = "nyanCatInfoLabel";
            this.nyanCatInfoLabel.Size = new System.Drawing.Size(618, 211);
            this.nyanCatInfoLabel.TabIndex = 1;
            this.nyanCatInfoLabel.Text = "Nyan Cat: un meme Internet\r\nDate de début: 2011\r\nCréé par: Christopher Torres.\r\nB" +
    "ande sonore: \"Nyanyanyanyanyanyanya!\"";
            // 
            // styleGroupBox
            // 
            this.styleGroupBox.Controls.Add(this.italicCheckBox);
            this.styleGroupBox.Controls.Add(this.boldCheckBox);
            this.styleGroupBox.Controls.Add(this.policesComboBox);
            this.styleGroupBox.Controls.Add(this.styleQuatorzeRadioButton);
            this.styleGroupBox.Controls.Add(this.styleDixRadioButton);
            this.styleGroupBox.Controls.Add(this.styleDouzeRadioButton);
            this.styleGroupBox.Controls.Add(this.styleHuitRadioButton);
            this.styleGroupBox.Location = new System.Drawing.Point(673, 41);
            this.styleGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.styleGroupBox.Name = "styleGroupBox";
            this.styleGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.styleGroupBox.Size = new System.Drawing.Size(472, 149);
            this.styleGroupBox.TabIndex = 1;
            this.styleGroupBox.TabStop = false;
            this.styleGroupBox.Text = "Style";
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.italicCheckBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicCheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.italicCheckBox.Location = new System.Drawing.Point(396, 34);
            this.italicCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(60, 61);
            this.italicCheckBox.TabIndex = 7;
            this.italicCheckBox.Text = "I";
            this.italicCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.nyanCatStyles_CheckedChanged);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.boldCheckBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldCheckBox.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.boldCheckBox.Location = new System.Drawing.Point(327, 34);
            this.boldCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(60, 61);
            this.boldCheckBox.TabIndex = 6;
            this.boldCheckBox.Text = "B";
            this.boldCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.nyanCatStyles_CheckedChanged);
            // 
            // policesComboBox
            // 
            this.policesComboBox.DropDownHeight = 160;
            this.policesComboBox.FormattingEnabled = true;
            this.policesComboBox.IntegralHeight = false;
            this.policesComboBox.Location = new System.Drawing.Point(19, 42);
            this.policesComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.policesComboBox.Name = "policesComboBox";
            this.policesComboBox.Size = new System.Drawing.Size(271, 28);
            this.policesComboBox.TabIndex = 6;
            this.policesComboBox.SelectedIndexChanged += new System.EventHandler(this.policesComboBox_SelectedIndexChanged);
            // 
            // styleQuatorzeRadioButton
            // 
            this.styleQuatorzeRadioButton.AutoSize = true;
            this.styleQuatorzeRadioButton.Location = new System.Drawing.Point(202, 101);
            this.styleQuatorzeRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.styleQuatorzeRadioButton.Name = "styleQuatorzeRadioButton";
            this.styleQuatorzeRadioButton.Size = new System.Drawing.Size(52, 24);
            this.styleQuatorzeRadioButton.TabIndex = 3;
            this.styleQuatorzeRadioButton.Text = "14";
            this.styleQuatorzeRadioButton.UseVisualStyleBackColor = true;
            this.styleQuatorzeRadioButton.CheckedChanged += new System.EventHandler(this.nyanCatRadioButton_CheckedChanged);
            // 
            // styleDixRadioButton
            // 
            this.styleDixRadioButton.AutoSize = true;
            this.styleDixRadioButton.Location = new System.Drawing.Point(78, 101);
            this.styleDixRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.styleDixRadioButton.Name = "styleDixRadioButton";
            this.styleDixRadioButton.Size = new System.Drawing.Size(52, 24);
            this.styleDixRadioButton.TabIndex = 2;
            this.styleDixRadioButton.Text = "10";
            this.styleDixRadioButton.UseVisualStyleBackColor = true;
            this.styleDixRadioButton.CheckedChanged += new System.EventHandler(this.nyanCatRadioButton_CheckedChanged);
            // 
            // styleDouzeRadioButton
            // 
            this.styleDouzeRadioButton.AutoSize = true;
            this.styleDouzeRadioButton.Location = new System.Drawing.Point(145, 101);
            this.styleDouzeRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.styleDouzeRadioButton.Name = "styleDouzeRadioButton";
            this.styleDouzeRadioButton.Size = new System.Drawing.Size(52, 24);
            this.styleDouzeRadioButton.TabIndex = 1;
            this.styleDouzeRadioButton.Text = "12";
            this.styleDouzeRadioButton.UseVisualStyleBackColor = true;
            this.styleDouzeRadioButton.CheckedChanged += new System.EventHandler(this.nyanCatRadioButton_CheckedChanged);
            // 
            // styleHuitRadioButton
            // 
            this.styleHuitRadioButton.AutoSize = true;
            this.styleHuitRadioButton.Location = new System.Drawing.Point(19, 101);
            this.styleHuitRadioButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.styleHuitRadioButton.Name = "styleHuitRadioButton";
            this.styleHuitRadioButton.Size = new System.Drawing.Size(43, 24);
            this.styleHuitRadioButton.TabIndex = 0;
            this.styleHuitRadioButton.Text = "8";
            this.styleHuitRadioButton.UseVisualStyleBackColor = true;
            this.styleHuitRadioButton.CheckedChanged += new System.EventHandler(this.nyanCatRadioButton_CheckedChanged);
            // 
            // nyanCatPictureBox
            // 
            this.nyanCatPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("nyanCatPictureBox.Image")));
            this.nyanCatPictureBox.Location = new System.Drawing.Point(14, 640);
            this.nyanCatPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nyanCatPictureBox.Name = "nyanCatPictureBox";
            this.nyanCatPictureBox.Size = new System.Drawing.Size(161, 125);
            this.nyanCatPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nyanCatPictureBox.TabIndex = 2;
            this.nyanCatPictureBox.TabStop = false;
            // 
            // nyanCatPictureBox2
            // 
            this.nyanCatPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nyanCatPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(156)))));
            this.nyanCatPictureBox2.Location = new System.Drawing.Point(-4, 289);
            this.nyanCatPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nyanCatPictureBox2.Name = "nyanCatPictureBox2";
            this.nyanCatPictureBox2.Size = new System.Drawing.Size(1188, 274);
            this.nyanCatPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nyanCatPictureBox2.TabIndex = 4;
            this.nyanCatPictureBox2.TabStop = false;
            this.nyanCatPictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.nyanCatPictureBox2_Paint);
            // 
            // nyanCatTimer
            // 
            this.nyanCatTimer.Enabled = true;
            this.nyanCatTimer.Tick += new System.EventHandler(this.nyanCatTimer_Tik);
            // 
            // NyanCatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 765);
            this.Controls.Add(this.nyanCatPictureBox2);
            this.Controls.Add(this.nyanCatPictureBox);
            this.Controls.Add(this.styleGroupBox);
            this.Controls.Add(this.nyanCatGroupBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NyanCatForm";
            this.Text = "Nyan Cat avec polices, dessins et animations";
            this.Load += new System.EventHandler(this.NyanCatForm_Load);
            this.nyanCatGroupBox.ResumeLayout(false);
            this.styleGroupBox.ResumeLayout(false);
            this.styleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nyanCatPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nyanCatPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

    #endregion

    private System.Windows.Forms.GroupBox nyanCatGroupBox;
    private System.Windows.Forms.GroupBox styleGroupBox;
    private System.Windows.Forms.PictureBox nyanCatPictureBox;
    private System.Windows.Forms.RadioButton styleQuatorzeRadioButton;
    private System.Windows.Forms.RadioButton styleDixRadioButton;
    private System.Windows.Forms.RadioButton styleDouzeRadioButton;
    private System.Windows.Forms.RadioButton styleHuitRadioButton;
    private System.Windows.Forms.Label nyanCatInfoLabel;
    private System.Windows.Forms.PictureBox nyanCatPictureBox2;
    private System.Windows.Forms.ComboBox policesComboBox;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.Timer nyanCatTimer;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.FontDialog fontDialog2;
  }
}

