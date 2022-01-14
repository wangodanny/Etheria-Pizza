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

// We must be strong, (we must be strong)...

namespace EtheriaPizza
{
    public partial class CustChoice : Form
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
        public static bool ToBeDelivered = false; // Set delivery flag for later usage
        public CustChoice() //Rounded window corners
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void lblChoice_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPizzaSkipSelect_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeliverySubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void CustChoice_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click_1(object sender, EventArgs e) // Close button closes the program
        {
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Set a flag if delivery is selected and then open the menu
        {
            ToBeDelivered = true;
            pizzaMenu menu = new pizzaMenu();
            menu.Show();
            this.Hide();
            menu.FormClosed += (s, args) => this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e) // Move on to the menu without delivery flag if collection if selected
        {
            ToBeDelivered = false;
            pizzaMenu menu = new pizzaMenu();
            menu.Show();
            this.Hide();
            menu.FormClosed += (s, args) => this.Close();
        }
    }
}
