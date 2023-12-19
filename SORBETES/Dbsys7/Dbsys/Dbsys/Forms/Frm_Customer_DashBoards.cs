using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;



namespace Dbsys.Forms
{
    public partial class Frm_Customer_DashBoards : Form
    {

        const double price_chocolate = 25;
        const double price_strawberry = 30;
        const double price_berry = 40;
        const double price_melon = 25;
        const double price_vanilla = 25;
        const double price_cherry = 30;
        const double price_creamy = 40;
        const double price_matcha = 20;

        public Frm_Customer_DashBoards()
        {
            InitializeComponent();
            this.FormClosing += Frm_Customer_DashBoards_FormClosing;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Customer_DashBoard_Load(object sender, EventArgs e)
        {
            cmbMOP.Items.Add("");
            cmbMOP.Items.Add("Cash");
            cmbMOP.Items.Add("Cash on Delivery");
            cmbMOP.Items.Add("ONLINE PAYMENT");
            TextBox();

            cmbOnlinePaymentMethod.Items.Add("Bank Account");
            cmbOnlinePaymentMethod.Items.Add("GCash");
            cmbOnlinePaymentMethod.Items.Add("PayMaya");
            cmbOnlinePaymentMethod.Enabled = false; // Initially disable online payment method dropdown

            tbFName.Enabled = false;
            tbNumber.Enabled = false;
            tbEAmount.Enabled = false;
            tbTNumber.Enabled = false;
            tbNotes.Enabled = false;

            // Hide online payment controls
            cmbOnlinePaymentMethod.Enabled = false;


        }


        private void TextBox()
        {
            
            Action<Control.ControlCollection> resetTextBoxes = null;

            resetTextBoxes = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox textBox && textBox.Name != "tbStaff" && textBox.Name != "tbNotes" && textBox.Name != "tbFName" && textBox.Name != "tbTNumber")
                    {
                        textBox.Text = "  0";
                    }
                    else
                    {
                        resetTextBoxes(control.Controls);
                    }
                }
            };

            resetTextBoxes(Controls);

        }





        private void cbChocolateCream_CheckedChanged(object sender, EventArgs e)
        {

            if (cbChoco.Checked == true)
            {
                cbChocolate.Enabled = true;
                cbChocolate.Text = "  ";
                cbChocolate.Focus();
            }
            else
            {
                cbChocolate.Enabled = false;
                cbChocolate.Text = "  0";

            }

        }

        private void cbStrawberryMilk_CheckedChanged(object sender, EventArgs e)
        {

            if (cbStrawberryM.Checked == true)
            {
                cbStrawberry.Enabled = true;
                cbStrawberry.Text = "  ";
                cbStrawberry.Focus();
            }
            else
            {
                cbStrawberry.Enabled = false;
                cbStrawberry.Text = "  0";
            }
        }

        private void cbBerry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBerry.Checked == true)
            {
                tbBerry.Enabled = true;
                tbBerry.Text = "  ";
                tbBerry.Focus();
            }
            else
            {
                tbBerry.Enabled = false;
                tbBerry.Text = "  0";
            }
        }

        private void cbMelon_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMelon.Checked == true)
            {
                tbMelon.Enabled = true;
                tbMelon.Text = "  ";
                tbMelon.Focus();
            }
            else
            {
                tbMelon.Enabled = false;
                tbMelon.Text = "  0";
            }
        }

        private void cbVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVanilla.Checked == true)
            {
                tbVanilla.Enabled = true;
                tbVanilla.Text = "  ";
                tbVanilla.Focus();
            }
            else
            {
                tbVanilla.Enabled = false;
                tbVanilla.Text = "  0";
            }
        }

        private void cbCherry_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCherry.Checked == true)
            {
                tbCherry.Enabled = true;
                tbCherry.Text = "  ";
                tbCherry.Focus();
            }
            else
            {
                tbCherry.Enabled = false;
                tbCherry.Text = "  0";
            }
        }

        private void cbCreamy_CheckedChanged(object sender, EventArgs e)
        {

            if (cbCreamy.Checked == true)
            {
                tbCreamy.Enabled = true;
                tbCreamy.Text = "  ";
                tbCreamy.Focus();
            }
            else
            {
                tbCreamy.Enabled = false;
                tbCreamy.Text = "  0";
            }
        }

        private void cbMacha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMacha.Checked == true)
            {
                tbMacha.Enabled = true;
                tbMacha.Text = "  ";
                tbMacha.Focus();
            }
            else
            {
                tbMacha.Enabled = false;
                tbMacha.Text = " 0";
            }
        }

        private void cmbMOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbEAmount.Enabled = false;
            tbTNumber.Enabled = false;
            tbNotes.Enabled = false;
            cmbOnlinePaymentMethod.Enabled = false;
            tbFName.Enabled = false;
            tbNumber.Enabled = false;


            if (cmbMOP.Text == "Cash")
            {
                tbStaff.Focus();
                tbEAmount.Enabled = true;
                tbEAmount.Text = "";
             

                tbTNumber.Enabled = true;
                tbTNumber.Text = "";
             
                tbNotes.Enabled = true;
                tbNotes.Text = "";
                
            }
            else if (cmbMOP.Text == "Cash on Delivery")
            {
                tbStaff.Focus();
                tbTNumber.Enabled = true;
                tbNotes.Enabled = true;
                tbTNumber.Text = "";
                tbNotes.Text = "";     
               

                tbEAmount.Enabled = true;
                tbEAmount.Text = "";
              
            }
            else if (cmbMOP.Text == "ONLINE PAYMENT")
            {
                cmbOnlinePaymentMethod.Enabled = true;
                tbFName.Enabled = true;
                tbNumber.Enabled = true;

                tbStaff.Focus();
                tbTNumber.Enabled = true;
                tbNotes.Enabled = true;
                tbTNumber.Text = "";
                tbNotes.Text = "";

                tbEAmount.Enabled = true;
                tbEAmount.Text = "";
              
            }



        }

        private void tbTpayment_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

            double[] cost = new double[100];
            cost[0] = Convert.ToDouble(cbChocolate.Text) * price_chocolate;
            cost[2] = Convert.ToDouble(cbStrawberry.Text) * price_strawberry;
            cost[3] = Convert.ToDouble(tbBerry.Text) * price_berry;
            cost[4] = Convert.ToDouble(tbMelon.Text) * price_melon;
            cost[5] = Convert.ToDouble(tbVanilla.Text) * price_vanilla;
            cost[6] = Convert.ToDouble(tbCherry.Text) * price_cherry;
            cost[7] = Convert.ToDouble(tbCreamy.Text) * price_creamy;
            cost[8] = Convert.ToDouble(tbMacha.Text) * price_matcha;

            double total, payment, price;

            if (cmbMOP.Text == "Cash" || cmbMOP.Text == "Cash on Delivery" || cmbMOP.Text == "ONLINE PAYMENT")
            {
                total = cost[0] + cost[2] + cost[3] + cost[4] + cost[5] + cost[6] + cost[7] + cost[8];
                lblTotal.Text = Convert.ToString(total);

                if (double.TryParse(tbEAmount.Text, out payment))
                {
                    price = payment - total;
                    lblChange.Text = Convert.ToString(price);
                }
                else
                {
                    lblChange.Text = "Invalid Input";
                }
            }
            else
            {
                total = cost[0] + cost[2] + cost[3] + cost[4] + cost[5] + cost[6] + cost[7] + cost[8];
                lblTotal.Text = Convert.ToString(total);

            }





        }
        private void RestText()
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void RestCheckBox()
        {
        }
        private void label8_Click_1(object sender, EventArgs e)
        {

        }
        private void PrintReceipt(string receiptText)
        {
            PrintDocument printDocument = new PrintDocument();
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.PrintPage += (s, ev) =>
                {

                    Font font = new Font("Courier New", 16);
                    Brush brush = Brushes.Black;

                   //formula
                    int printableWidth = ev.PageBounds.Width;
                    int printableHeight = ev.PageBounds.Height;

                    // Calculate the height of the text
                    float textHeight = ev.Graphics.MeasureString(receiptText, font, printableWidth).Height;

                    // Calculate the position to center the text vertically
                    float yPos = (printableHeight - textHeight) / 10;

                    // Calculate the position to center the text horizontally
                    float xPos = (printableWidth - ev.Graphics.MeasureString(receiptText, font).Width) / 2;

                    // Print receipt content with proper width and height
                    ev.Graphics.DrawString(receiptText, font, brush, xPos, yPos, new StringFormat
                    {
                        FormatFlags = StringFormatFlags.LineLimit,
                        Trimming = StringTrimming.EllipsisWord
                    });
                };

                printDocument.Print();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTNumber.Text))
            {
                MessageBox.Show("Please enter the customer name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbTNumber.Focus();
                return;
            }

            if (tbEAmount.Text.Trim() == "0")
            {
                MessageBox.Show("Please enter the payment amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEAmount.Focus();
                return;
            }

            MessageBox.Show("Payment confirmed! You can view your receipt.", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GenerateReceiptText()
        {
            double[] cost = new double[100];
            cost[0] = Convert.ToDouble(cbChocolate.Text) * price_chocolate;
            cost[2] = Convert.ToDouble(cbStrawberry.Text) * price_strawberry;
            cost[3] = Convert.ToDouble(tbBerry.Text) * price_berry;
            cost[4] = Convert.ToDouble(tbMelon.Text) * price_melon;
            cost[5] = Convert.ToDouble(tbVanilla.Text) * price_vanilla;
            cost[6] = Convert.ToDouble(tbCherry.Text) * price_cherry;
            cost[7] = Convert.ToDouble(tbCreamy.Text) * price_creamy;
            cost[8] = Convert.ToDouble(tbMacha.Text) * price_matcha;

            double total, payment, change;

            if (cmbMOP.Text == "Cash" || cmbMOP.Text == "Cash on Delivery" || cmbMOP.Text == "ONLINE PAYMENT")
            {
                total = cost[0] + cost[2] + cost[3] + cost[4] + cost[5] + cost[6] + cost[7] + cost[8];

                // Handle conversion errors using double.TryParse
                if (double.TryParse(tbEAmount.Text, out payment))
                {
                    change = payment - total;
                }
                else
                {
                    change = 0; // Invalid input, set change to 0
                }
            }
            else
            {
                total = cost[0] + cost[2] + cost[3] + cost[4] + cost[5] + cost[6] + cost[7] + cost[8];
                payment = 0; 
                change = 0; 
            }

            StringBuilder receiptText = new StringBuilder();
            receiptText.AppendLine("\t\t\tSORBETES SHOP");
            receiptText.AppendLine("=======================================================");
            receiptText.AppendLine($"Customer Name: {tbFName.Text}");
            receiptText.AppendLine($"Contact Number: {tbNumber.Text}");
            receiptText.AppendLine($"Payment Method: {cmbMOP.Text}");

            if (cmbMOP.Text == "Cash on Delivery")
            {
                receiptText.AppendLine($"Cash on Delivery Name: {tbTNumber.Text}");
                receiptText.AppendLine($"Tracking Number: {tbNotes.Text}");
            }
            receiptText.AppendLine("=======================================================");
            receiptText.AppendLine($"Total: ₱{total:N2}");  // Use N2 to format as currency
            receiptText.AppendLine($"Payment: ₱{payment:N2}");
            receiptText.AppendLine($"Change: ₱{change:N2}");


            return receiptText.ToString();
        }

        private string GenerateItemizedList()
        {
            StringBuilder itemList = new StringBuilder();
            itemList.AppendLine("********************* ITEM SOLD LIST ******************");
            itemList.AppendLine($"Chocolate Cream: {cbChocolate.Text} x ₱{price_chocolate:N2}");  // Use N2 to format as currency
            itemList.AppendLine($"Strawberry Milk: {cbStrawberry.Text} x ₱{price_strawberry:N2}");
            itemList.AppendLine($"Berry Flavor: {tbBerry.Text} x ₱{price_berry:N2}");
            itemList.AppendLine($"Melon Flavor: {tbMelon.Text} x ₱{price_melon:N2}");
            itemList.AppendLine($"Vanilla Flavor: {tbVanilla.Text} x ₱{price_vanilla:N2}");
            itemList.AppendLine($"Cherry Flavor: {tbCherry.Text} x ₱{price_cherry:N2}");
            itemList.AppendLine($"Creamy Flavor: {tbCreamy.Text} x ₱{price_creamy:N2}");
            itemList.AppendLine($"Matcha Flavor: {tbMacha.Text} x ₱{price_matcha:N2}");
            itemList.AppendLine("*******************************************************");
            itemList.AppendLine("        THANK YOU FOR CHOOSING SORBETES             ");

            return itemList.ToString();
        }


        private void tbEAmount_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        private void PrintReceipt()
        {

        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void chocop_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue();
        }

        private void chocom_Click(object sender, EventArgs e)
        {
                DecrementTextBoxValue();
        }
        private void IncrementTextBoxValue()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(cbChocolate.Text, out int currentValue))
            {
                // Increment the value by 1
                cbChocolate.Text = (currentValue + 1).ToString();
           
            }
            else
            {
                // Handle invalid input (non-integer)
                cbChocolate.Text = "1";
           
            }
           
        }
        //***********************************INCREMENT**************************************
        private void IncrementTextBoxValue1()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(cbStrawberry.Text, out int currentValue))
            {
                // Increment the value by 1
                
                cbStrawberry.Text = (currentValue + 1).ToString();

            }
            else
            {
                // Handle invalid input (non-integer)

                cbStrawberry.Text = "1";


            }
        }
        private void IncrementTextBoxValue2()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(tbBerry.Text, out int currentValue))
            {
                // Increment the value by 1

                tbBerry.Text = (currentValue + 1).ToString();

            }
            else
            {
                // Handle invalid input (non-integer)

                tbBerry.Text = "1";


            }
        }

        private void IncrementTextBoxValue3()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(tbMelon.Text, out int currentValue))
            {
                // Increment the value by 1

                tbMelon.Text = (currentValue + 1).ToString();

            }
            else
            {
                // Handle invalid input (non-integer)

                tbMelon.Text = "1";


            }
            }
        private void IncrementTextBoxValue4()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(tbVanilla.Text, out int currentValue))
            {
                // Increment the value by 1

                tbVanilla.Text = (currentValue + 1).ToString();

            }
            else
            {
                // Handle invalid input (non-integer)

                tbVanilla.Text = "1";


            }
        }
        private void IncrementTextBoxValue5()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(tbCherry.Text, out int currentValue))
            {
                // Increment the value by 1

                tbCherry.Text = (currentValue + 1).ToString();
               

            }
            else
            {
                // Handle invalid input (non-integer)

                tbCherry.Text = "1";
               

            }
            }
        private void IncrementTextBoxValue6()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(tbCreamy.Text, out int currentValue))
            {
                // Increment the value by 1

                tbCreamy.Text = (currentValue + 1).ToString();
                


            }
            else
            {
                // Handle invalid input (non-integer)

                tbCreamy.Text = "1";
                

            }
            }
        private void IncrementTextBoxValue7()
        {
            // Parse the current value in the textbox and increment by 1
            if (int.TryParse(tbMacha.Text, out int currentValue))
            {
                // Increment the value by 1

                tbMacha.Text = (currentValue + 1).ToString();

            }
            else
            {
                // Handle invalid input (non-integer)

                tbMacha.Text = "1";

            }
            }
            //*************DECREMENT**********************************************************************************************
            private void DecrementTextBoxValue()
        {
            if (!cbChocolate.ReadOnly)
            {
                if (int.TryParse(cbChocolate.Text, out int currentValue))
                {
                    // Ensure the value doesn't go below 0
                    int newValue = Math.Max(0, currentValue - 1);

                    // Update the textbox with the decremented value
                    cbChocolate.Text = newValue.ToString();




                }
                else
                {
                    // Handle invalid input (non-integer)
                    cbChocolate.Text = "0";

                }
                cbChocolate.ReadOnly = false;
            }
        }
        private void MakeTextBox1ReadOnly()
        {
            cbChocolate.ReadOnly = true;
        }

        private void DecrementTextBoxValue1()
        {
          
            // Parse the current value in the textbox and decrement by 1
            if (int.TryParse(cbStrawberry.Text, out int currentValue))
            {
                // Ensure the value doesn't go below 0
                int newValue = Math.Max(0, currentValue - 1);

                // Update the textbox with the decremented value
          
                cbStrawberry.Text = newValue.ToString();
            }
            else
            {

                cbStrawberry.Text = "0";            
            }
        }
        private void DecrementTextBoxValue2()
        {
            // Parse the current value in the textbox and decrement by 1
            if (int.TryParse(tbBerry.Text, out int currentValue))
            {
                // Ensure the value doesn't go below 0
                int newValue = Math.Max(0, currentValue - 1);

                // Update the textbox with the decremented value

                tbBerry.Text = newValue.ToString();
            }
            else
            {

                tbBerry.Text = "0";
            }
        }
        private void DecrementTextBoxValue3()
        {
            // Parse the current value in the textbox and decrement by 1
            if (int.TryParse(tbMelon.Text, out int currentValue))
            {
                // Ensure the value doesn't go below 0
                int newValue = Math.Max(0, currentValue - 1);

                // Update the textbox with the decremented value

                tbMelon.Text = newValue.ToString();
            }
            else
            {

                tbMelon.Text = "0";
            }
        }
        private void DecrementTextBoxValue4()
        {
            // Parse the current value in the textbox and decrement by 1
            if (int.TryParse(tbVanilla.Text, out int currentValue))
            {
                // Ensure the value doesn't go below 0
                int newValue = Math.Max(0, currentValue - 1);

                // Update the textbox with the decremented value

                tbVanilla.Text = newValue.ToString();
            }
            else
            {

                tbVanilla.Text = "0";
            }
        }
        private void DecrementTextBoxValue5()
        {
            // Parse the current value in the textbox and decrement by 1
            if (int.TryParse(tbCherry.Text, out int currentValue))
            {
                // Ensure the value doesn't go below 0
                int newValue = Math.Max(0, currentValue - 1);

                // Update the textbox with the decremented value

                tbCherry.Text = newValue.ToString();
            }
            else
            {

                tbCherry.Text = "0";
            }
        }
        private void DecrementTextBoxValue6()
        {
            // Parse the current value in the textbox and decrement by 1
            if (int.TryParse(tbCreamy.Text, out int currentValue))
            {
                // Ensure the value doesn't go below 0
                int newValue = Math.Max(0, currentValue - 1);

                // Update the textbox with the decremented value

                tbCreamy.Text = newValue.ToString();
            }
            else
            {

                tbCreamy.Text = "0";
            }
        }
        private void DecrementTextBoxValue7()
        {
            // Parse the current value in the textbox and decrement by 1
            if (int.TryParse(tbMacha.Text, out int currentValue))
            {
                // Ensure the value doesn't go below 0
                int newValue = Math.Max(0, currentValue - 1);

                // Update the textbox with the decremented value

                tbMacha.Text = newValue.ToString();
            }
            else
            {

                tbMacha.Text = "0";
            }
        }
        //--------------------------------------------------------------------------------------------------------
        private void button8_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue1();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue2();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue3();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue4();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue5();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue6();
        }

      
        private void button7_Click(object sender, EventArgs e)
        {
            DecrementTextBoxValue1();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DecrementTextBoxValue2();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DecrementTextBoxValue3();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DecrementTextBoxValue4();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DecrementTextBoxValue5();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            DecrementTextBoxValue6();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DecrementTextBoxValue7();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            IncrementTextBoxValue7();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Generate and display the receipt
            string itemizedList = GenerateItemizedList();
            string receiptText = GenerateReceiptText();


            // Add Cash on Delivery details to receipt text
            if (cmbMOP.Text == "Cash on Delivery")
            {
                receiptText += $"\nCash on Delivery Name: {tbTNumber.Text}";
                receiptText += $"\nTracking Number: {tbNotes.Text}";
            }

            // Combine receipt text and itemized list
            string formattedReceipt = $"\n\n*******************OFFICIAL RECEIPT********************\n\n{receiptText}\n\n{itemizedList}\n\n********************************************************";

            // Print the receipt
            PrintReceipt(formattedReceipt);
        }

        private void ResetForm()
        {
            // Reset TextBoxes
            TextBox();
            tbFName.Clear();
            tbNumber.Clear();
            tbTNumber.Clear();
            tbNotes.Clear();
            tbEAmount.Clear();
            cmbMOP.SelectedIndex = 0;
            cmbOnlinePaymentMethod.SelectedIndex = -1;

            // Uncheck checkboxes and disable related TextBoxes
            cbChoco.Checked = false;
            cbStrawberryM.Checked = false;
            cbBerry.Checked = false;
            cbMelon.Checked = false;
            cbVanilla.Checked = false;
            cbCherry.Checked = false;
            cbCreamy.Checked = false;
            cbMacha.Checked = false;

            cbChocolate.Enabled = false;
            cbStrawberry.Enabled = false;
            tbBerry.Enabled = false;
            tbMelon.Enabled = false;
            tbVanilla.Enabled = false;
            tbCherry.Enabled = false;
            tbCreamy.Enabled = false;
            tbMacha.Enabled = false;

            // Reset labels
            lblTotal.Text = "0.00";
            lblChange.Text = "0.00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_Customer_DashBoards_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the user really wants to close the application
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user clicks No, cancel the form closing
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Frm_Menu().Show();
            this.Hide();
        }
    }
}
    
    

    

