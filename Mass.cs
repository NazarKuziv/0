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
    public partial class Mass : Form
    {
        public Mass()
        {
            InitializeComponent();
        }

        private void Mass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Mas = null;
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numericUpDown1.Value);
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            switch (from)
            {
                case "Т":
                    {
                        switch (to)
                        {
                            case "Т": { break; }
                            case "Кг": { num *= 1000; break; }
                            case "Г": { num *= 1000000; break; }
                            case "Мг": { num *= Math.Pow(10, 9); break; }

                        }

                        break;
                    }
                case "Кг":
                    {
                        switch (to)
                        {
                            case "Т": { num *= 0.001; break; }
                            case "Кг": { break; }
                            case "Г": { num *= 1000; break; }
                            case "Мг": { num *= Math.Pow(10, 6); break; }

                        }

                        break;
                    }
                case "Г":
                    {
                        switch (to)
                        {
                            case "Т": { num *= Math.Pow(10, -6); break; }
                            case "Кг": { num *= 0.001; break; }
                            case "Г": { break; }
                            case "Мг": { num *= 1000; break; }

                        }

                        break;
                    }
                case "Мг":
                    {
                        switch (to)
                        {
                            case "Т": { num *= Math.Pow(10, -9); break; }
                            case "Кг": { num *= Math.Pow(10, -6); break; }
                            case "Г": { num *= 0.001; break; }
                            case "Мг": { break; }

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
