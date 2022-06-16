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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void Area_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Area = null;
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numericUpDown1.Value);
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            switch (from)
            {
                case "Га":
                    {
                        switch (to)
                        {
                            case "Га": { break; }
                            case "А": { num *= 100; break; }
                            case "М²": { num *= 10000; break; }
                            case "См²": { num *= Math.Pow(10, 8); break; }

                        }
                        break;
                    }
                case "А":
                    {
                        switch (to)
                        {
                            case "Га": { num *= 0.01; break; }
                            case "А": { break; }
                            case "М²": { num *= 100; break; }
                            case "См²": { num *= Math.Pow(10, 6); break; }

                        }
                        break;
                    }
                case "М²":
                    {
                        switch (to)
                        {
                            case "Га": { num *= 0.0001; break; }
                            case "А": { num *= 0.01; break; }
                            case "М²": { break; }
                            case "См²": { num *= Math.Pow(10, 4); break; }

                        }
                        break;
                    }
                case "См²":
                    {
                        switch (to)
                        {
                            case "Га": { num *= Math.Pow(10, -8); break; }
                            case "А": { num *= Math.Pow(10, -6); break; }
                            case "М²": { num *= 0.0001; break; }
                            case "См²": { break; }

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
