
namespace LB2
{
    partial class formPhotoshop
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
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.groupBoxFramed = new System.Windows.Forms.GroupBox();
            this.radioButtonFramed = new System.Windows.Forms.RadioButton();
            this.radioButtonMatted = new System.Windows.Forms.RadioButton();
            this.radioButtonUnframed = new System.Windows.Forms.RadioButton();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.radioButtonWhite = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.radioButtonBlack = new System.Windows.Forms.RadioButton();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.radioButtonGold = new System.Windows.Forms.RadioButton();
            this.radioButtonSilver = new System.Windows.Forms.RadioButton();
            this.radioButtonSteel = new System.Windows.Forms.RadioButton();
            this.radioButtonOak = new System.Windows.Forms.RadioButton();
            this.radioButtonPine = new System.Windows.Forms.RadioButton();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.radioButtonEclectic = new System.Windows.Forms.RadioButton();
            this.radioButtonVintage = new System.Windows.Forms.RadioButton();
            this.radioButtonAntique = new System.Windows.Forms.RadioButton();
            this.radioButtonModern = new System.Windows.Forms.RadioButton();
            this.radioButtonSimple = new System.Windows.Forms.RadioButton();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelTheCost = new System.Windows.Forms.Label();
            this.labelTotals = new System.Windows.Forms.Label();
            this.groupBoxFramed.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(77, 30);
            this.labelWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(124, 29);
            this.labelWidth.TabIndex = 0;
            this.labelWidth.Text = "Width (in)";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(77, 85);
            this.labelHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(131, 29);
            this.labelHeight.TabIndex = 1;
            this.labelHeight.Text = "Height (in)";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.BackColor = System.Drawing.Color.Azure;
            this.textBoxWidth.Location = new System.Drawing.Point(224, 27);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(456, 34);
            this.textBoxWidth.TabIndex = 0;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.BackColor = System.Drawing.Color.Azure;
            this.textBoxHeight.Location = new System.Drawing.Point(224, 82);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(456, 34);
            this.textBoxHeight.TabIndex = 1;
            // 
            // groupBoxFramed
            // 
            this.groupBoxFramed.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxFramed.Controls.Add(this.radioButtonFramed);
            this.groupBoxFramed.Controls.Add(this.radioButtonMatted);
            this.groupBoxFramed.Controls.Add(this.radioButtonUnframed);
            this.groupBoxFramed.Location = new System.Drawing.Point(82, 137);
            this.groupBoxFramed.Name = "groupBoxFramed";
            this.groupBoxFramed.Size = new System.Drawing.Size(598, 147);
            this.groupBoxFramed.TabIndex = 2;
            this.groupBoxFramed.TabStop = false;
            this.groupBoxFramed.Text = "Framed?";
            // 
            // radioButtonFramed
            // 
            this.radioButtonFramed.AutoSize = true;
            this.radioButtonFramed.Location = new System.Drawing.Point(350, 33);
            this.radioButtonFramed.Name = "radioButtonFramed";
            this.radioButtonFramed.Size = new System.Drawing.Size(117, 33);
            this.radioButtonFramed.TabIndex = 1;
            this.radioButtonFramed.TabStop = true;
            this.radioButtonFramed.Text = "Framed";
            this.radioButtonFramed.UseVisualStyleBackColor = true;
            // 
            // radioButtonMatted
            // 
            this.radioButtonMatted.AutoSize = true;
            this.radioButtonMatted.Location = new System.Drawing.Point(131, 85);
            this.radioButtonMatted.Name = "radioButtonMatted";
            this.radioButtonMatted.Size = new System.Drawing.Size(110, 33);
            this.radioButtonMatted.TabIndex = 2;
            this.radioButtonMatted.TabStop = true;
            this.radioButtonMatted.Text = "Matted";
            this.radioButtonMatted.UseVisualStyleBackColor = true;
            // 
            // radioButtonUnframed
            // 
            this.radioButtonUnframed.AutoSize = true;
            this.radioButtonUnframed.Location = new System.Drawing.Point(131, 33);
            this.radioButtonUnframed.Name = "radioButtonUnframed";
            this.radioButtonUnframed.Size = new System.Drawing.Size(143, 33);
            this.radioButtonUnframed.TabIndex = 0;
            this.radioButtonUnframed.TabStop = true;
            this.radioButtonUnframed.Text = "Unframed";
            this.radioButtonUnframed.UseVisualStyleBackColor = true;
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxColor.Controls.Add(this.radioButtonWhite);
            this.groupBoxColor.Controls.Add(this.radioButtonBlue);
            this.groupBoxColor.Controls.Add(this.radioButtonGreen);
            this.groupBoxColor.Controls.Add(this.radioButtonRed);
            this.groupBoxColor.Controls.Add(this.radioButtonBlack);
            this.groupBoxColor.Location = new System.Drawing.Point(35, 311);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(225, 235);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Color";
            // 
            // radioButtonWhite
            // 
            this.radioButtonWhite.AutoSize = true;
            this.radioButtonWhite.Location = new System.Drawing.Point(9, 189);
            this.radioButtonWhite.Name = "radioButtonWhite";
            this.radioButtonWhite.Size = new System.Drawing.Size(98, 33);
            this.radioButtonWhite.TabIndex = 4;
            this.radioButtonWhite.TabStop = true;
            this.radioButtonWhite.Text = "White";
            this.radioButtonWhite.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(9, 150);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(83, 33);
            this.radioButtonBlue.TabIndex = 3;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(9, 111);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(99, 33);
            this.radioButtonGreen.TabIndex = 2;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(9, 72);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(77, 33);
            this.radioButtonRed.TabIndex = 1;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlack
            // 
            this.radioButtonBlack.AutoSize = true;
            this.radioButtonBlack.Location = new System.Drawing.Point(9, 33);
            this.radioButtonBlack.Name = "radioButtonBlack";
            this.radioButtonBlack.Size = new System.Drawing.Size(93, 33);
            this.radioButtonBlack.TabIndex = 0;
            this.radioButtonBlack.TabStop = true;
            this.radioButtonBlack.Text = "Black";
            this.radioButtonBlack.UseVisualStyleBackColor = true;
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxMaterial.Controls.Add(this.radioButtonGold);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSilver);
            this.groupBoxMaterial.Controls.Add(this.radioButtonSteel);
            this.groupBoxMaterial.Controls.Add(this.radioButtonOak);
            this.groupBoxMaterial.Controls.Add(this.radioButtonPine);
            this.groupBoxMaterial.Location = new System.Drawing.Point(266, 311);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(225, 235);
            this.groupBoxMaterial.TabIndex = 4;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // radioButtonGold
            // 
            this.radioButtonGold.AutoSize = true;
            this.radioButtonGold.Location = new System.Drawing.Point(9, 189);
            this.radioButtonGold.Name = "radioButtonGold";
            this.radioButtonGold.Size = new System.Drawing.Size(85, 33);
            this.radioButtonGold.TabIndex = 4;
            this.radioButtonGold.TabStop = true;
            this.radioButtonGold.Text = "Gold";
            this.radioButtonGold.UseVisualStyleBackColor = true;
            // 
            // radioButtonSilver
            // 
            this.radioButtonSilver.AutoSize = true;
            this.radioButtonSilver.Location = new System.Drawing.Point(9, 150);
            this.radioButtonSilver.Name = "radioButtonSilver";
            this.radioButtonSilver.Size = new System.Drawing.Size(95, 33);
            this.radioButtonSilver.TabIndex = 3;
            this.radioButtonSilver.TabStop = true;
            this.radioButtonSilver.Text = "Silver";
            this.radioButtonSilver.UseVisualStyleBackColor = true;
            // 
            // radioButtonSteel
            // 
            this.radioButtonSteel.AutoSize = true;
            this.radioButtonSteel.Location = new System.Drawing.Point(9, 111);
            this.radioButtonSteel.Name = "radioButtonSteel";
            this.radioButtonSteel.Size = new System.Drawing.Size(86, 33);
            this.radioButtonSteel.TabIndex = 2;
            this.radioButtonSteel.TabStop = true;
            this.radioButtonSteel.Text = "Steel";
            this.radioButtonSteel.UseVisualStyleBackColor = true;
            // 
            // radioButtonOak
            // 
            this.radioButtonOak.AutoSize = true;
            this.radioButtonOak.Location = new System.Drawing.Point(9, 72);
            this.radioButtonOak.Name = "radioButtonOak";
            this.radioButtonOak.Size = new System.Drawing.Size(77, 33);
            this.radioButtonOak.TabIndex = 1;
            this.radioButtonOak.TabStop = true;
            this.radioButtonOak.Text = "Oak";
            this.radioButtonOak.UseVisualStyleBackColor = true;
            // 
            // radioButtonPine
            // 
            this.radioButtonPine.AutoSize = true;
            this.radioButtonPine.Location = new System.Drawing.Point(9, 33);
            this.radioButtonPine.Name = "radioButtonPine";
            this.radioButtonPine.Size = new System.Drawing.Size(82, 33);
            this.radioButtonPine.TabIndex = 0;
            this.radioButtonPine.TabStop = true;
            this.radioButtonPine.Text = "Pine";
            this.radioButtonPine.UseVisualStyleBackColor = true;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.BackColor = System.Drawing.Color.LightCyan;
            this.groupBoxStyle.Controls.Add(this.radioButtonEclectic);
            this.groupBoxStyle.Controls.Add(this.radioButtonVintage);
            this.groupBoxStyle.Controls.Add(this.radioButtonAntique);
            this.groupBoxStyle.Controls.Add(this.radioButtonModern);
            this.groupBoxStyle.Controls.Add(this.radioButtonSimple);
            this.groupBoxStyle.Location = new System.Drawing.Point(497, 311);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(225, 235);
            this.groupBoxStyle.TabIndex = 5;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "Style";
            // 
            // radioButtonEclectic
            // 
            this.radioButtonEclectic.AutoSize = true;
            this.radioButtonEclectic.Location = new System.Drawing.Point(9, 189);
            this.radioButtonEclectic.Name = "radioButtonEclectic";
            this.radioButtonEclectic.Size = new System.Drawing.Size(117, 33);
            this.radioButtonEclectic.TabIndex = 4;
            this.radioButtonEclectic.TabStop = true;
            this.radioButtonEclectic.Text = "Eclectic";
            this.radioButtonEclectic.UseVisualStyleBackColor = true;
            // 
            // radioButtonVintage
            // 
            this.radioButtonVintage.AutoSize = true;
            this.radioButtonVintage.Location = new System.Drawing.Point(9, 150);
            this.radioButtonVintage.Name = "radioButtonVintage";
            this.radioButtonVintage.Size = new System.Drawing.Size(115, 33);
            this.radioButtonVintage.TabIndex = 3;
            this.radioButtonVintage.TabStop = true;
            this.radioButtonVintage.Text = "Vintage";
            this.radioButtonVintage.UseVisualStyleBackColor = true;
            // 
            // radioButtonAntique
            // 
            this.radioButtonAntique.AutoSize = true;
            this.radioButtonAntique.Location = new System.Drawing.Point(9, 111);
            this.radioButtonAntique.Name = "radioButtonAntique";
            this.radioButtonAntique.Size = new System.Drawing.Size(118, 33);
            this.radioButtonAntique.TabIndex = 2;
            this.radioButtonAntique.TabStop = true;
            this.radioButtonAntique.Text = "Antique";
            this.radioButtonAntique.UseVisualStyleBackColor = true;
            // 
            // radioButtonModern
            // 
            this.radioButtonModern.AutoSize = true;
            this.radioButtonModern.Location = new System.Drawing.Point(9, 72);
            this.radioButtonModern.Name = "radioButtonModern";
            this.radioButtonModern.Size = new System.Drawing.Size(119, 33);
            this.radioButtonModern.TabIndex = 1;
            this.radioButtonModern.TabStop = true;
            this.radioButtonModern.Text = "Modern";
            this.radioButtonModern.UseVisualStyleBackColor = true;
            // 
            // radioButtonSimple
            // 
            this.radioButtonSimple.AutoSize = true;
            this.radioButtonSimple.Location = new System.Drawing.Point(9, 33);
            this.radioButtonSimple.Name = "radioButtonSimple";
            this.radioButtonSimple.Size = new System.Drawing.Size(108, 33);
            this.radioButtonSimple.TabIndex = 0;
            this.radioButtonSimple.TabStop = true;
            this.radioButtonSimple.Text = "Simple";
            this.radioButtonSimple.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCalculate.Location = new System.Drawing.Point(35, 574);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(126, 55);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonClear.Location = new System.Drawing.Point(197, 574);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(126, 55);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(365, 574);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(126, 55);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(501, 588);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(67, 29);
            this.labelCost.TabIndex = 10;
            this.labelCost.Text = "Cost:";
            // 
            // labelTheCost
            // 
            this.labelTheCost.BackColor = System.Drawing.Color.Azure;
            this.labelTheCost.Location = new System.Drawing.Point(575, 574);
            this.labelTheCost.Name = "labelTheCost";
            this.labelTheCost.Size = new System.Drawing.Size(147, 55);
            this.labelTheCost.TabIndex = 11;
            this.labelTheCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotals
            // 
            this.labelTotals.BackColor = System.Drawing.Color.Azure;
            this.labelTotals.Location = new System.Drawing.Point(30, 655);
            this.labelTotals.Name = "labelTotals";
            this.labelTotals.Size = new System.Drawing.Size(692, 63);
            this.labelTotals.TabIndex = 12;
            this.labelTotals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formPhotoshop
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(757, 776);
            this.Controls.Add(this.labelTotals);
            this.Controls.Add(this.labelTheCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.groupBoxStyle);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxFramed);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWidth);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "formPhotoshop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Shop";
            this.groupBoxFramed.ResumeLayout(false);
            this.groupBoxFramed.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxStyle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.GroupBox groupBoxFramed;
        private System.Windows.Forms.RadioButton radioButtonFramed;
        private System.Windows.Forms.RadioButton radioButtonMatted;
        private System.Windows.Forms.RadioButton radioButtonUnframed;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.RadioButton radioButtonWhite;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.RadioButton radioButtonBlack;
        private System.Windows.Forms.GroupBox groupBoxMaterial;
        private System.Windows.Forms.RadioButton radioButtonGold;
        private System.Windows.Forms.RadioButton radioButtonSilver;
        private System.Windows.Forms.RadioButton radioButtonSteel;
        private System.Windows.Forms.RadioButton radioButtonOak;
        private System.Windows.Forms.RadioButton radioButtonPine;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.RadioButton radioButtonEclectic;
        private System.Windows.Forms.RadioButton radioButtonVintage;
        private System.Windows.Forms.RadioButton radioButtonAntique;
        private System.Windows.Forms.RadioButton radioButtonModern;
        private System.Windows.Forms.RadioButton radioButtonSimple;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelTheCost;
        private System.Windows.Forms.Label labelTotals;
    }
}

