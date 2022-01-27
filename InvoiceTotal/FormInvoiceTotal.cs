using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal {
    public partial class FormInvoiceTotal : Form {
        public FormInvoiceTotal() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Exit_Click(object sender, EventArgs e) {
            Close();
        }

        private void Calculate_Click(object sender, EventArgs e) {
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            decimal discountPercent = 0.0m;
            if (subtotal >= 500) {
                discountPercent = 0.2m;
            } else if (subtotal >= 250 && subtotal < 500) {
                discountPercent = 0.15m;
            } else if (subtotal >= 100 && subtotal < 250) {
                discountPercent = 0.1m;
            }

            decimal discountAmount = subtotal * discountPercent;

            decimal total = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = total.ToString("c");

            txtSubtotal.Focus();
        }
    }
}
