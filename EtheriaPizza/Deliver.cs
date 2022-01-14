using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//And never let it go...

namespace EtheriaPizza
{
    public partial class Deliver : Form
    {
        public Deliver()
        {
            InitializeComponent();
        }

        private void Deliver_Load(object sender, EventArgs e)
        {
            txtCustName.Text = CustomerDetails.name;
            txtCustStreet.Text = CustomerDetails.street;
            txtCustPostcode.Text = CustomerDetails.postcode;
            txtCustPhone.Text = CustomerDetails.phone;
        }
        private void btnSelectPizza_Click(object sender, EventArgs e)
        {
  
        }

        private void btnSelectPizza_Click_1(object sender, EventArgs e)
        {
            orderConfirm order = new orderConfirm();
            order.Show();
            this.Hide();
            order.FormClosed += (s, args) => this.Close();
        }

        private void lblConfirmText_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblPostcode_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }
    }
}
