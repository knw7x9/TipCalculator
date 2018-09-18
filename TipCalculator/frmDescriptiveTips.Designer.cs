namespace TipCalculator {
    partial class frmDescriptiveTips {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtMealCost = new System.Windows.Forms.TextBox();
            this.chkSeatedQuickly = new System.Windows.Forms.CheckBox();
            this.txtSeatedQuicklyCustom = new System.Windows.Forms.TextBox();
            this.chkDrinksFull = new System.Windows.Forms.CheckBox();
            this.txtDrinksFullCustom = new System.Windows.Forms.TextBox();
            this.chkFriendly = new System.Windows.Forms.CheckBox();
            this.txtFriendlyCustom = new System.Windows.Forms.TextBox();
            this.chkFoodPromptly = new System.Windows.Forms.CheckBox();
            this.txtFoodPromptlyCustom = new System.Windows.Forms.TextBox();
            this.chkComplaintsHandled = new System.Windows.Forms.CheckBox();
            this.txtComplaintsHandledCustom = new System.Windows.Forms.TextBox();
            this.txtDesiredTip = new System.Windows.Forms.TextBox();
            this.lblMealCost = new System.Windows.Forms.Label();
            this.lblDollarSign = new System.Windows.Forms.Label();
            this.lblSeatedQuicklyCustom = new System.Windows.Forms.Label();
            this.lblPercentSign1 = new System.Windows.Forms.Label();
            this.lblDrinksFullCustom = new System.Windows.Forms.Label();
            this.lblPercentSign2 = new System.Windows.Forms.Label();
            this.lblFriendlyCustom = new System.Windows.Forms.Label();
            this.lblPercentSign3 = new System.Windows.Forms.Label();
            this.lblFoodPromptlyCustom = new System.Windows.Forms.Label();
            this.lblPercentSign4 = new System.Windows.Forms.Label();
            this.lblComplaintsHandledCustom = new System.Windows.Forms.Label();
            this.lblPercentSign5 = new System.Windows.Forms.Label();
            this.lblDesiredTip = new System.Windows.Forms.Label();
            this.lblPercentSign8 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTipPercent = new System.Windows.Forms.Label();
            this.lblOutputTipPercent = new System.Windows.Forms.Label();
            this.lblTipAmount = new System.Windows.Forms.Label();
            this.lblOutputTipAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblOutputTotalAmount = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtMealCost
            // 
            this.txtMealCost.Location = new System.Drawing.Point(270, 24);
            this.txtMealCost.Name = "txtMealCost";
            this.txtMealCost.Size = new System.Drawing.Size(100, 20);
            this.txtMealCost.TabIndex = 0;
            // 
            // chkSeatedQuickly
            // 
            this.chkSeatedQuickly.AutoSize = true;
            this.chkSeatedQuickly.Location = new System.Drawing.Point(12, 85);
            this.chkSeatedQuickly.Name = "chkSeatedQuickly";
            this.chkSeatedQuickly.Size = new System.Drawing.Size(122, 17);
            this.chkSeatedQuickly.TabIndex = 2;
            this.chkSeatedQuickly.Text = "Seated quickly. (5%)";
            this.chkSeatedQuickly.UseVisualStyleBackColor = true;
            // 
            // txtSeatedQuicklyCustom
            // 
            this.txtSeatedQuicklyCustom.Location = new System.Drawing.Point(204, 83);
            this.txtSeatedQuicklyCustom.Name = "txtSeatedQuicklyCustom";
            this.txtSeatedQuicklyCustom.Size = new System.Drawing.Size(40, 20);
            this.txtSeatedQuicklyCustom.TabIndex = 3;
            // 
            // chkDrinksFull
            // 
            this.chkDrinksFull.AutoSize = true;
            this.chkDrinksFull.Location = new System.Drawing.Point(279, 86);
            this.chkDrinksFull.Name = "chkDrinksFull";
            this.chkDrinksFull.Size = new System.Drawing.Size(122, 17);
            this.chkDrinksFull.TabIndex = 4;
            this.chkDrinksFull.Text = "Drinks kept full. (5%)";
            this.chkDrinksFull.UseVisualStyleBackColor = true;
            // 
            // txtDrinksFullCustom
            // 
            this.txtDrinksFullCustom.Location = new System.Drawing.Point(482, 83);
            this.txtDrinksFullCustom.Name = "txtDrinksFullCustom";
            this.txtDrinksFullCustom.Size = new System.Drawing.Size(40, 20);
            this.txtDrinksFullCustom.TabIndex = 5;
            // 
            // chkFriendly
            // 
            this.chkFriendly.AutoSize = true;
            this.chkFriendly.Location = new System.Drawing.Point(12, 109);
            this.chkFriendly.Name = "chkFriendly";
            this.chkFriendly.Size = new System.Drawing.Size(141, 17);
            this.chkFriendly.TabIndex = 6;
            this.chkFriendly.Text = "Server was friendly. (5%)";
            this.chkFriendly.UseVisualStyleBackColor = true;
            // 
            // txtFriendlyCustom
            // 
            this.txtFriendlyCustom.Location = new System.Drawing.Point(204, 107);
            this.txtFriendlyCustom.Name = "txtFriendlyCustom";
            this.txtFriendlyCustom.Size = new System.Drawing.Size(40, 20);
            this.txtFriendlyCustom.TabIndex = 7;
            // 
            // chkFoodPromptly
            // 
            this.chkFoodPromptly.AutoSize = true;
            this.chkFoodPromptly.Location = new System.Drawing.Point(279, 109);
            this.chkFoodPromptly.Name = "chkFoodPromptly";
            this.chkFoodPromptly.Size = new System.Drawing.Size(153, 17);
            this.chkFoodPromptly.TabIndex = 8;
            this.chkFoodPromptly.Text = "Food served promptly. (5%)";
            this.chkFoodPromptly.UseVisualStyleBackColor = true;
            // 
            // txtFoodPromptlyCustom
            // 
            this.txtFoodPromptlyCustom.Location = new System.Drawing.Point(482, 107);
            this.txtFoodPromptlyCustom.Name = "txtFoodPromptlyCustom";
            this.txtFoodPromptlyCustom.Size = new System.Drawing.Size(40, 20);
            this.txtFoodPromptlyCustom.TabIndex = 9;
            // 
            // chkComplaintsHandled
            // 
            this.chkComplaintsHandled.AutoSize = true;
            this.chkComplaintsHandled.Location = new System.Drawing.Point(12, 132);
            this.chkComplaintsHandled.Name = "chkComplaintsHandled";
            this.chkComplaintsHandled.Size = new System.Drawing.Size(261, 17);
            this.chkComplaintsHandled.TabIndex = 10;
            this.chkComplaintsHandled.Text = "Complaints handled in a professional manner. (5%)";
            this.chkComplaintsHandled.UseVisualStyleBackColor = true;
            // 
            // txtComplaintsHandledCustom
            // 
            this.txtComplaintsHandledCustom.Location = new System.Drawing.Point(326, 130);
            this.txtComplaintsHandledCustom.Name = "txtComplaintsHandledCustom";
            this.txtComplaintsHandledCustom.Size = new System.Drawing.Size(40, 20);
            this.txtComplaintsHandledCustom.TabIndex = 11;
            // 
            // txtDesiredTip
            // 
            this.txtDesiredTip.Location = new System.Drawing.Point(270, 50);
            this.txtDesiredTip.Name = "txtDesiredTip";
            this.txtDesiredTip.Size = new System.Drawing.Size(100, 20);
            this.txtDesiredTip.TabIndex = 1;
            // 
            // lblMealCost
            // 
            this.lblMealCost.AutoSize = true;
            this.lblMealCost.Location = new System.Drawing.Point(187, 27);
            this.lblMealCost.Name = "lblMealCost";
            this.lblMealCost.Size = new System.Drawing.Size(57, 13);
            this.lblMealCost.TabIndex = 14;
            this.lblMealCost.Text = "Meal Cost:";
            // 
            // lblDollarSign
            // 
            this.lblDollarSign.AutoSize = true;
            this.lblDollarSign.Location = new System.Drawing.Point(251, 27);
            this.lblDollarSign.Name = "lblDollarSign";
            this.lblDollarSign.Size = new System.Drawing.Size(13, 13);
            this.lblDollarSign.TabIndex = 15;
            this.lblDollarSign.Text = "$";
            // 
            // lblSeatedQuicklyCustom
            // 
            this.lblSeatedQuicklyCustom.AutoSize = true;
            this.lblSeatedQuicklyCustom.Location = new System.Drawing.Point(154, 86);
            this.lblSeatedQuicklyCustom.Name = "lblSeatedQuicklyCustom";
            this.lblSeatedQuicklyCustom.Size = new System.Drawing.Size(45, 13);
            this.lblSeatedQuicklyCustom.TabIndex = 16;
            this.lblSeatedQuicklyCustom.Text = "Custom:";
            // 
            // lblPercentSign1
            // 
            this.lblPercentSign1.AutoSize = true;
            this.lblPercentSign1.Location = new System.Drawing.Point(250, 87);
            this.lblPercentSign1.Name = "lblPercentSign1";
            this.lblPercentSign1.Size = new System.Drawing.Size(15, 13);
            this.lblPercentSign1.TabIndex = 17;
            this.lblPercentSign1.Text = "%";
            // 
            // lblDrinksFullCustom
            // 
            this.lblDrinksFullCustom.AutoSize = true;
            this.lblDrinksFullCustom.Location = new System.Drawing.Point(431, 86);
            this.lblDrinksFullCustom.Name = "lblDrinksFullCustom";
            this.lblDrinksFullCustom.Size = new System.Drawing.Size(45, 13);
            this.lblDrinksFullCustom.TabIndex = 18;
            this.lblDrinksFullCustom.Text = "Custom:";
            // 
            // lblPercentSign2
            // 
            this.lblPercentSign2.AutoSize = true;
            this.lblPercentSign2.Location = new System.Drawing.Point(528, 87);
            this.lblPercentSign2.Name = "lblPercentSign2";
            this.lblPercentSign2.Size = new System.Drawing.Size(15, 13);
            this.lblPercentSign2.TabIndex = 19;
            this.lblPercentSign2.Text = "%";
            // 
            // lblFriendlyCustom
            // 
            this.lblFriendlyCustom.AutoSize = true;
            this.lblFriendlyCustom.Location = new System.Drawing.Point(154, 110);
            this.lblFriendlyCustom.Name = "lblFriendlyCustom";
            this.lblFriendlyCustom.Size = new System.Drawing.Size(45, 13);
            this.lblFriendlyCustom.TabIndex = 20;
            this.lblFriendlyCustom.Text = "Custom:";
            // 
            // lblPercentSign3
            // 
            this.lblPercentSign3.AutoSize = true;
            this.lblPercentSign3.Location = new System.Drawing.Point(250, 113);
            this.lblPercentSign3.Name = "lblPercentSign3";
            this.lblPercentSign3.Size = new System.Drawing.Size(15, 13);
            this.lblPercentSign3.TabIndex = 21;
            this.lblPercentSign3.Text = "%";
            // 
            // lblFoodPromptlyCustom
            // 
            this.lblFoodPromptlyCustom.AutoSize = true;
            this.lblFoodPromptlyCustom.Location = new System.Drawing.Point(434, 110);
            this.lblFoodPromptlyCustom.Name = "lblFoodPromptlyCustom";
            this.lblFoodPromptlyCustom.Size = new System.Drawing.Size(45, 13);
            this.lblFoodPromptlyCustom.TabIndex = 22;
            this.lblFoodPromptlyCustom.Text = "Custom:";
            // 
            // lblPercentSign4
            // 
            this.lblPercentSign4.AutoSize = true;
            this.lblPercentSign4.Location = new System.Drawing.Point(528, 113);
            this.lblPercentSign4.Name = "lblPercentSign4";
            this.lblPercentSign4.Size = new System.Drawing.Size(15, 13);
            this.lblPercentSign4.TabIndex = 23;
            this.lblPercentSign4.Text = "%";
            // 
            // lblComplaintsHandledCustom
            // 
            this.lblComplaintsHandledCustom.AutoSize = true;
            this.lblComplaintsHandledCustom.Location = new System.Drawing.Point(277, 133);
            this.lblComplaintsHandledCustom.Name = "lblComplaintsHandledCustom";
            this.lblComplaintsHandledCustom.Size = new System.Drawing.Size(45, 13);
            this.lblComplaintsHandledCustom.TabIndex = 24;
            this.lblComplaintsHandledCustom.Text = "Custom:";
            // 
            // lblPercentSign5
            // 
            this.lblPercentSign5.AutoSize = true;
            this.lblPercentSign5.Location = new System.Drawing.Point(372, 133);
            this.lblPercentSign5.Name = "lblPercentSign5";
            this.lblPercentSign5.Size = new System.Drawing.Size(15, 13);
            this.lblPercentSign5.TabIndex = 25;
            this.lblPercentSign5.Text = "%";
            // 
            // lblDesiredTip
            // 
            this.lblDesiredTip.AutoSize = true;
            this.lblDesiredTip.Location = new System.Drawing.Point(180, 53);
            this.lblDesiredTip.Name = "lblDesiredTip";
            this.lblDesiredTip.Size = new System.Drawing.Size(64, 13);
            this.lblDesiredTip.TabIndex = 30;
            this.lblDesiredTip.Text = "Desired Tip:";
            // 
            // lblPercentSign8
            // 
            this.lblPercentSign8.AutoSize = true;
            this.lblPercentSign8.Location = new System.Drawing.Point(376, 53);
            this.lblPercentSign8.Name = "lblPercentSign8";
            this.lblPercentSign8.Size = new System.Drawing.Size(15, 13);
            this.lblPercentSign8.TabIndex = 31;
            this.lblPercentSign8.Text = "%";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(176, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 25);
            this.btnCalculate.TabIndex = 32;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTipPercent
            // 
            this.lblTipPercent.Location = new System.Drawing.Point(189, 211);
            this.lblTipPercent.Name = "lblTipPercent";
            this.lblTipPercent.Size = new System.Drawing.Size(100, 13);
            this.lblTipPercent.TabIndex = 33;
            this.lblTipPercent.Text = "Tip Percent: ";
            this.lblTipPercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOutputTipPercent
            // 
            this.lblOutputTipPercent.AutoSize = true;
            this.lblOutputTipPercent.Location = new System.Drawing.Point(300, 211);
            this.lblOutputTipPercent.Name = "lblOutputTipPercent";
            this.lblOutputTipPercent.Size = new System.Drawing.Size(0, 13);
            this.lblOutputTipPercent.TabIndex = 34;
            // 
            // lblTipAmount
            // 
            this.lblTipAmount.Location = new System.Drawing.Point(189, 239);
            this.lblTipAmount.Name = "lblTipAmount";
            this.lblTipAmount.Size = new System.Drawing.Size(100, 13);
            this.lblTipAmount.TabIndex = 35;
            this.lblTipAmount.Text = "Tip Amount ($):";
            this.lblTipAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOutputTipAmount
            // 
            this.lblOutputTipAmount.AutoSize = true;
            this.lblOutputTipAmount.Location = new System.Drawing.Point(300, 239);
            this.lblOutputTipAmount.Name = "lblOutputTipAmount";
            this.lblOutputTipAmount.Size = new System.Drawing.Size(0, 13);
            this.lblOutputTipAmount.TabIndex = 36;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.Location = new System.Drawing.Point(189, 266);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(100, 13);
            this.lblTotalAmount.TabIndex = 37;
            this.lblTotalAmount.Text = "Total Amount ($):";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOutputTotalAmount
            // 
            this.lblOutputTotalAmount.AutoSize = true;
            this.lblOutputTotalAmount.Location = new System.Drawing.Point(300, 266);
            this.lblOutputTotalAmount.Name = "lblOutputTotalAmount";
            this.lblOutputTotalAmount.Size = new System.Drawing.Size(0, 13);
            this.lblOutputTotalAmount.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(63, 304);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(200, 25);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(285, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 25);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDescriptiveTips
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 359);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblOutputTotalAmount);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.lblOutputTipAmount);
            this.Controls.Add(this.lblTipAmount);
            this.Controls.Add(this.lblOutputTipPercent);
            this.Controls.Add(this.lblTipPercent);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblPercentSign8);
            this.Controls.Add(this.lblDesiredTip);
            this.Controls.Add(this.lblPercentSign5);
            this.Controls.Add(this.lblComplaintsHandledCustom);
            this.Controls.Add(this.lblPercentSign4);
            this.Controls.Add(this.lblFoodPromptlyCustom);
            this.Controls.Add(this.lblPercentSign3);
            this.Controls.Add(this.lblFriendlyCustom);
            this.Controls.Add(this.lblPercentSign2);
            this.Controls.Add(this.lblDrinksFullCustom);
            this.Controls.Add(this.lblPercentSign1);
            this.Controls.Add(this.lblSeatedQuicklyCustom);
            this.Controls.Add(this.lblDollarSign);
            this.Controls.Add(this.lblMealCost);
            this.Controls.Add(this.txtDesiredTip);
            this.Controls.Add(this.txtComplaintsHandledCustom);
            this.Controls.Add(this.chkComplaintsHandled);
            this.Controls.Add(this.txtFoodPromptlyCustom);
            this.Controls.Add(this.chkFoodPromptly);
            this.Controls.Add(this.txtFriendlyCustom);
            this.Controls.Add(this.chkFriendly);
            this.Controls.Add(this.txtDrinksFullCustom);
            this.Controls.Add(this.chkDrinksFull);
            this.Controls.Add(this.txtSeatedQuicklyCustom);
            this.Controls.Add(this.chkSeatedQuickly);
            this.Controls.Add(this.txtMealCost);
            this.Name = "frmDescriptiveTips";
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMealCost;
        private System.Windows.Forms.CheckBox chkSeatedQuickly;
        private System.Windows.Forms.TextBox txtSeatedQuicklyCustom;
        private System.Windows.Forms.CheckBox chkDrinksFull;
        private System.Windows.Forms.TextBox txtDrinksFullCustom;
        private System.Windows.Forms.CheckBox chkFriendly;
        private System.Windows.Forms.TextBox txtFriendlyCustom;
        private System.Windows.Forms.CheckBox chkFoodPromptly;
        private System.Windows.Forms.TextBox txtFoodPromptlyCustom;
        private System.Windows.Forms.CheckBox chkComplaintsHandled;
        private System.Windows.Forms.TextBox txtComplaintsHandledCustom;
        private System.Windows.Forms.TextBox txtDesiredTip;
        private System.Windows.Forms.Label lblMealCost;
        private System.Windows.Forms.Label lblDollarSign;
        private System.Windows.Forms.Label lblSeatedQuicklyCustom;
        private System.Windows.Forms.Label lblPercentSign1;
        private System.Windows.Forms.Label lblDrinksFullCustom;
        private System.Windows.Forms.Label lblPercentSign2;
        private System.Windows.Forms.Label lblFriendlyCustom;
        private System.Windows.Forms.Label lblPercentSign3;
        private System.Windows.Forms.Label lblFoodPromptlyCustom;
        private System.Windows.Forms.Label lblPercentSign4;
        private System.Windows.Forms.Label lblComplaintsHandledCustom;
        private System.Windows.Forms.Label lblPercentSign5;
        private System.Windows.Forms.Label lblDesiredTip;
        private System.Windows.Forms.Label lblPercentSign8;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTipPercent;
        private System.Windows.Forms.Label lblOutputTipPercent;
        private System.Windows.Forms.Label lblTipAmount;
        private System.Windows.Forms.Label lblOutputTipAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblOutputTotalAmount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

