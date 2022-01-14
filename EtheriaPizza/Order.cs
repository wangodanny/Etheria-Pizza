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

// ... we must be strong! Hey Adora.

namespace EtheriaPizza
{
    public partial class orderConfirm : Form
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
        public static string address;
        public static string postcode;
        public static string phone;
        public static bool EditCheck = false;
        public class DeliverConfirm //Class used to display customer details if delivery was selected.
        {
            public virtual Tuple<string, string, string, string> ShowDetails()
            {
                name = CustomerDetails.name;
                address = CustomerDetails.street;
                postcode = CustomerDetails.postcode;
                phone = CustomerDetails.phone;

                return new Tuple<string, string, string, string>(name, address, postcode, phone);
            }
            
        }

        public class DeliverChange : DeliverConfirm //Override class to allow customers to modify details if needed
        {
            public override Tuple<string, string, string, string> ShowDetails()
            {
                name = EditDetails.name;
                address = EditDetails.street;
                postcode = EditDetails.postcode;
                phone = EditDetails.phone;

                return new Tuple<string, string, string, string>(name, address, postcode, phone);
            }


        }
        public orderConfirm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        
        private void Order_Load(object sender, EventArgs e)
        {

            if (pizzaMenu.discountFlag == true) { lblDiscount.Visible = true; } // Activates discount notification if flag is selected.
            else { }
            
            if (CustChoice.ToBeDelivered == true) // If delivery is true then activate customer details text boxes.
            {
                pizzaMenu.totalPrice = pizzaMenu.totalPrice + 2.5; // Add delivery fees.
                if (EditCheck == true) // If customer has edited their details then update the text box.
                {
                    txtDelivery.Visible = true;
                    pictureBox3.Visible = true;
                    lblDelivery.Visible = true;
                    btnDeliveryClose.Visible = true;
                    btnEditDetails.Visible = true;
                    lblOrderedAndDelivered.Visible = true;
                    txtCollection.Visible = true;

                    DeliverChange test = new DeliverChange();
                    txtDelivery.Text = Convert.ToString(test.ShowDetails());

                    txtCollection.Text = EtheriaPizza.pizzaMenu.message + "\n";


                    txtPrice.Text = EtheriaPizza.pizzaMenu.totalPrice.ToString("C");
                }
                else
                {
                    txtDelivery.Visible = true;
                    pictureBox3.Visible = true;
                    lblDelivery.Visible = true;
                    btnDeliveryClose.Visible = true;
                    btnEditDetails.Visible = true;
                    lblOrderedAndDelivered.Visible = true;
                    txtCollection.Visible = true;

                    DeliverConfirm test = new DeliverConfirm();
                    string detailLoad = Convert.ToString(test.ShowDetails());
                    txtDelivery.Text = detailLoad;

                    txtCollection.Text = EtheriaPizza.pizzaMenu.message + "\n";


                    txtPrice.Text = EtheriaPizza.pizzaMenu.totalPrice.ToString("C");
                }
                    
            }
            else // Only display what was ordered and do not display boxes for delivery as it was not selected.
            {
                lblOrderedAndDelivered.Visible = true;
                btnCollectClose.Visible = true;
                txtCollection.Text = EtheriaPizza.pizzaMenu.message + "\n";
                txtPrice.Text = EtheriaPizza.pizzaMenu.totalPrice.ToString("C");
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void pictureBox1_Click(object sender, EventArgs e) // Close button
        {
            Environment.Exit(0);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeliveryClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEditDetails_Click(object sender, EventArgs e) //Open a new window to edit customer details and set a flag.
        {
            EditCheck = true;
            EditDetails newDetail = new EditDetails();
            newDetail.Show();
            this.Hide();
            newDetail.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void txtCollection_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lblDelivery_Click(object sender, EventArgs e)
        {

        }
    }
}
