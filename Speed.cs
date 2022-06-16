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
    public partial class Speed : Form
    {
        public Speed()
        {
            InitializeComponent();
        }

        private void Speed_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Speed = null;
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
                            case "Км/г": { num *= 1079252848.8; break; }
                            case "Км/с": { num *= 299792.46; break; }
                            case "М/с": { num *= 299792458; break; }

                        }
                        break;
                    }
                case "Км/г":
                    {
                        switch (to)
                        {
                            case "С": { num *= 9.27 * Math.Pow(10, -10); break; }
                            case "Км/г": { break; }
                            case "Км/с": { num *= 2.78 * Math.Pow(10, -4); break; }
                            case "М/с": { num *= 0.28; break; }

                        }
                        break;
                    }
                case "Км/с":
                    {
                        switch (to)
                        {
                            case "С": { num *= 3.34 * Math.Pow(10, -6); break; }
                            case "Км/г": { num *= 3600; break; }
                            case "Км/с": { break; }
                            case "М/с": { num *= 1000; break; }

                        }
                        break;
                    }
                case "М/с":
                    {
                        switch (to)
                        {
                            case "С": { num *= 3.34 * Math.Pow(10, -9); break; }
                            case "Км/г": { num *= 3.6; break; }
                            case "Км/с": { num *= Math.Pow(10, -3); break; }
                            case "М/с": { break; }

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
