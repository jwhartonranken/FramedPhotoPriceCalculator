using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB2
{
    public partial class formPhotoshop : Form
    {
        // Global Constants
        const decimal EIGHTXTEN = 3.99M;
        const decimal TENXTWELVE = 5.99M;
        const decimal OTHERSIZES = 9.99M;
        const decimal UNFRAMED = 0.0M;
        const decimal MATTED = 10.00M;
        const decimal FRAMED = 25.00M;

        // Global Variables
        double width = 0.0;
        double height = 0.0;
        decimal totalCost = 0.0M;
        RadioButton radioButtonFrame;
        RadioButton radioButtonColor;
        RadioButton radioButtonMaterial;
        RadioButton radioButtonStyle;
        string frameStr = "";
        string colorStr = "";
        string materialStr = "";
        string styleStr = "";
        public formPhotoshop()
        {
            InitializeComponent();

            // Set up framed groupBox radioButtons
            radioButtonUnframed.CheckedChanged += new EventHandler(framed_Check_Changed);
            radioButtonMatted.CheckedChanged   += new EventHandler(framed_Check_Changed);
            radioButtonFramed.CheckedChanged   += new EventHandler(framed_Check_Changed);

            // Set up color groupBox radioButtons
            radioButtonBlack.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonRed.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonGreen.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonBlue.CheckedChanged += new EventHandler(color_Check_Changed);
            radioButtonWhite.CheckedChanged += new EventHandler(color_Check_Changed);

            // Set up material groupBox radioButtons
            radioButtonPine.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonOak.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonSteel.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonSilver.CheckedChanged += new EventHandler(material_Check_Changed);
            radioButtonGold.CheckedChanged += new EventHandler(material_Check_Changed);

            // Set up style groupBox radioButtons
            radioButtonSimple.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonModern.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonAntique.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonVintage.CheckedChanged += new EventHandler(style_Check_Changed);
            radioButtonEclectic.CheckedChanged += new EventHandler(style_Check_Changed);

        }

        private void framed_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonFrame = (RadioButton)sender;

                frameStr = radioButtonFrame.Name.Substring(11);
            }

            switch (frameStr)
            {
                case "Unframed":
                    groupBoxColor.Enabled = false;
                    groupBoxMaterial.Enabled = false;
                    groupBoxStyle.Enabled = false;
                    break;
                case "Matted":
                    groupBoxColor.Enabled = true;
                    radioButtonBlack.Checked = true;
                    groupBoxMaterial.Enabled = false;
                    groupBoxStyle.Enabled = false;
                    break;
                case "Framed":
                    groupBoxColor.Enabled = false;
                    groupBoxMaterial.Enabled = true;
                    radioButtonPine.Checked = true;
                    groupBoxStyle.Enabled = true;
                    radioButtonSimple.Checked = true;
                    break;
                default:
                    groupBoxColor.Enabled = false;
                    groupBoxMaterial.Enabled = false;
                    groupBoxStyle.Enabled = false;
                    break;
            }
        }

        private void color_Check_Changed (object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonColor = (RadioButton)sender;
                colorStr = radioButtonColor.Name.Substring(11);
            }
        }

        private void material_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonMaterial = (RadioButton)sender;
                materialStr = radioButtonMaterial.Name.Substring(11);
            }
        }

        private void style_Check_Changed(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                radioButtonStyle = (RadioButton)sender;
                styleStr = radioButtonStyle.Name.Substring(11);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateWidth();

            if (keepGoing)
            {
                keepGoing = ValidateHeight();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateCost();
            }
            else
            {
                return;
            }
        }

        private bool ValidateWidth()
        {
            try
            {
                width = Convert.ToDouble(textBoxWidth.Text);
                if (width <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                WriteMessage("Width Inputted was Non-Numeric. \r\nPlease try again.", "ILLEGAL INPUT");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException oore)
            {
                WriteMessage("Width Inputted was <= 0. \r\nPlease try again.", "NEGATIVE INPUT");
                textBoxWidth.Text = "";
                textBoxWidth.Focus();
                return false;
            }
        }

        private bool ValidateHeight()
        {
            try
            {
                height = Convert.ToDouble(textBoxHeight.Text);
                if (height <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return true;
            }
            catch (FormatException fe)
            {
                WriteMessage("Height Inputted was Non-Numeric. \r\nPlease try again.", "ILLEGAL INPUT");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }
            catch (ArgumentOutOfRangeException oore)
            {
                WriteMessage("Height Inputted was <= 0. \r\nPlease try again.", "NEGATIVE INPUT");
                textBoxHeight.Text = "";
                textBoxHeight.Focus();
                return false;
            }
        }

        private void CalculateCost()
        {
            decimal areaCost = CalculateAreaCost();
            decimal frameCost = CalculateFrameCost();
            totalCost = areaCost + frameCost;

            labelTheCost.Text = totalCost.ToString("c");
        }

        private decimal CalculateAreaCost()
        {
            double area = width * height;
            decimal ac = 0.00m;

            switch (area)
            {
                case 80.0:
                    ac = EIGHTXTEN;
                    break;
                case 120.0:
                    ac = TENXTWELVE;
                    break;
                default:
                    ac = OTHERSIZES;
                    break;
            }

            return ac;
        }

        private decimal CalculateFrameCost()
        {
            decimal fc = 0.0m;

            switch (radioButtonFrame.Name.Substring(11))
            {
                case "Unframed":
                    fc = UNFRAMED;
                    Photo p = new Photo(width, height);
                    labelTotals.Text = p.ToString();
                    break;
                case "Matted":
                    fc = MATTED;
                    MattedPhoto.ColorEnum colorEnum = (MattedPhoto.ColorEnum)Enum.Parse(typeof(MattedPhoto.ColorEnum), radioButtonColor.Text.ToUpper());
                    MattedPhoto mp = new MattedPhoto(width, height, colorEnum);
                    labelTotals.Text = mp.ToString();
                    break;
                case "Framed":
                    fc = FRAMED;
                    FramedPhoto.MaterialEnum materialEnum =
                    (FramedPhoto.MaterialEnum)Enum.Parse(typeof(FramedPhoto.MaterialEnum),
                    radioButtonMaterial.Text.ToUpper());
                    FramedPhoto.StyleEnum styleEnum =
                    (FramedPhoto.StyleEnum)Enum.Parse(typeof(FramedPhoto.StyleEnum),
                    radioButtonStyle.Text.ToUpper());
                    FramedPhoto fp = new FramedPhoto(width, height, materialEnum, styleEnum);
                    labelTotals.Text = fp.ToString();
                    break;
                default:
                    break;
            }

            return fc;
        }

        private void WriteMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            width = 0.0;
            height = 0.0;
            textBoxWidth.Text = "";
            textBoxHeight.Text = "";
            radioButtonUnframed.Checked = true;
            radioButtonBlack.Checked = true;
            radioButtonPine.Checked = true;
            radioButtonSimple.Checked = true;
            labelTheCost.Text = "";
            labelTotals.Text = "";
            textBoxWidth.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show(
                "Do you really want to Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
