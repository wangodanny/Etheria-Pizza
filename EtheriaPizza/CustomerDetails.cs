using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//... we got to reach inside, stand together and fight...

namespace EtheriaPizza
{
   
    public partial class CustomerDetails : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse

          );

        //Defining the variables needed for later
        public static string name;
        public static string street;
        public static string postcode;
        public static string phone;

        
        public CustomerDetails()  // Rounded window corners
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPizzaSkipSelect_Click(object sender, EventArgs e)
        {
   
        }

        private void lblDeliverySubmit_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtCustStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustPostcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPostcode_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == "" || txtCustStreet.Text == "" || txtCustPostcode.Text == "" || txtCustPhone.Text == "")  //If no boxes are filled then alert the user
            {
                MessageBox.Show("You need to fill all the boxes first.");
            }
            else // Save customer details for later use and show the final confirmation screen
            {
                name = txtCustName.Text;
                street = txtCustStreet.Text;
                postcode = txtCustPostcode.Text;
                phone = txtCustPhone.Text;

                orderConfirm order = new orderConfirm();
                order.Show();
                this.Hide();
                order.FormClosed += (s, args) => this.Close();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e) // Clicking the logo takes you back to the first screen
            {
            CustChoice home = new CustChoice();
            home.Show();
            this.Hide();
            home.FormClosed += (s, args) => this.Close();
        }
    }
}
