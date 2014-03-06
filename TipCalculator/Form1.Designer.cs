using System;
namespace TipCalculator
{
    partial class tipSplittingCalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tipSplittingCalculatorForm));
            this.tipCalculatorTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.perPersonTipLabel = new System.Windows.Forms.Label();
            this.totalTipLabel = new System.Windows.Forms.Label();
            this.tipRateLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.qualityTrackBar = new System.Windows.Forms.TrackBar();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.billDeductionsTextBox = new System.Windows.Forms.TextBox();
            this.billTotalTextBox = new System.Windows.Forms.TextBox();
            this.guestsTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dollarLabel = new System.Windows.Forms.Label();
            this.guestOneLabel = new System.Windows.Forms.Label();
            this.guestOneTrackBar = new System.Windows.Forms.TrackBar();
            this.guestOneTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.includeDeductionsCheckBox = new System.Windows.Forms.CheckBox();
            this.includeTaxCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maxTipTextBox = new System.Windows.Forms.TextBox();
            this.minTipTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.tipCalculatorTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestOneTrackBar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tipCalculatorTabControl
            // 
            this.tipCalculatorTabControl.Controls.Add(this.tabPage1);
            this.tipCalculatorTabControl.Controls.Add(this.tabPage2);
            this.tipCalculatorTabControl.Controls.Add(this.tabPage3);
            this.tipCalculatorTabControl.Location = new System.Drawing.Point(28, 28);
            this.tipCalculatorTabControl.Name = "tipCalculatorTabControl";
            this.tipCalculatorTabControl.SelectedIndex = 0;
            this.tipCalculatorTabControl.Size = new System.Drawing.Size(481, 437);
            this.tipCalculatorTabControl.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.totalLabel);
            this.tabPage1.Controls.Add(this.perPersonTipLabel);
            this.tabPage1.Controls.Add(this.totalTipLabel);
            this.tabPage1.Controls.Add(this.tipRateLabel);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.qualityTrackBar);
            this.tabPage1.Controls.Add(this.taxTextBox);
            this.tabPage1.Controls.Add(this.billDeductionsTextBox);
            this.tabPage1.Controls.Add(this.billTotalTextBox);
            this.tabPage1.Controls.Add(this.guestsTextBox);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(473, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tip Calculator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "%";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(276, 352);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 18);
            this.label27.TabIndex = 41;
            this.label27.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(276, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 18);
            this.label13.TabIndex = 40;
            this.label13.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(276, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(276, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 18);
            this.label11.TabIndex = 38;
            this.label11.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(276, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 144);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 18);
            this.label9.TabIndex = 36;
            this.label9.Text = "$";
            // 
            // totalLabel
            // 
            this.totalLabel.AllowDrop = true;
            this.totalLabel.Location = new System.Drawing.Point(299, 351);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(132, 26);
            this.totalLabel.TabIndex = 35;
            this.totalLabel.Text = "0.00";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // perPersonTipLabel
            // 
            this.perPersonTipLabel.AllowDrop = true;
            this.perPersonTipLabel.Location = new System.Drawing.Point(299, 316);
            this.perPersonTipLabel.Name = "perPersonTipLabel";
            this.perPersonTipLabel.Size = new System.Drawing.Size(132, 26);
            this.perPersonTipLabel.TabIndex = 34;
            this.perPersonTipLabel.Text = "0.00";
            this.perPersonTipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalTipLabel
            // 
            this.totalTipLabel.AllowDrop = true;
            this.totalTipLabel.Location = new System.Drawing.Point(299, 281);
            this.totalTipLabel.Name = "totalTipLabel";
            this.totalTipLabel.Size = new System.Drawing.Size(132, 26);
            this.totalTipLabel.TabIndex = 33;
            this.totalTipLabel.Text = "0.00";
            this.totalTipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tipRateLabel
            // 
            this.tipRateLabel.AllowDrop = true;
            this.tipRateLabel.Location = new System.Drawing.Point(299, 246);
            this.tipRateLabel.Name = "tipRateLabel";
            this.tipRateLabel.Size = new System.Drawing.Size(113, 26);
            this.tipRateLabel.TabIndex = 32;
            this.tipRateLabel.Text = "0.0";
            this.tipRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(41, 351);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 18);
            this.label18.TabIndex = 31;
            this.label18.Text = "Total (Bill and Tip)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(41, 316);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 18);
            this.label19.TabIndex = 30;
            this.label19.Text = "Per Person Tip";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(41, 281);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 18);
            this.label20.TabIndex = 29;
            this.label20.Text = "Total Tip";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(41, 246);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 18);
            this.label21.TabIndex = 28;
            this.label21.Text = "Tip Rate";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(41, 211);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 18);
            this.label22.TabIndex = 27;
            this.label22.Text = "Tax";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(41, 176);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(99, 18);
            this.label23.TabIndex = 26;
            this.label23.Text = "Bill Deductions";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(41, 141);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(61, 18);
            this.label24.TabIndex = 25;
            this.label24.Text = "Bill Total";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(41, 82);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(121, 18);
            this.label25.TabIndex = 24;
            this.label25.Text = "Quality of Service";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(41, 42);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(128, 18);
            this.label26.TabIndex = 23;
            this.label26.Text = "Number of Guests";
            // 
            // qualityTrackBar
            // 
            this.qualityTrackBar.LargeChange = 1;
            this.qualityTrackBar.Location = new System.Drawing.Point(187, 82);
            this.qualityTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.qualityTrackBar.Name = "qualityTrackBar";
            this.qualityTrackBar.Size = new System.Drawing.Size(244, 45);
            this.qualityTrackBar.TabIndex = 22;
            this.qualityTrackBar.Value = 6;
            this.qualityTrackBar.Scroll += new System.EventHandler(this.qualityTrackBar_ValueChanged);
            // 
            // taxTextBox
            // 
            this.taxTextBox.Location = new System.Drawing.Point(299, 211);
            this.taxTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(132, 26);
            this.taxTextBox.TabIndex = 21;
            this.taxTextBox.Text = "0.00";
            this.taxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.taxTextBox.TextChanged += new System.EventHandler(this.taxTextBox_TextChanged);
            this.taxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taxTextBox_KeyPress);
            this.taxTextBox.Leave += new System.EventHandler(this.taxTextBox_Leave);
            // 
            // billDeductionsTextBox
            // 
            this.billDeductionsTextBox.Location = new System.Drawing.Point(299, 176);
            this.billDeductionsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.billDeductionsTextBox.Name = "billDeductionsTextBox";
            this.billDeductionsTextBox.Size = new System.Drawing.Size(132, 26);
            this.billDeductionsTextBox.TabIndex = 20;
            this.billDeductionsTextBox.Text = "0.00";
            this.billDeductionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.billDeductionsTextBox.TextChanged += new System.EventHandler(this.billDeductionsTextBox_TextChanged);
            this.billDeductionsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billDeductionsTextBox_KeyPress);
            this.billDeductionsTextBox.Leave += new System.EventHandler(this.billDeductionsTextBox_Leave);
            // 
            // billTotalTextBox
            // 
            this.billTotalTextBox.Location = new System.Drawing.Point(299, 141);
            this.billTotalTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.billTotalTextBox.Name = "billTotalTextBox";
            this.billTotalTextBox.Size = new System.Drawing.Size(132, 26);
            this.billTotalTextBox.TabIndex = 19;
            this.billTotalTextBox.Text = "0.00";
            this.billTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.billTotalTextBox.TextChanged += new System.EventHandler(this.billTotalTextBox_TextChanged);
            this.billTotalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.billTotalTextBox_KeyPress);
            this.billTotalTextBox.Leave += new System.EventHandler(this.billTotalTextBox_Leave);
            // 
            // guestsTextBox
            // 
            this.guestsTextBox.Location = new System.Drawing.Point(362, 42);
            this.guestsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestsTextBox.MaxLength = 2;
            this.guestsTextBox.Name = "guestsTextBox";
            this.guestsTextBox.Size = new System.Drawing.Size(69, 26);
            this.guestsTextBox.TabIndex = 18;
            this.guestsTextBox.Text = "1";
            this.guestsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guestsTextBox.TextChanged += new System.EventHandler(this.guestsTextBox_TextChanged);
            this.guestsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guestsTextBox_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.dollarLabel);
            this.tabPage2.Controls.Add(this.guestOneLabel);
            this.tabPage2.Controls.Add(this.guestOneTrackBar);
            this.tabPage2.Controls.Add(this.guestOneTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(473, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tip Tailoring";
            // 
            // dollarLabel
            // 
            this.dollarLabel.AutoSize = true;
            this.dollarLabel.Location = new System.Drawing.Point(326, 41);
            this.dollarLabel.Name = "dollarLabel";
            this.dollarLabel.Size = new System.Drawing.Size(16, 18);
            this.dollarLabel.TabIndex = 37;
            this.dollarLabel.Text = "$";
            // 
            // guestOneLabel
            // 
            this.guestOneLabel.AllowDrop = true;
            this.guestOneLabel.Location = new System.Drawing.Point(344, 42);
            this.guestOneLabel.Name = "guestOneLabel";
            this.guestOneLabel.Size = new System.Drawing.Size(87, 26);
            this.guestOneLabel.TabIndex = 33;
            this.guestOneLabel.Text = "0.00";
            this.guestOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // guestOneTrackBar
            // 
            this.guestOneTrackBar.Location = new System.Drawing.Point(151, 40);
            this.guestOneTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.guestOneTrackBar.Name = "guestOneTrackBar";
            this.guestOneTrackBar.Size = new System.Drawing.Size(175, 45);
            this.guestOneTrackBar.TabIndex = 27;
            this.guestOneTrackBar.Value = 10;
            // 
            // guestOneTextBox
            // 
            this.guestOneTextBox.Location = new System.Drawing.Point(41, 42);
            this.guestOneTextBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.guestOneTextBox.Name = "guestOneTextBox";
            this.guestOneTextBox.Size = new System.Drawing.Size(102, 26);
            this.guestOneTextBox.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage3.Controls.Add(this.includeDeductionsCheckBox);
            this.tabPage3.Controls.Add(this.includeTaxCheckBox);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.maxTipTextBox);
            this.tabPage3.Controls.Add(this.minTipTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(473, 406);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " Configure Tip Items";
            // 
            // includeDeductionsCheckBox
            // 
            this.includeDeductionsCheckBox.AutoSize = true;
            this.includeDeductionsCheckBox.Checked = true;
            this.includeDeductionsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeDeductionsCheckBox.Location = new System.Drawing.Point(161, 349);
            this.includeDeductionsCheckBox.Name = "includeDeductionsCheckBox";
            this.includeDeductionsCheckBox.Size = new System.Drawing.Size(150, 22);
            this.includeDeductionsCheckBox.TabIndex = 34;
            this.includeDeductionsCheckBox.Text = "Include Deductions";
            this.includeDeductionsCheckBox.UseVisualStyleBackColor = true;
            this.includeDeductionsCheckBox.CheckedChanged += new System.EventHandler(this.includeDeductionsCheckBox_CheckedChanged);
            // 
            // includeTaxCheckBox
            // 
            this.includeTaxCheckBox.AutoSize = true;
            this.includeTaxCheckBox.Checked = true;
            this.includeTaxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeTaxCheckBox.Location = new System.Drawing.Point(161, 310);
            this.includeTaxCheckBox.Name = "includeTaxCheckBox";
            this.includeTaxCheckBox.Size = new System.Drawing.Size(105, 22);
            this.includeTaxCheckBox.TabIndex = 33;
            this.includeTaxCheckBox.Text = "Include Tax";
            this.includeTaxCheckBox.UseVisualStyleBackColor = true;
            this.includeTaxCheckBox.CheckedChanged += new System.EventHandler(this.includeTaxCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(52, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(369, 81);
            this.label8.TabIndex = 32;
            this.label8.Text = "The tip base is the items of the bill used to determine the tip amount.   The tip" +
    " base consists of:  the Bill Total, the Tax, and items deducted from bill (disco" +
    "unts, refunds ...).";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(52, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 59);
            this.label7.TabIndex = 31;
            this.label7.Text = "The tip range is the percentage range for selecting tips.  Default values are pro" +
    "vided but you can adjust the ranges if you wish.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 30;
            this.label5.Text = "Maximum Tip Percentage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 123);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 18);
            this.label6.TabIndex = 29;
            this.label6.Text = "Minimum Tip Percentage";
            // 
            // maxTipTextBox
            // 
            this.maxTipTextBox.Location = new System.Drawing.Point(306, 158);
            this.maxTipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maxTipTextBox.MaxLength = 3;
            this.maxTipTextBox.Name = "maxTipTextBox";
            this.maxTipTextBox.Size = new System.Drawing.Size(119, 26);
            this.maxTipTextBox.TabIndex = 28;
            this.maxTipTextBox.Text = "30.0";
            this.maxTipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxTipTextBox.TextChanged += new System.EventHandler(this.maxTipTextBox_ValueChanged);
            this.maxTipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maxTipTextBox_KeyPress);
            this.maxTipTextBox.Leave += new System.EventHandler(this.maxTipTextBox_Leave);
            // 
            // minTipTextBox
            // 
            this.minTipTextBox.Location = new System.Drawing.Point(306, 123);
            this.minTipTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.minTipTextBox.MaxLength = 2;
            this.minTipTextBox.Name = "minTipTextBox";
            this.minTipTextBox.Size = new System.Drawing.Size(119, 26);
            this.minTipTextBox.TabIndex = 27;
            this.minTipTextBox.Text = "5.0";
            this.minTipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minTipTextBox.TextChanged += new System.EventHandler(this.minTipTextBox_ValueChanged);
            this.minTipTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minTipTextBox_KeyPress);
            this.minTipTextBox.Leave += new System.EventHandler(this.minTipTextBox_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.Location = new System.Drawing.Point(28, 472);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(477, 27);
            this.errorLabel.TabIndex = 21;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipSplittingCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 508);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.tipCalculatorTabControl);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tipSplittingCalculatorForm";
            this.Text = "Tip Splitting Calculator";
            this.Load += new System.EventHandler(this.tipSplittingCalculatorForm_Load);
            this.tipCalculatorTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualityTrackBar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guestOneTrackBar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tipCalculatorTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label perPersonTipLabel;
        private System.Windows.Forms.Label totalTipLabel;
        private System.Windows.Forms.Label tipRateLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TrackBar qualityTrackBar;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox billDeductionsTextBox;
        private System.Windows.Forms.TextBox guestsTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox includeDeductionsCheckBox;
        private System.Windows.Forms.CheckBox includeTaxCheckBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox maxTipTextBox;
        private System.Windows.Forms.TextBox minTipTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox billTotalTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label guestOneLabel;
        private System.Windows.Forms.TrackBar guestOneTrackBar;
        private System.Windows.Forms.TextBox guestOneTextBox;
        private System.Windows.Forms.Label dollarLabel;

    }
}

