using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace more_hw_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(num_txtbx.Text);
                list_lbx.Items.Add(num_txtbx.Text);
            }
            catch
            {
                MessageBox.Show("Eror!!!!");
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            try
            {
                list_lbx.Items.RemoveAt(list_lbx.Items.Count - 1);
            }
            catch
            {
                MessageBox.Show("Eror!!!!");
            }
        }

        private void sum_btn_Click(object sender, EventArgs e)
        {
                int sum = 0;
                for (int i = 0; i < list_lbx.Items.Count; i++)
                {
                    int y = Convert.ToInt32(list_lbx.Items[i]);
                    sum += y;
                }
                MessageBox.Show("the sum is: " + sum);
        }
    }
}
