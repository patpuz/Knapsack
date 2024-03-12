using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using solver;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Problem problem;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int numItems = int.Parse(textBox1.Text);
                int seed = int.Parse(textBox2.Text);
                if (numItems > 0 && seed > 0){
                    textBox1.BackColor = SystemColors.Window;
                    textBox2.BackColor = SystemColors.Window;
                    problem = new Problem(numItems, seed);
                    listBox2.Items.Clear();
                    foreach (var item in problem.GetItems())
                    {
                        listBox2.Items.Add(item);
                    }
                }
                else if (numItems < 0)
                {
                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = SystemColors.Window;
                    label6.Text = "Item number should be more than zero";
                }
                else if (seed < 0) {
                    textBox1.BackColor = SystemColors.Window;
                    textBox2.BackColor = Color.Red;
                    label6.Text = "Seed number should be more than zero";
                }
                else if (seed < 0 && numItems < 0)
                {
                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                    label6.Text = "You should enter number more than zero";

                }
            }
            catch (FormatException)
            {
                textBox1.BackColor = Color.Red;
                textBox2.BackColor = Color.Red;
                label6.Text = "You should put numbers";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (problem == null)
                {
                    label6.Text = "You should generate items first";
                    return;
                }

                int capacity = int.Parse(textBox3.Text);
                if (capacity < 0)
                {
                    textBox3.BackColor = Color.Red;
                    label6.Text = "Capacity must be more than zero";
                    return;
                }

                Result result = problem.Solve(capacity);

                listBox1.Items.Clear();
                foreach (var item in result.Pack)
                {
                    listBox1.Items.Add(item);
                    textBox3.BackColor = SystemColors.Window;
                }

                label4.Text = "Total Value: " + result.TotalValue;
                label5.Text = "Total Weight: " + result.TotalWeight;
            }
            catch (FormatException)
            {
                label6.Text = "Please enter a number for capacity.";
                textBox3.BackColor = Color.Red;
            }
        }
    }
}
