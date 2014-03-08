using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class tipSplittingCalculatorForm : Form
    {
        TrackBar[] trackBarArray;
        Label[] guestLabelArray;
        double guestCount;
        string errorMsg = "Invalid input.";

        public tipSplittingCalculatorForm()
        {
            InitializeComponent();
        }

        private void tipSplittingCalculatorForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(minTipTextBox.Text) && !string.IsNullOrEmpty(maxTipTextBox.Text))
            {
                tipRateLabel.Text = CalculateTipRate();
                guestCount = Int32.Parse(guestsTextBox.Text);
            }
        }

        private void guestsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guestsTextBox_TextChanged(object sender, EventArgs e)
        {
            // Remove 0 if it's the first character entered
            guestsTextBox.Text = guestsTextBox.Text.TrimStart('0');

            if (!string.IsNullOrEmpty(guestsTextBox.Text))
            {
                tipCalculatorTabControl.TabPages[1].Controls.Clear();

                // Add Tip Tailoring controls based on value in the guests textbox
                guestCount = Double.Parse(guestsTextBox.Text);
                trackBarArray = new TrackBar[Convert.ToInt32(guestCount)];
                guestLabelArray = new Label[Convert.ToInt32(guestCount)];
                int spacing = 46;
                for (int x = 0; x < guestCount; x++)
                {
                    TextBox guestTwoTextBox = new TextBox();
                    guestTwoTextBox.Location = new Point(41, (spacing * (x + 1)));
                    guestTwoTextBox.Name = "guestTwoTextBox";
                    guestTwoTextBox.Size = new Size(100, 26);
                    guestTwoTextBox.TabIndex = 33 + 1;
                    guestTwoTextBox.Text = "Guest" + (x + 1);
                    tipCalculatorTabControl.TabPages[1].Controls.Add(guestTwoTextBox);

                    Label guestLabel = new Label();
                    guestLabel.AllowDrop = true;
                    guestLabel.BorderStyle = BorderStyle.None;
                    guestLabel.Location = new Point(344, (spacing * (x + 1)));
                    guestLabel.Name = "guestLabel" + (x).ToString();
                    guestLabel.Size = new Size(102, 26);
                    guestLabel.TabIndex = 35;
                    guestLabel.Text = "0.00";
                    guestLabel.TextAlign = ContentAlignment.MiddleRight;
                    tipCalculatorTabControl.TabPages[1].Controls.Add(guestLabel);
                    guestLabelArray[x] = guestLabel;

                    TrackBar guestTrackBar = new TrackBar();
                    guestTrackBar.Location = new Point(151, (spacing * (x + 1)));
                    guestTrackBar.Margin = new Padding(4);  
                    guestTrackBar.Value = 10;
                    guestTrackBar.Name = "trackBar" + x;
                    guestTrackBar.Size = new Size(175, 45);
                    guestTrackBar.TabIndex = 34;
                    guestTrackBar.Tag = guestLabel;
                    tipCalculatorTabControl.TabPages[1].Controls.Add(guestTrackBar);
                    guestTrackBar.ValueChanged += OnTrackBarValueChanged;
                    trackBarArray[x] = guestTrackBar;

                    Label dollarLabel = new Label();
                    dollarLabel.AutoSize = true;
                    dollarLabel.Location = new Point(326, (spacing * (x + 1)));
                    dollarLabel.Name = "dollarLabel";
                    dollarLabel.Size = new Size(16, 18);
                    dollarLabel.TabIndex = 37;
                    dollarLabel.Text = "$";
                    tipCalculatorTabControl.TabPages[1].Controls.Add(dollarLabel);
                }
            }

            tipRateLabel.Text = CalculateTipRate();

            perPersonTipLabel.Text = CalculatePerPersonTip().ToString();

            UpdateTotal();
        }

        private void billTotalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && billTotalTextBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // error if user tries to enter a negative
            if (e.KeyChar == '-')
            {
                errorProvider1.SetError(billTotalTextBox, "Bill total cannot be a negative number.");
                errorLabel.Text = errorMsg;
            }
        }

        private void billTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(billTotalTextBox.Text))
            {
                UpdateTotal();
            }
        }

        private void billTotalTextBox_Leave(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorLabel.Text = string.Empty;

            if (!string.IsNullOrEmpty(billTotalTextBox.Text))
            {
                decimal num = Decimal.Parse(billTotalTextBox.Text);
                billTotalTextBox.Text = num.ToString("F2");
            }
            else
            {
                billTotalTextBox.Text = "0.00";
            }
        }

        private void billDeductionsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && billDeductionsTextBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // error if user tries to enter a negative
            if (e.KeyChar == '-')
            {
                errorProvider1.SetError(billDeductionsTextBox, "Bill deductions cannot be a negative number.");
                errorLabel.Text = errorMsg;
            }
        }

        private void billDeductionsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(billDeductionsTextBox.Text))
            {
                if (Decimal.Parse(billDeductionsTextBox.Text) > Decimal.Parse(billTotalTextBox.Text))
                {
                    errorProvider1.SetError(billDeductionsTextBox, "Bill deductions cannot exceed bill total.");
                    errorLabel.Text = errorMsg;
                }
                else
                {
                    errorProvider1.Clear();
                    errorLabel.Text = string.Empty;
                    UpdateTotal();
                }
            }
        }

        private void billDeductionsTextBox_Leave(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(billDeductionsTextBox) != "")
            {
                billDeductionsTextBox.Text = "0.00";
                errorProvider1.Clear();
                errorLabel.Text = string.Empty;
            }
            else if (!string.IsNullOrEmpty(billDeductionsTextBox.Text))
            {
                decimal num = Decimal.Parse(billDeductionsTextBox.Text);
                billDeductionsTextBox.Text = num.ToString("F2");
            }
            else
            {
                billDeductionsTextBox.Text = "0.00";
            }
        }

        private void taxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && taxTextBox.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }

            // error if user tries to enter a negative
            if (e.KeyChar == '-')
            {
                errorProvider1.SetError(taxTextBox, "Tax amount cannot be a negative number.");
                errorLabel.Text = errorMsg;
            }
        }

        private void taxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(taxTextBox.Text) && !string.IsNullOrEmpty(taxTextBox.Text))
            {
                if (Decimal.Parse(taxTextBox.Text) > Decimal.Parse(billTotalTextBox.Text))
                {
                    errorProvider1.SetError(taxTextBox, "Tax amount cannot exceed bill total.");
                    errorLabel.Text = errorMsg;
                }
                else
                {
                    errorProvider1.Clear();
                    errorLabel.Text = string.Empty;
                    UpdateTotal();
                }
            }
        }

        private void taxTextBox_Leave(object sender, EventArgs e)
        {
            if (errorProvider1.GetError(taxTextBox) != "")
            {
                taxTextBox.Text = "0.00";
                errorProvider1.Clear();
                errorLabel.Text = string.Empty;
            }

            if (!string.IsNullOrEmpty(taxTextBox.Text))
            {
                decimal num = Decimal.Parse(taxTextBox.Text);
                taxTextBox.Text = num.ToString("F2");
            }
            else
            {
                taxTextBox.Text = "0.00";
            }
        }

        private void qualityTrackBar_ValueChanged(object sender, EventArgs e)
        {
            tipRateLabel.Text = CalculateTipRate();
            UpdateTotal();
        }

        private void minTipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void minTipTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(minTipTextBox.Text) && !string.IsNullOrEmpty(maxTipTextBox.Text))
            {
                if (Decimal.Parse(minTipTextBox.Text) > Decimal.Parse(maxTipTextBox.Text))
                {
                    errorProvider1.SetError(minTipTextBox, "Minimun Tip Percentage must be less than or equal to Maximum Tip Percentage.");
                    errorLabel.Text = errorMsg;
                }
                else
                {
                    errorProvider1.Clear();
                    errorLabel.Text = string.Empty;
                    tipRateLabel.Text = CalculateTipRate();
                }
            }
        }

        private void minTipTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(minTipTextBox.Text))
            {
                decimal num = Decimal.Parse(minTipTextBox.Text);
                minTipTextBox.Text = num.ToString("F1");
            }
        }

        private void maxTipTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void maxTipTextBox_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(minTipTextBox.Text) && !string.IsNullOrEmpty(maxTipTextBox.Text))
            {
                if (Decimal.Parse(maxTipTextBox.Text) < Decimal.Parse(minTipTextBox.Text))
                {
                    errorProvider1.SetError(maxTipTextBox, "Maximum Tip Percentage must be greater than or equal to Minimum Tip Percentage.");
                    errorLabel.Text = errorMsg;
                }
                else
                {
                    errorProvider1.Clear();
                    errorLabel.Text = string.Empty;
                    tipRateLabel.Text = CalculateTipRate();
                }
            }
        }

        private void maxTipTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maxTipTextBox.Text))
            {
                decimal num = Decimal.Parse(maxTipTextBox.Text);
                maxTipTextBox.Text = num.ToString("F1");
            }
        }

        private void includeTaxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void includeDeductionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }
    }
}
