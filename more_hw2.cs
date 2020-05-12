using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace more_hw_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int x = 1980;
            for (int i = 0; i <= 40; i++)
            {
                years_cbx.Items.Add(x);
                x++;
            }
        }

        private void days_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (days_cbx.Text == "days" || months_cbx.Text == "months" || years_cbx.Text == "years")
            {
                MessageBox.Show("eror!");
            }
            else
            {
                MessageBox.Show("day: " + days_cbx.SelectedItem + "|| month: " + months_cbx.SelectedItem + "|| year: " + years_cbx.SelectedItem);
            }
        }
    }
}
