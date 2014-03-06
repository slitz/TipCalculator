using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class tipSplittingCalculatorForm : Form
    {
        decimal billTotal;
        decimal billDeductions;
        decimal tax;
        decimal totalTip;
        decimal minTipRate;
        decimal maxTipRate;
        decimal serviceRate;
        decimal subtotal;
        decimal total;

        /// <summary>
        /// Performs final total calculations and updates total label.
        /// </summary>
        public void UpdateTotal()
        {
            if (!string.IsNullOrEmpty(billTotalTextBox.Text) && (!string.IsNullOrEmpty(billDeductionsTextBox.Text) && !string.IsNullOrEmpty(taxTextBox.Text)) && !string.IsNullOrEmpty(guestsTextBox.Text))
            {
                billTotal = Decimal.Parse(billTotalTextBox.Text);
                billDeductions = Decimal.Parse(billDeductionsTextBox.Text);
                tax = Decimal.Parse(taxTextBox.Text);

                subtotal = CalculateSubTotal(billTotal, billDeductions, tax);

                totalTipLabel.Text = (subtotal * (Decimal.Parse(tipRateLabel.Text)) / 100).ToString("F2");

                perPersonTipLabel.Text = (Decimal.Parse(totalTipLabel.Text) / Decimal.Parse(guestsTextBox.Text)).ToString("F2");

                totalTip = Decimal.Parse(totalTipLabel.Text);

                total = subtotal + totalTip;

                totalLabel.Text = total.ToString();

                // Get all the controls on the Tip Tailoriong screen and update labels for each guest with an even tip amount
                foreach (Control c in tipCalculatorTabControl.TabPages[1].Controls)
                {
                    if (c.GetType() == typeof(Label))
                    {
                        if(c.Name.StartsWith("guest"))
                        {
                            c.Text = (totalTip / (decimal)guestCount).ToString("F2");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Determines subtotal based on state of Include Tax and Include Deducations checkboxes.
        /// </summary>
        /// <param name="total">Value from Bill Total text box.</param>
        /// <param name="deductions">Value from Deductions text box.</param>
        /// <param name="tax">Value from Tax text box.</param>
        /// <returns>Subtotal value for use in final total.</returns>
        private decimal CalculateSubTotal(decimal total, decimal deductions, decimal tax)
        {
            if (includeTaxCheckBox.Checked)
            {
                if (includeDeductionsCheckBox.Checked)
                {
                    return total - deductions + tax;
                }
                else
                {
                    return total + tax;
                }
            }
            else
            {
                if (includeDeductionsCheckBox.Checked)
                {
                    return total - deductions;
                }
                else
                {
                    return total;
                }
            }
        }

        /// <summary>
        /// Determines the Tip Rate based on the Minimun Tip and Maximum Tip textbox values and the Quality of Service slider value.
        /// </summary>
        /// <returns>Tip Rate</returns>
        public string CalculateTipRate()
        {
            minTipRate = Decimal.Parse(minTipTextBox.Text);
            maxTipRate = Decimal.Parse(maxTipTextBox.Text);
            serviceRate = Decimal.Parse(qualityTrackBar.Value.ToString());

            return (((maxTipRate - minTipRate) * (serviceRate / 10)) + minTipRate).ToString("F1");
        }

        public void  OnTrackBarValueChanged(object sender, EventArgs e)
        {
            var trackBar = (TrackBar)sender;
            var label = (Label)trackBar.Tag;
            perPersonTipLabel.Text = "Tailored";
        }
    }
}
