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

// ... never let it go...

namespace EtheriaPizza
{
    public partial class EditDetails : Form
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

        // Set required varibles
        public static string name;
        public static string street;
        public static string postcode;
        public static string phone;
        public EditDetails() // Rounded window corners
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void lblConfirmText_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelectPizza_Click(object sender, EventArgs e)
        {
            
        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustPostcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text == "" || txtCustStreet.Text == "" || txtCustPostcode.Text == "" || txtCustPhone.Text == "")  //If no boxes are filled then alert the user
            {
                MessageBox.Show("You need to fill all the boxes first."); 
            }
            else  // Save customer details for later use and show the final confirmation screen
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

        private void txtCustStreet_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
