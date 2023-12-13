using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miss_yusra_Project__OOP__
{
    public partial class Form1 : Form
    {
        int a, b, c, d, add_drinks, add_cakes;
        int[] amount_cakes = new int[] { 13, 17, 14, 11, 22, 17, 19, 15 };
        int[] amount_coffees = new int[] { 2, 3, 1, 2, 7, 11, 5, 1 };
        double x, y, z;

        int[] arr = new int[8];
        int[] arr2 = new int[8];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";

            // Example usage in a Panel control
            panel6.BackgroundImage = new Bitmap(@"C:\Users\Hammad Usmani\Pictures\Saved Pictures\559e9cc9a1112886a243013a3faa5196.jpg");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        //These are cakes textboxes{
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //a = int.Parse(textBox1.Text);

            if (checkBox1.Checked)
            {
                if (!string.IsNullOrEmpty(textBox1.Text))
                {
                    if (int.TryParse(textBox1.Text, out int value))
                    {
                        arr[0] = value;
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //  b = int.Parse( textBox2.Text );
            if (checkBox2.Checked)
            {
                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    if (int.TryParse(textBox2.Text, out int value))
                    {
                        arr[1] = value;
                    }
                }
            }

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (!string.IsNullOrEmpty(textBox5.Text))
                {
                    if (int.TryParse(textBox5.Text, out int value))
                    {
                        arr[2] = value;
                    }
                }
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                if (!string.IsNullOrEmpty(textBox12.Text))
                {
                    if (int.TryParse(textBox12.Text, out int value))
                    {
                        arr[3] = value;
                    }
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                if (!string.IsNullOrEmpty(textBox13.Text))
                {
                    if (int.TryParse(textBox13.Text, out int value))
                    {
                        arr[4] = value;
                    }
                }
            }
        }


        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                if (!string.IsNullOrEmpty(textBox14.Text))
                {
                    if (int.TryParse(textBox14.Text, out int value))
                    {
                        arr[5] = value;
                    }
                }
            }
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                if (!string.IsNullOrEmpty(textBox15.Text))
                {
                    if (int.TryParse(textBox15.Text, out int value))
                    {
                        arr[6] = value;
                    }
                }
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                if (!string.IsNullOrEmpty(textBox16.Text))
                {
                    if (int.TryParse(textBox16.Text, out int value))
                    {
                        arr[7] = value;
                    }
                }
            }
        }
    //}

        //These are drinks Textboxes {
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //  c = int.Parse( textBox3.Text );
            if (checkBox3.Checked)
            {
                if (!string.IsNullOrEmpty(textBox3.Text))
                {
                    if (int.TryParse(textBox3.Text, out int value))
                    {
                        arr2[0] = value;
                    }
                }
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            // d = int.Parse( textBox4.Text );
            if (checkBox4.Checked)
            {
                if (!string.IsNullOrEmpty(textBox4.Text))
                {
                    if (int.TryParse(textBox4.Text, out int value))
                    {
                        arr2[1] = value;
                    }
                }
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                if (!string.IsNullOrEmpty(textBox17.Text))
                {
                    if (int.TryParse(textBox17.Text, out int value))
                    {
                        arr2[2] = value;
                    }
                }
            }
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                if (!string.IsNullOrEmpty(textBox18.Text))
                {
                    if (int.TryParse(textBox18.Text, out int value))
                    {
                        arr2[3] = value;
                    }
                }
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                if (!string.IsNullOrEmpty(textBox19.Text))
                {
                    if (int.TryParse(textBox19.Text, out int value))
                    {
                        arr2[4] = value;
                    }
                }
            }
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                if (!string.IsNullOrEmpty(textBox20.Text))
                {
                    if (int.TryParse(textBox20.Text, out int value))
                    {
                        arr2[5] = value;
                    }
                }
            }
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                if (!string.IsNullOrEmpty(textBox21.Text))
                {
                    if (int.TryParse(textBox21.Text, out int value))
                    {
                        arr2[6] = value;
                    }
                }
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                if (!string.IsNullOrEmpty(textBox22.Text))
                {
                    if (int.TryParse(textBox22.Text, out int value))
                    {
                        arr2[7] = value;
                    }
                }
            }
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
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

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

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
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

            textBox5.Text = Convert.ToString("$"+add_drinks);
            textBox6.Text = Convert.ToString("$"+add_cakes);
            textBox7.Text = "$1.07";

            z = 0.07;
            textBox8.Text = Convert.ToString("$"+z);
            x= ( add_cakes + add_drinks );
            textBox9.Text = Convert.ToString("$"+ x);
            y=(0.07 + add_drinks + add_cakes) ;
            textBox10.Text = Convert.ToString("$" + y);
        }

       private void button2_Click(object sender, EventArgs e)
        {
       
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox5.Text = "$0";
            textBox6.Text = "$0";
            textBox7.Text = "$0";
            textBox8.Text = "$0";
            textBox9.Text = "$0";
            textBox10.Text = "$0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
