using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Miss_yusra_Project__OOP__
{
    public partial class Form1 : Form
    {
        int add_drinks, add_cakes;
        int[] amount_cakes = new int[] {5,5,5,5,5,5,5,5};
        int[] amount_coffees = new int[] {2,2,2,2,2,2,2,2 };
        double z = 0.07;
        string customerName;
        string customerAddress;
        string customerPhone;
        bool home,  promoCodeApplied;
        int[] arr = new int[8];
        int[] arr2 = new int[8];
        string[] drinks = new string[] { "GREEN TEA", "BLACK COFFEE", "WHITE TEA", "IRISH COFFEE", "PUE'R TEA", "TURKISH TEA", "HIBISCOUS COFFEE", "COFFEE ARABICA", };
        string[] cake = new string[] { "LAVA CAKE", " KITKAT CAKE", "POUND CAKE", "RED VELVET CAKE", "SPONGE CAKE", "GENOISE CAKE ", "CHIFFON CAKE", "FUNFUTTI CAKE" };

        double discountAmount, discountedTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
           
            // Example usage in a Panel control
            //panel6.BackgroundImage = new Bitmap(@"C:\Users\Hammad Usmani\Pictures\Saved Pictures\559e9cc9a1112886a243013a3faa5196.jpg");
            //panel6.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
       

        //These are cakes textboxes{
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
           
        }
   

        //These are drinks Textboxes {
        private void textBox3_TextChanged(object sender, EventArgs e)
        { 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
           
        }
       
       //}

        //These are calculation Textboxes {
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        //}
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        
            

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }


        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
            add_cakes += arr[0] * amount_cakes[0];
            add_cakes += arr[1] * amount_cakes[1];
            add_cakes += arr[2] * amount_cakes[2];
            add_cakes += arr[3] * amount_cakes[3];
            add_cakes += arr[4] * amount_cakes[4];
            add_cakes += arr[5] * amount_cakes[5];
            add_cakes += arr[6] * amount_cakes[6];
            add_cakes += arr[7] * amount_cakes[7];

            add_drinks += arr2[0] * amount_coffees[0];
            add_drinks += arr2[1] * amount_coffees[1];
            add_drinks += arr2[2] * amount_coffees[2];
            add_drinks += arr2[3] * amount_coffees[3];
            add_drinks += arr2[4] * amount_coffees[4];
            add_drinks += arr2[5] * amount_coffees[5];
            add_drinks += arr2[6] * amount_coffees[6];
            add_drinks += arr2[7] * amount_coffees[7];

            textBox5.Text = Convert.ToString("$" + add_drinks);
            textBox6.Text = Convert.ToString("$" + add_cakes);
            textBox7.Text = "$1.07";
            textBox8.Text = Convert.ToString("$" + z);
            if (promoCodeApplied)
            {
                // Apply 10% discount
                 discountAmount = (add_cakes + add_drinks) * 0.1;
                 discountedTotal = (add_cakes + add_drinks) - discountAmount;
                textBox9.Text = Convert.ToString("$" + discountedTotal);
                textBox10.Text = Convert.ToString("$" + (discountedTotal + z + 1.07));
            }
            else
            {
                textBox9.Text = Convert.ToString("$" + (add_cakes + add_drinks));
                textBox10.Text = Convert.ToString("$" + (z + add_cakes + add_drinks+1.07));
            }

            button1.Enabled = false;


        }
        private void UpdateSelectedItemsListBox()
        {
            // Clear the ListBox first
            ORDER.Items.Clear();
            ORDER.Items.Add("ITEMS\t\t\t\tQTY");
            
            // Iterate over the cake checkboxes and add selected items to the ListBox
            if (checkBox1.Checked)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (int.TryParse(textBox1.Text, out int value))
                    {
                        arr[0] = value;
                    }
                }
                ORDER.Items.Add("LAVA CAKE\t\t\t" + arr[0]);
            }
            if (checkBox2.Checked)
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    if (int.TryParse(textBox2.Text, out int value))
                    {
                        arr[1] = value;
                    }
                }
                ORDER.Items.Add("KITKAT CAKE\t\t\t" + arr[1]);
            }
            if (checkBox5.Checked)
            {
                if (!string.IsNullOrEmpty(textBox11.Text))
                {
                    if (int.TryParse(textBox11.Text, out int value))
                    {
                        arr[2] = value;
                    }
                }
                ORDER.Items.Add("POUND CAKE\t\t\t" + arr[2]);
            }
            if (checkBox6.Checked)
            {
                if (!string.IsNullOrEmpty(textBox12.Text))
                {
                    if (int.TryParse(textBox12.Text, out int value))
                    {
                        arr[3] = value;
                    }
                }
                ORDER.Items.Add("RED VELVET CAKE\t\t" + arr[3]);
            }
            if (checkBox7.Checked)
            {
                if (!string.IsNullOrEmpty(textBox13.Text))
                {
                    if (int.TryParse(textBox13.Text, out int value))
                    {
                        arr[4] = value;
                    }
                }
                ORDER.Items.Add("SPONGE CAKE\t\t\t" + arr[4]);
            }
            if (checkBox8.Checked)
            {
                if (!string.IsNullOrEmpty(textBox14.Text))
                {
                    if (int.TryParse(textBox14.Text, out int value))
                    {
                        arr[5] = value;
                    }
                }
                ORDER.Items.Add("GENOISE CAKE\t\t\t" + arr[5]);
            }
            if (checkBox9.Checked)
            {
                if (!string.IsNullOrEmpty(textBox15.Text))
                {
                    if (int.TryParse(textBox15.Text, out int value))
                    {
                        arr[6] = value;
                    }
                }
                ORDER.Items.Add("CHIFFON CAKE\t\t\t" + arr[6]);
            }
                if (checkBox10.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox16.Text))
                    {
                        if (int.TryParse(textBox16.Text, out int value))
                        {
                            arr[7] = value;
                        }
                    }
                    ORDER.Items.Add("FUNFUTTI CAKE\t\t\t" + arr[7]);
                }
            // Add more if conditions for other cake checkboxes...
                // Iterate over the drink checkboxes and add selected items to the ListBox
                if (checkBox3.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox3.Text))
                    {
                        if (int.TryParse(textBox3.Text, out int value))
                        {
                            arr2[0] = value;
                        }
                    }
                    ORDER.Items.Add("GREEN TEA\t\t\t" + arr2[0]);
                }
                if (checkBox4.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox4.Text))
                    {
                        if (int.TryParse(textBox4.Text, out int value))
                        {
                            arr2[1] = value;
                        }
                    }
                    ORDER.Items.Add("BLACK COFFEE\t\t\t" + arr2[1]);
                }
                if (checkBox11.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox17.Text))
                    {
                        if (int.TryParse(textBox17.Text, out int value))
                        {
                            arr2[2] = value;
                        }
                    }
                    ORDER.Items.Add("WHITE TEA\t\t\t" + arr2[2]);
                }
                if (checkBox12.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox18.Text))
                    {
                        if (int.TryParse(textBox18.Text, out int value))
                        {
                            arr2[3] = value;
                        }
                    }
                    ORDER.Items.Add("IRISH COFFEE\t\t\t" + arr2[3]);
                }
                if (checkBox13.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox19.Text))
                    {
                        if (int.TryParse(textBox19.Text, out int value))
                        {
                            arr2[4] = value;
                        }
                    }
                    ORDER.Items.Add("PUE'R TEA\t\t\t" + arr2[4]);
                }
                if (checkBox14.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox20.Text))
                    {
                        if (int.TryParse(textBox20.Text, out int value))
                        {
                            arr2[5] = value;
                        }
                    }
                    ORDER.Items.Add("TURKISH TEA\t\t\t" + arr2[5]);
                }
                if (checkBox15.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox21.Text))
                    {
                        if (int.TryParse(textBox21.Text, out int value))
                        {
                            arr2[6] = value;
                        }
                    }
                    ORDER.Items.Add("HIBISCOUS COFFEE\t\t" + arr2[6]);
                }
                if (checkBox16.Checked)
                {
                    if (!string.IsNullOrEmpty(textBox22.Text))
                    {
                        if (int.TryParse(textBox22.Text, out int value))
                        {
                            arr2[7] = value;
                        }
                    }
                    ORDER.Items.Add("COFFEE ARABICA\t\t\t" + arr2[7]);
                }
                

                // Optional: Scroll to the bottom of the ListBox to show the latest items
                ORDER.TopIndex = ORDER.Items.Count - 1;
            
        }
        string receipt;
        public void GenerateReceipt()
        {
            
          
            StringBuilder receiptBuilder = new StringBuilder();
            receiptBuilder.AppendLine("----- Receipt -----");
            receiptBuilder.AppendLine("ITEMS    QTY      PRICE");

            // Get the quantities from the text boxes
            int[] cakeQuantities = new int[]
            {
        int.TryParse(textBox1.Text, out int cake1Quantity) ? cake1Quantity : 0,
        int.TryParse(textBox2.Text, out int cake2Quantity) ? cake2Quantity : 0,
        int.TryParse(textBox11.Text, out int cake3Quantity) ? cake3Quantity : 0,
        int.TryParse(textBox12.Text, out int cake4Quantity) ? cake4Quantity : 0,
        int.TryParse(textBox13.Text, out int cake5Quantity) ? cake5Quantity : 0,
        int.TryParse(textBox14.Text, out int cake6Quantity) ? cake6Quantity : 0,
        int.TryParse(textBox15.Text, out int cake7Quantity) ? cake7Quantity : 0,
        int.TryParse(textBox16.Text, out int cake8Quantity) ? cake8Quantity : 0,
                
            };

            int[] drinkQuantities = new int[]
            {
        int.TryParse(textBox3.Text, out int drink1Quantity) ? drink1Quantity : 0,
        int.TryParse(textBox4.Text, out int drink2Quantity) ? drink2Quantity : 0,
        int.TryParse(textBox17.Text, out int drink3Quantity) ? drink3Quantity : 0,
        int.TryParse(textBox18.Text, out int drink4Quantity) ? drink4Quantity : 0,
        int.TryParse(textBox19.Text, out int drink5Quantity) ? drink5Quantity : 0,
        int.TryParse(textBox20.Text, out int drink6Quantity) ? drink6Quantity : 0,
        int.TryParse(textBox21.Text, out int drink7Quantity) ? drink7Quantity : 0,
        int.TryParse(textBox22.Text, out int drink8Quantity) ? drink8Quantity : 0,
                // Add the remaining drink quantities here
            };

            // Calculate the total price for each item
            decimal[] cakePrices = new decimal[amount_cakes.Length];
            decimal[] drinkPrices = new decimal[amount_coffees.Length];

            for (int i = 0; i < amount_cakes.Length; i++)
            {
                if (i < cakeQuantities.Length)
                {
                    cakePrices[i] = cakeQuantities[i] * amount_cakes[i];
                }
            }

            for (int i = 0; i < amount_coffees.Length; i++)
            {
                if (i < drinkQuantities.Length)
                {
                    drinkPrices[i] = drinkQuantities[i] * amount_coffees[i];
                }
            }

            decimal totalCakesPrice = cakePrices.Sum();
            decimal totalDrinksPrice = drinkPrices.Sum();
            decimal tax = totalCakesPrice * 0.07m + totalDrinksPrice * 0.07m;
            decimal totalPrice = totalCakesPrice + totalDrinksPrice + tax;
            decimal discount = promoCodeApplied ? totalPrice * 0.1m : 0m;
            decimal discountedTotal = totalPrice - discount;

            // Generate the receipt text
            receiptBuilder.AppendLine("Cakes:");
            for (int i = 0; i < amount_cakes.Length; i++)
            {
                if (i < cakeQuantities.Length && cakeQuantities[i] > 0)
                {
                    receiptBuilder.AppendLine($"- {cake[i]}: {cakeQuantities[i]} x ${amount_cakes[i]} = ${cakePrices[i]}");
                }
            }

            receiptBuilder.AppendLine("Drinks:");
            for (int i = 0; i < amount_coffees.Length; i++)
            {
                if (i < drinkQuantities.Length && drinkQuantities[i] > 0)
                {
                    receiptBuilder.AppendLine($"- {drinks[i]}: {drinkQuantities[i]} x ${amount_coffees[i]} = ${drinkPrices[i]}");
                }
            }
            receiptBuilder.AppendLine("------------------------------");
            receiptBuilder.AppendLine($"Subtotal: ${totalCakesPrice + totalDrinksPrice}");
            receiptBuilder.AppendLine($"Tax (7%): ${tax}");
            receiptBuilder.AppendLine($"Total: ${totalPrice}");
            receiptBuilder.AppendLine("------------------------------");
            if (promoCodeApplied)
            {
                receiptBuilder.AppendLine($"Discount (10%): ${discount}");
                receiptBuilder.AppendLine($"Discounted Total: ${discountedTotal}");
                receiptBuilder.AppendLine("------------------------------");

            }
            if (home)
            {
                receiptBuilder.AppendLine("Customer Details:");
                receiptBuilder.AppendLine($"Name: {customerName}");
                receiptBuilder.AppendLine($"Address: {customerAddress}");
                receiptBuilder.AppendLine($"Phone: {customerPhone}");
                receiptBuilder.AppendLine("------------------------------");

            }
            receipt = receiptBuilder.ToString();

            // Show the receipt in a message box or any other way you prefer
            MessageBox.Show(receipt, "Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void SaveReceiptToFile(string receipt)
        {
            // Prompt the user to choose a file location to save the receipt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.FileName = "receipt.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = saveFileDialog.FileName;

                try
                {
                    // Save the receipt to the selected file
                    File.WriteAllText(filePath, receipt);
                    MessageBox.Show("Receipt saved successfully.", "Receipt Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateReceipt();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        SaveReceiptToFile(receipt);

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            add_cakes = 0;
            add_drinks = 0;
            ORDER.Items.Clear();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = 0;
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ORDER_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        public void reset()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox5.Text = "$0";
            textBox6.Text = "$0";
            textBox7.Text = "$0";
            textBox8.Text = "$0";
            textBox9.Text = "$0";
            textBox10.Text = "$0";

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;



            textBox23.Text="";
            textBox24.Text = "";
            textBox25.Text = "";
            home = false;
            button1.Enabled = true;

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            btnHomeDelivery_Click(sender, e);   
        }

        public void check()
        {
            if (checkBox1.Checked == false)
            {
                arr[0] = 0;
            }else if(checkBox2.Checked == false) 
            {
                arr[1] = 0;
            } if (checkBox3.Checked == false)
            {
                arr2[0] = 0;
            }else if(checkBox4.Checked == false) 
            {
                arr2[1] = 0;
            } if (checkBox5.Checked == false)
            {
                arr[2] = 0;
            }else if(checkBox6.Checked == false) 
            {
                arr[3] = 0;
            } if (checkBox7.Checked == false)
            {
                arr[4] = 0;
            }else if(checkBox8.Checked == false) 
            {
                arr[5] = 0;
            } if (checkBox9.Checked == false)
            {
                arr[6] = 0;
            }else if(checkBox10.Checked == false) 
            {
                arr[7] = 0;
            } if (checkBox11.Checked == false)
            {
                arr2[2] = 0;
            }else if(checkBox12.Checked == false) 
            {
                arr2[3] = 0;
            }if (checkBox13.Checked == false)
            {
                arr2[4] = 0;
            }else if(checkBox14.Checked == false) 
            {
                arr2[5] = 0;
            }if (checkBox15.Checked == false)
            {
                arr2[6] = 0;
            }else if(checkBox16.Checked == false) 
            {
                arr2[7] = 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            btnPromoCode_Click();
        }

        private void btnHomeDelivery_Click(object sender, EventArgs e)
        {
            // Get the customer details
             customerName = textBox23.Text;
             customerAddress = textBox24.Text;
             customerPhone = textBox25.Text;
             home = true;

            // Generate the receipt
            GenerateReceipt();

            // Create a new file to store the receipt
            string filePath = "Receipt.txt";
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the receipt contents to the file
                writer.WriteLine(receipt);
            }

            // Display a message to the user
            MessageBox.Show("Thank you for your order!\n\nYour order has been placed and will be delivered to the following address:\n\n" +
                "Name: " + customerName + "\nAddress: " + customerAddress + "\nPhone: " + customerPhone +
                "\n\nA copy of the receipt has been saved to " + filePath, "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Reset the form
            home = false;
        }
      
       
        private void btnPromoCode_Click()
        {
            using (var dialog = new Form())
            {
                var label = new Label()
                {
                    Text = "Enter promo code:",
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                var textBox = new TextBox()
                {
                    Location = new Point(10, 40),
                    Width = 200
                };

                var button = new Button()
                {
                    Text = "Apply",
                    Location = new Point(10, 70),
                    DialogResult = DialogResult.OK
                };

                dialog.Controls.Add(label);
                dialog.Controls.Add(textBox);
                dialog.Controls.Add(button);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string promoCode = textBox.Text;
                    // Apply promo code logic here

                   
                    if (promoCode == "SUMMER2023")
                    {
                        // Apply discount or perform specific actions
                        // ...

                         promoCodeApplied = true;
                    }
                    else
                    {
                         promoCodeApplied = false;
                    }
                    // Apply the promo code using the ApplyPromoCode method
                    

                    if (promoCodeApplied)
                    {
                        // Promo code applied successfully, display a message
                        MessageBox.Show("Promo code applied successfully!");
                    }
                    else
                    {
                        // Promo code is invalid or not applicable, display a message
                        MessageBox.Show("Invalid promo code!");
                    }
                }
            }
            if (button1.Enabled == false)
            {
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
                add_cakes = 0;
                add_drinks = 0;
                button1.Enabled = true;
            }
          
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
