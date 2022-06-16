using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }

        private void Temperature_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.T = null;
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numericUpDown1.Value);
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            switch (from)
            {
                case "С":
                    {
                        switch (to)
                        {
                            case "С": { break; }
                            case "Ф": { num *= 33.8; break; }
                            case "К": { num *= 274.15; break; }
                        }
                        break;
                    }
                case "Ф":
                    {
                        switch (to)
                        {
                            case "С": { num *= -17.22; break; }
                            case "Ф": { break; }
                            case "К": { num *= 255.93; break; }
                        }
                        break;
                    }
                case "К":
                    {
                        switch (to)
                        {
                            case "С": { num *= -272.15; break; }
                            case "Ф": { num *= -457.87; break; }
                            case "К": { break; }
                        }
                        break;
                    }
                default:
                    {
                        Result.Text = "Null";
                        break;
                    }
            }
            Result.Text = num.ToString();
        }
    }
}
