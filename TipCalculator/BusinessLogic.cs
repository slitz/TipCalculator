using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class TipSplittingCalculatorForm : Form
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
        /// Determines subtotal for the tip calculation based on state of Include Tax and Include Deducations checkboxes.
        /// </summary>
        /// <param name="total">Value from Bill Total text box.</param>
        /// <param name="deductions">Value from Deductions text box.</param>
        /// <param name="tax">Value from Tax text box.</param>
        /// <returns>Subtotal value for use in tip calculation.</returns>
        private decimal CalculateSubTotalForTip()
        {
            billTotal = Decimal.Parse(billTotalTextBox.Text);
            billDeductions = Decimal.Parse(billDeductionsTextBox.Text);
            tax = Decimal.Parse(taxTextBox.Text);

            if (includeTaxCheckBox.Checked)
            {
                if (includeDeductionsCheckBox.Checked)
                {
                    return billTotal - billDeductions + tax;
                }
                else
                {
                    return billTotal + tax;
                }
            }
            else
            {
                if (includeDeductionsCheckBox.Checked)
                {
                    return billTotal - billDeductions;
                }
                else
                {
                    return billTotal;
                }
            }
        }

        public decimal CalculateTotalTip()
        {
            subtotal = CalculateSubTotalForTip();
            return (subtotal * (Decimal.Parse(CalculateTipRate())) / 100);
        }

        public void UpdateGuestsTipAmount()
        {
            // Get all the controls on the Tip Tailoriong screen and update labels for each guest with an even tip amount
            foreach (Control c in tipCalculatorTabControl.TabPages[1].Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    if (c.Name.StartsWith("guest"))
                    {
                        c.Text = CalculatePerPersonTip().ToString("F2");
                    }
                }
            }
        }

        public decimal CalculateTailoredTotalTip()
        {
            decimal tailoredTipTotal = 0;

            // Get all the controls on the Tip Tailoriong screen and update labels for each guest with an even tip amount
            foreach (Control c in tipCalculatorTabControl.TabPages[1].Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    if (c.Name.StartsWith("guest"))
                    {
                        tailoredTipTotal += Decimal.Parse(c.Text);
                    }
                }
            }

            return tailoredTipTotal;
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

            return (((maxTipRate - minTipRate) * (serviceRate / 10)) + minTipRate).ToString();
        }

        public decimal CalculatePerPersonTip()
        {
            totalTip = CalculateTotalTip();

            return totalTip / (decimal)guestCount;
        }

        public decimal CalculateTailoredTipRate()
        {
            return (Decimal.Parse(totalTipLabel.Text) / CalculateSubTotalForTip()) * 100;
        }

        private decimal CalculateSubTotalForBill()
        {
            billTotal = Decimal.Parse(billTotalTextBox.Text);
            billDeductions = Decimal.Parse(billDeductionsTextBox.Text);
            tax = Decimal.Parse(taxTextBox.Text);

            return billTotal - billDeductions + tax;
        }

        /// <summary>
        /// Performs final total calculations and updates total label.
        /// </summary>
        public void UpdateTotal()
        {
            if (!string.IsNullOrEmpty(billTotalTextBox.Text) && (!string.IsNullOrEmpty(billDeductionsTextBox.Text) && !string.IsNullOrEmpty(taxTextBox.Text)) && !string.IsNullOrEmpty(guestsTextBox.Text))
            {
                if (perPersonTipLabel.Text != "Tailored")
                {
                    totalTip = CalculateTotalTip();

                    totalTipLabel.Text = totalTip.ToString("F2");

                    perPersonTipLabel.Text = (Decimal.Parse(totalTipLabel.Text) / Decimal.Parse(guestsTextBox.Text)).ToString("F2");

                    UpdateGuestsTipAmount();
                }
                else
                {
                    totalTip = CalculateTailoredTotalTip();
                }

                subtotal = CalculateSubTotalForBill();

                total = subtotal + totalTip;

                totalLabel.Text = total.ToString("F2");
            }
        }
    }
}