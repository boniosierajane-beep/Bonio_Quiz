using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bonio_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] classmates = { "Siera", "Jane", "Ian", "Rion", "Isidro", "Prince" };
            foreach (string name in classmates)
            { listBox1.Items.Add(name); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] alphabet =
            {
        { "A", "B", "C" },
        { "D", "E", "F" }
    };

            string grid = "";

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid += alphabet[i, j] + "   ";
                }
                grid += "\n";
            }

            MessageBox.Show(grid, "Alphabet Grid");
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

            string input = textBox1.Text;


            if (input.ToLower().Contains("hello"))
            {
                MessageBox.Show($"Found it! Your message: '{input}' contains 'hello'.");
            }
            else
            {
                MessageBox.Show("Keep typing! 'hello' was not found in your message.");
            }
        }

    }

}
