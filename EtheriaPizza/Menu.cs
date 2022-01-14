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

// ... and we must be brave (we must be brave)...

namespace EtheriaPizza
{
    public partial class pizzaMenu : Form
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
        public double price = 0;
        public static double totalPrice = 0;
        public static string message = "";
        string pizzaSize = "";
        string pizzaType = "";
        public static bool discountFlag = false;
        public int messageNum = 0;
        public class ToppingOut //Create a message containing the customer's pizza choice and any toppings if selected
        {
            public string TopOut(string type, string size)
            {
                message = message + size + " " + type + " with no extras.";
                return message;
            }

            public string TopOut(string type, string size, string toppingOne)
            {
                message = message + size + " " + type + " with extra " + toppingOne + ".";
                return message;
            }

            public string TopOut(string type, string size, string toppingOne, string toppingTwo)
            {
                message = message + size + " " + type + " with extra " + toppingOne + " and " + toppingTwo + ".";
                return message;
            }

            public string TopOut(string type, string size, string toppingOne, string toppingTwo, string toppingThree)
            {
                message = message + size + " " + type + " with extra " + toppingOne + ", " + toppingTwo + " and " + toppingThree + ".";
                return message;
            }
        }
        public class mArray
        {
            
        }
        public pizzaMenu() // Rounded window corners
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcCost_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
         
        }

        private void cmbPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbAddToppings1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pizzaMenu_Load(object sender, EventArgs e)
        {

        }

        private void txtTotalCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e) //Resets the text boxes
        {
            cmbPizzaType.SelectedIndex = -1;
            cmbPizzaSize.SelectedIndex = -1;
            cmbAddToppings1.SelectedIndex = -1;
            cmbAddToppings2.SelectedIndex = -1;
            cmbAddToppings3.SelectedIndex = -1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {   
            if (cmbPizzaType.Text == "" || cmbPizzaSize.Text == "") //If no boxes are filled then alert the user
            {
                MessageBox.Show("You need to give a size and type of pizza");
            }
            else
            {
                if (totalPrice >= 20) //If the price is over £20 then apply a discount and set a display flag
                {
                    totalPrice = totalPrice - totalPrice * 0.1;
                    discountFlag = true;
                }
                else { }

                ToppingOut topping = new ToppingOut();
                pizzaType = cmbPizzaType.Text;
                switch (cmbPizzaSize.Text) // Show pizza sizes and prices
                {
                    case "Small - £5":
                        price = 5;
                        pizzaSize = "Small";
                        break;
                    case "Medium - £7.50":
                        price = 7.5;
                        pizzaSize = "Medium";
                        break;
                    case "Large - £10":
                        price = 10;
                        pizzaSize = "Large";
                        break;
                    case "Extra Large - £12.50":
                        pizzaSize = "Extra Large";
                        price = 12.5;
                        break;
                }


                if (cmbAddToppings1.Text != "" && cmbAddToppings2.Text != "" && cmbAddToppings3.Text != "") //Topping box 1 and 3
                {
                    price += 3;
                    message = topping.TopOut(pizzaType, pizzaSize, cmbAddToppings1.Text, cmbAddToppings2.Text, cmbAddToppings3.Text);
                    message = message + "\n";
                }

                else if (cmbAddToppings1.Text != "" && cmbAddToppings3.Text != "") //Topping box 1 and 3
                {
                    price += 2;
                    message = topping.TopOut(pizzaType, pizzaSize, cmbAddToppings1.Text, cmbAddToppings3.Text);
                    message = message + "\n";
                }

                else if (cmbAddToppings2.Text != "" && cmbAddToppings3.Text != "") // Topping box 2 and 3
                {
                    price += 2;
                    message = topping.TopOut(pizzaType, pizzaSize, cmbAddToppings2.Text, cmbAddToppings3.Text);
                    message = message + "\n";
                }

                else if (cmbAddToppings1.Text != "" && cmbAddToppings2.Text != "") // Topping box 1 and 2
                {
                    price += 2;
                    message = topping.TopOut(pizzaType, pizzaSize, cmbAddToppings1.Text, cmbAddToppings2.Text);
                    message = message + "\n";
                }

                else if (cmbAddToppings1.Text != "") // Topping box 1
                {
                    price += 1;
                    message = topping.TopOut(pizzaType, pizzaSize, cmbAddToppings1.Text);
                    message = message + "\n";
                }
                else if (cmbAddToppings2.Text != "")// Topping box 2
                {
                    price += 1;
                    message = topping.TopOut(pizzaType, pizzaSize, cmbAddToppings2.Text);
                    message = message + "\n";
                }
                else if (cmbAddToppings3.Text != "")// Topping box 3
                {
                    price += 1;
                    message = topping.TopOut(pizzaType, pizzaSize, cmbAddToppings3.Text);
                    message = message + "\n";
                }
                else
                {
                    message = topping.TopOut(pizzaType, pizzaSize); // No toppings selected
                    message = message + "\n";
                }

                MessageBox.Show("The price for your pizza is: " + price.ToString("C")); // Show price to the user

                totalPrice = totalPrice + price;
                txtTotalCost.Text = totalPrice.ToString("C");

                

                

                MessageBox.Show(message); // Display their order
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (txtTotalCost.Text == "") // If they forget to store an order then notify the user
            {
                MessageBox.Show("You need to add an order to the basket first.");
            }
            else
            {
                if (CustChoice.ToBeDelivered == true) // Open a window to enter customer details for delivery
                {
                    CustomerDetails detail = new CustomerDetails();
                    detail.Show();
                    this.Hide();
                    detail.FormClosed += (s, args) => this.Close(); ;
                }
                else
                {
                    orderConfirm order = new orderConfirm(); // Head to the final page and display their order
                    order.Show();
                    this.Hide();
                    order.FormClosed += (s, args) => this.Close();
                }



            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) // Clicking the logo takes you back to the first screen
        {
            CustChoice home = new CustChoice();
            home.Show();
            this.Hide();
            home.FormClosed += (s, args) => this.Close();
        }

        private void cmbAddToppings2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
