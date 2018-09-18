// frmDescriptiveTips.cs, TipCalculator.sln
// CS 1181
// Katherine Wilsdon
// 14 September 2018
// Dr. Cody Permann
/* Description - Create a tip calculator. The user inputs the meal cost and checks a series of checkboxes decribing their service.
 * The code calculates the tip percent, tip amount, and total amount and displays the results on the form.*/
/* WOW:
 * 1. Add a textbox for each checkbox so the user can customize their tip for each service.
 * 2. Add a desired tip textbox that directly calculates the outputs without customizing the tip through the checkboxes.
 * 3. Created 2 lists of checkboxes and custom textboxes.
 * 4. Used loops to iterate over the items in the list.
 * 5. Created a clear button.
 * 6. Created an exit button.
 * 7. Added an AcceptButton to the calculate button. 
 * 8. Used goto done; -> done:; to break out of an if statement. */
/* Works cited:
  * AcceptButton: https://www.youtube.com/watch?v=seA5vjbKpxc 
  * PerformClick: https://stackoverflow.com/questions/20626608/a-button-click-event-in-if-else-loop 
  * goto done; -> done:; https://social.msdn.microsoft.com/Forums/vstudio/en-US/7805b4b9-f778-4f04-a58a-b889d1395cf7/nested-if-statement-use-quotbreakquot-to-break-out-of-if-statment-only?forum=vcgeneral
  * Book, Chapters 3,4,5, and 7: Gaddis, T. (2017). Starting out with Visual C# (4th ed.). Boston, PA: Pearson. */



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator {
    public partial class frmDescriptiveTips : Form {
        public frmDescriptiveTips() {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            // Validates the txtMealCost control
            if (double.TryParse(txtMealCost.Text, out double mealCost)) {
                // Creates a list containing each checkbox
                List<bool> checkboxes = new List<bool>() {chkSeatedQuickly.Checked, chkDrinksFull.Checked,
                    chkFriendly.Checked, chkFoodPromptly.Checked, chkComplaintsHandled.Checked };
                // Creates a list containing each custom textbox
                List<string> customboxes = new List<string>() {txtSeatedQuicklyCustom.Text, txtDrinksFullCustom.Text,
                    txtFriendlyCustom.Text, txtFoodPromptlyCustom.Text, txtComplaintsHandledCustom.Text}; 
               
                // Declaring and assigning variables
                int percent = 0;
                double tipAmount = 0;
                double totalAmount = 0;

                // Validates the txtDesiredTip control
                if (int.TryParse(txtDesiredTip.Text, out int desiredTip)) {
                    // For each item in the checkboxes list...
                    for (int index = 0; index < checkboxes.Count; index++) {
                        // The user cannot input the desired tip and use either the checkboxes or the customboxes
                        if (desiredTip > 0 && (checkboxes[index] == true || customboxes[index] != "")) {
                            MessageBox.Show("Choose the desired tip or customize your tip with the checkboxes.");
                            btnClear.PerformClick(); // Clicks the clear button
                            goto done; // To break out of an if statement
                        } 
                    }  
                    // Add the desired tip to percent
                    percent += desiredTip;
                } else {
                    // For the list with 5 entries...
                    for (int index = 0; index < checkboxes.Count; index++) {
                        // Extract the values of the custom textboxes and store as customPercent
                        int.TryParse(customboxes[index], out int customPercent);
                        // if TryParse stored a value in customPercent, add the customPercent to percent, and store the index as true in the list
                        if (customPercent > 0) {
                            percent += customPercent;
                            checkboxes[index] = true;       
                        // if only a checkbox is checked, add 5 to percent
                        } else if (checkboxes[index] == true){
                            percent += 5;
                        }
                    }
                } 
                // Displays percent in the TipPercent output label
                lblOutputTipPercent.Text = percent + "%";
                // Calculates tipAmount and displays the tipAmount in the output label
                tipAmount = mealCost * ((double)percent / 100);
                lblOutputTipAmount.Text = tipAmount.ToString("c");
                // Calcuates totalAmount and displays the totalAmount in the output label
                totalAmount = mealCost + tipAmount;
                lblOutputTotalAmount.Text = totalAmount.ToString("c");
            } else {
                // Displays an error message
                MessageBox.Show("Enter a number for the meal cost.");
            }
            done:;
        } 
           
            private void btnClear_Click(object sender, EventArgs e) {
            //Clears the textboxes
            txtMealCost.Text = "";
            txtDesiredTip.Text = "";
            txtSeatedQuicklyCustom.Text = "";
            txtDrinksFullCustom.Text = "";
            txtFriendlyCustom.Text = "";
            txtFoodPromptlyCustom.Text = "";
            txtComplaintsHandledCustom.Text = "";

            // Clears the checkboxes
            chkSeatedQuickly.Checked = false;
            chkDrinksFull.Checked = false;
            chkFriendly.Checked = false;
            chkFoodPromptly.Checked = false;
            chkComplaintsHandled.Checked = false;

            // Clears the labels
            lblOutputTipPercent.Text = "";
            lblOutputTipAmount.Text = "";
            lblOutputTotalAmount.Text = "";

            // Put a focus in txtMealCost
            txtMealCost.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            // Closes the form
            this.Close();
        }
    }
}
