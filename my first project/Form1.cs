using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_first_project
{

    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (coffeecombo.SelectedItem.ToString() == "Latte")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 600).ToString();
                }

                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 500).ToString();
                }

                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 900).ToString();
                }

                dataGridView1.Rows.Add(idcombo.Text, coffeecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }

            if (coffeecombo.SelectedItem.ToString() == "Cappuchino")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 700).ToString();
                }

                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 550).ToString();
                }

                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 800).ToString();
                }

                dataGridView1.Rows.Add(idcombo.Text, coffeecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);

            }

            if (coffeecombo.SelectedItem.ToString() == "Chocolate")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 650).ToString();
                }

                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 750).ToString();
                }

                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 850).ToString();
                }

                dataGridView1.Rows.Add(idcombo.Text, coffeecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);

            }

        }

        private void idcombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {

            }

            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            idcombo.Text = "";
            coffeecombo.Text = "";
            typecombo.Text = "";
            quantitycombo.Text = "";
            paytext.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Shop_Load(object sender, EventArgs e)
        {

        }

    }
}