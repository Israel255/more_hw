using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace more_hw_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox1.SelectedItem == comboBox2.SelectedItem && comboBox1.SelectedItem == comboBox3.SelectedItem)
            {
                MessageBox.Show(comboBox1.SelectedItem + " won!");
            }
            else if (comboBox1.SelectedItem == comboBox4.SelectedItem && comboBox1.SelectedItem == comboBox7.SelectedItem)
            {
                MessageBox.Show(comboBox1.SelectedItem + " won!");
            }
            else if (comboBox1.SelectedItem == comboBox5.SelectedItem && comboBox1.SelectedItem == comboBox9.SelectedItem)
            {
                MessageBox.Show(comboBox1.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {
                if (comboBox1.SelectedIndex != comboBox2.SelectedIndex && comboBox1.SelectedIndex != comboBox3.SelectedIndex && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox1.SelectedIndex != comboBox4.SelectedIndex && comboBox1.SelectedIndex != comboBox7.SelectedIndex && comboBox4.SelectedIndex > -1 && comboBox7.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox1.SelectedIndex != comboBox5.SelectedIndex && comboBox1.SelectedIndex != comboBox9.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox9.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox2.SelectedItem == comboBox5.SelectedItem && comboBox2.SelectedItem == comboBox8.SelectedItem)
            {
                MessageBox.Show(comboBox2.SelectedItem + " won!");
            }
            else if (comboBox2.SelectedItem == comboBox1.SelectedItem && comboBox2.SelectedItem == comboBox3.SelectedItem)
            {
                MessageBox.Show(comboBox2.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox2.SelectedIndex != comboBox5.SelectedIndex && comboBox2.SelectedIndex != comboBox8.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox8.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox2.SelectedIndex != comboBox1.SelectedIndex && comboBox2.SelectedIndex != comboBox3.SelectedIndex && comboBox1.SelectedIndex > -1 && comboBox3.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox3.SelectedItem == comboBox2.SelectedItem && comboBox3.SelectedItem == comboBox1.SelectedItem)
            {
                MessageBox.Show(comboBox3.SelectedItem + " won!");
            }
            else if (comboBox3.SelectedItem == comboBox5.SelectedItem && comboBox3.SelectedItem == comboBox7.SelectedItem)
            {
                MessageBox.Show(comboBox3.SelectedItem + " won!");
            }
            else if (comboBox3.SelectedItem == comboBox6.SelectedItem && comboBox3.SelectedItem == comboBox9.SelectedItem)
            {
                MessageBox.Show(comboBox3.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox3.SelectedIndex != comboBox2.SelectedIndex && comboBox3.SelectedIndex != comboBox1.SelectedIndex && comboBox2.SelectedIndex > -1 && comboBox1.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox3.SelectedIndex != comboBox5.SelectedIndex && comboBox3.SelectedIndex != comboBox7.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox7.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox3.SelectedIndex != comboBox6.SelectedIndex && comboBox3.SelectedIndex != comboBox9.SelectedIndex && comboBox6.SelectedIndex > -1 && comboBox9.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox4.SelectedItem == comboBox1.SelectedItem && comboBox4.SelectedItem == comboBox7.SelectedItem)
            {
                MessageBox.Show(comboBox4.SelectedItem + " won!");
            }
            else if (comboBox4.SelectedItem == comboBox5.SelectedItem && comboBox4.SelectedItem == comboBox6.SelectedItem)
            {
                MessageBox.Show(comboBox4.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox4.SelectedIndex != comboBox1.SelectedIndex && comboBox4.SelectedIndex != comboBox7.SelectedIndex && comboBox1.SelectedIndex > -1 && comboBox7.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox4.SelectedIndex != comboBox5.SelectedIndex && comboBox4.SelectedIndex != comboBox6.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox5.SelectedItem == comboBox1.SelectedItem && comboBox5.SelectedItem == comboBox9.SelectedItem)
            {
                MessageBox.Show(comboBox5.SelectedItem + " won!");
            }
            else if (comboBox5.SelectedItem == comboBox3.SelectedItem && comboBox5.SelectedItem == comboBox7.SelectedItem)
            {
                MessageBox.Show(comboBox5.SelectedItem + " won!");
            }
            else if (comboBox5.SelectedItem == comboBox2.SelectedItem && comboBox5.SelectedItem == comboBox8.SelectedItem)
            {
                MessageBox.Show(comboBox5.SelectedItem + " won!");
            }
            else if (comboBox5.SelectedItem == comboBox4.SelectedItem && comboBox5.SelectedItem == comboBox6.SelectedItem)
            {
                MessageBox.Show(comboBox5.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox5.SelectedIndex != comboBox1.SelectedIndex && comboBox5.SelectedIndex != comboBox9.SelectedIndex && comboBox1.SelectedIndex > -1 && comboBox9.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox5.SelectedIndex != comboBox3.SelectedIndex && comboBox5.SelectedIndex != comboBox7.SelectedIndex && comboBox3.SelectedIndex > -1 && comboBox7.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox5.SelectedIndex != comboBox2.SelectedIndex && comboBox5.SelectedIndex != comboBox8.SelectedIndex && comboBox2.SelectedIndex > -1 && comboBox8.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox5.SelectedIndex != comboBox4.SelectedIndex && comboBox5.SelectedIndex != comboBox6.SelectedIndex && comboBox4.SelectedIndex > -1 && comboBox6.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox6_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox6.SelectedItem == comboBox5.SelectedItem && comboBox6.SelectedItem == comboBox4.SelectedItem)
            {
                MessageBox.Show(comboBox6.SelectedItem + " won!");
            }
            else if (comboBox6.SelectedItem == comboBox3.SelectedItem && comboBox6.SelectedItem == comboBox9.SelectedItem)
            {
                MessageBox.Show(comboBox6.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox6.SelectedIndex != comboBox5.SelectedIndex && comboBox6.SelectedIndex != comboBox4.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox4.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox6.SelectedIndex != comboBox3.SelectedIndex && comboBox6.SelectedIndex != comboBox9.SelectedIndex && comboBox3.SelectedIndex > -1 && comboBox9.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox7_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox7.SelectedItem == comboBox4.SelectedItem && comboBox7.SelectedItem == comboBox1.SelectedItem)
            {
                MessageBox.Show(comboBox7.SelectedItem + " won!");
            }
            else if (comboBox7.SelectedItem == comboBox5.SelectedItem && comboBox7.SelectedItem == comboBox3.SelectedItem)
            {
                MessageBox.Show(comboBox7.SelectedItem + " won!");
            }
            else if (comboBox7.SelectedItem == comboBox8.SelectedItem && comboBox7.SelectedItem == comboBox9.SelectedItem)
            {
                MessageBox.Show(comboBox7.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox7.SelectedIndex != comboBox4.SelectedIndex && comboBox7.SelectedIndex != comboBox1.SelectedIndex && comboBox4.SelectedIndex > -1 && comboBox1.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox7.SelectedIndex != comboBox5.SelectedIndex && comboBox7.SelectedIndex != comboBox3.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox3.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox7.SelectedIndex != comboBox8.SelectedIndex && comboBox7.SelectedIndex != comboBox9.SelectedIndex && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox8_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox8.SelectedItem == comboBox7.SelectedItem && comboBox8.SelectedItem == comboBox9.SelectedItem)
            {
                MessageBox.Show(comboBox8.SelectedItem + " won!");
            }
            else if (comboBox8.SelectedItem == comboBox5.SelectedItem && comboBox8.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show(comboBox8.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox8.SelectedIndex != comboBox7.SelectedIndex && comboBox8.SelectedIndex != comboBox9.SelectedIndex && comboBox7.SelectedIndex > -1 && comboBox9.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox8.SelectedIndex != comboBox5.SelectedIndex && comboBox8.SelectedIndex != comboBox2.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox2.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }

        private void comboBox9_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int y = 0;
            if (comboBox9.SelectedItem == comboBox8.SelectedItem && comboBox9.SelectedItem == comboBox7.SelectedItem)
            {
                MessageBox.Show(comboBox9.SelectedItem + " won!");
            }
            else if (comboBox9.SelectedItem == comboBox6.SelectedItem && comboBox9.SelectedItem == comboBox3.SelectedItem)
            {
                MessageBox.Show(comboBox9.SelectedItem + " won!");
            }
            else if (comboBox9.SelectedItem == comboBox5.SelectedItem && comboBox9.SelectedItem == comboBox1.SelectedItem)
            {
                MessageBox.Show(comboBox9.SelectedItem + " won!");
            }
            while (comboBox1.SelectedIndex > -1 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > -1 && comboBox4.SelectedIndex > -1 && comboBox5.SelectedIndex > -1 && comboBox6.SelectedIndex > -1 && comboBox7.SelectedIndex > -1 && comboBox8.SelectedIndex > -1 && comboBox9.SelectedIndex > -1 && y == 0)
            {


                if (comboBox9.SelectedIndex != comboBox8.SelectedIndex && comboBox9.SelectedIndex != comboBox7.SelectedIndex && comboBox8.SelectedIndex > -1 && comboBox7.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox9.SelectedIndex != comboBox6.SelectedIndex && comboBox9.SelectedIndex != comboBox3.SelectedIndex && comboBox6.SelectedIndex > -1 && comboBox3.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                else if (comboBox9.SelectedIndex != comboBox5.SelectedIndex && comboBox9.SelectedIndex != comboBox1.SelectedIndex && comboBox5.SelectedIndex > -1 && comboBox1.SelectedIndex > -1)
                {
                    MessageBox.Show("it's a tie!");
                }
                y++;
            }
        }
    }
}
