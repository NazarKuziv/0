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
    public partial class Volume : Form
    {
        public Volume()
        {
            InitializeComponent();
        }

        private void Volume_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Vol = null;
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numericUpDown1.Value);
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            switch (from)
            {
                case "М³":
                    {
                        switch (to)
                        {
                            case "М³": { break; }
                            case "См³": { num *= Math.Pow(10, 6); break; }
                            case "Мм³": { num *= Math.Pow(10, 9); break; }
                            case "Л": { num *= Math.Pow(10, 3); break; }

                        }
                        break;
                    }
                case "См³":
                    {
                        switch (to)
                        {
                            case "М³": { num *= Math.Pow(10, -6); break; }
                            case "См³": { break; }
                            case "Мм³": { num *= Math.Pow(10, 3); break; }
                            case "Л": { num *= Math.Pow(10, -3); break; }

                        }
                        break;
                    }
                case "Мм³":
                    {
                        switch (to)
                        {
                            case "М³": { num *= Math.Pow(10, -9); break; }
                            case "См³": { num *= Math.Pow(10, -3); break; }
                            case "Мм³": { break; }
                            case "Л": { num *= Math.Pow(10, -6); break; }

                        }
                        break;
                    }
                case "Л":
                    {
                        switch (to)
                        {
                            case "М³": { num *= Math.Pow(10, -3); break; }
                            case "См³": { num *= Math.Pow(10, 3); break; }
                            case "Мм³": { num *= Math.Pow(10, 6); break; }
                            case "Л": { break; }

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
