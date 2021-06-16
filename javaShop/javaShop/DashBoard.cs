using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace javaShop
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public DashBoard(string user)
        {
            InitializeComponent();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            access ae = new access();
            this.Hide();
            ae.Show();
        }
        
        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbname.SelectedItem.ToString() == "Affogato")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 400).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 600).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 600).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1200).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 2000).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1500).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1700).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1300).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
            else if (cmbname.SelectedItem.ToString() == "Americano")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 300).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 550).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 570).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1000).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1200).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1300).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1500).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1100).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
            else if (cmbname.SelectedItem.ToString() == "Caffe Latte")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 100).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 150).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 270).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 800).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1000).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1100).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1150).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1350).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
            else if (cmbname.SelectedItem.ToString() == "Caffe Mocha")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 90).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 100).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 120).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 140).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 600).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 900).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 950).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1220).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
            else if (cmbname.SelectedItem.ToString() == "Caffe Au Lait")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 60).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 75).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 80).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 100).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 450).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 600).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 750).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 820).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
            else if (cmbname.SelectedItem.ToString() == "Cappuccino")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 500).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 700).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 800).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1300).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 2100).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1600).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1800).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1400).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
            else if (cmbname.SelectedItem.ToString() == "Cold Drew Coffee")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 40).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 55).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 60).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 75).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 80).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 95).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 105).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 120).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
            else if (cmbname.SelectedItem.ToString() == "Double Espresso")
            {
                if (cmbtype.SelectedItem.ToString() == "Arabica")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 550).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Robusta")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 750).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Black Coffee")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 850).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Latte")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1350).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Cappuccino")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 2150).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Americano")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1650).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Espresso")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1850).ToString();
                }
                if (cmbtype.SelectedItem.ToString() == "Doppio")
                {
                    textpayment.Text = (float.Parse(cmbquantity.Text) * 1450).ToString();
                }
                dataGridView1.Rows.Add(textid.Text, cmbname.Text, cmbtype.Text, cmbquantity.Text, textpayment.Text);
            }
        }

        private void textid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back; 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textid.Text = "";
            cmbname.Text = "";
            cmbtype.Text = "";
            cmbquantity.Text = "";
            textpayment.Text = "";
        }
    }
}
