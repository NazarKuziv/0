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
    public partial class Lenght : Form
    {
        public Lenght()
        {
            InitializeComponent();
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numericUpDown1.Value);
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            switch (from)
            {
                case "Км":
                    {
                        switch (to)
                        {
                            case "Км": { break; }
                            case "М": { num *= 1000; break; }
                            case "См": { num *= 100000; break; }
                            case "Мм": { num *= 1000000; break; }
                            case "Мл": { num *= 0.6214; break; }
                            case "Яр": { num *= 1093.6132; break; }
                            case "Фт": { num *= 3280.8398; break; }
                        }
                        break;
                    }
                case "М":
                    {
                        switch (to)
                        {
                            case "Км": { num *= 0.001; break; }
                            case "М": { break; }
                            case "См": { num *= 100; break; }
                            case "Мм": { num *= 1000; break; }
                            case "Мл": { num *= 0.0006; break; }
                            case "Яр": { num *= 1.0936; break; }
                            case "Фт": { num *= 3.2808; break; }
                        }
                        break;
                    }
                case "См":
                    {
                        switch (to)
                        {
                            case "Км": { num *= 0.000010; break; }
                            case "М": { num *= 0.01; break; }
                            case "См": { break; }
                            case "Мм": { num *= 10; break; }
                            case "Мл": { num *= 0.0000062; break; }
                            case "Яр": { num *= 0.0109; break; }
                            case "Фт": { num *= 0.0328; break; }
                        }
                        break;
                    }
                case "Мм":
                    {
                        switch (to)
                        {
                            case "Км": { num *= 0.0000010; break; }
                            case "М": { num *= 0.0001; break; }
                            case "См": { num *= 0.01; break; }
                            case "Мм": { break; }
                            case "Мл": { num *= 6.2137 * Math.Pow(10, -7); break; }
                            case "Яр": { num *= 0.0011; break; }
                            case "Фт": { num *= 0.0033; break; }
                        }
                        break;
                    }
                case "Мл":
                    {
                        switch (to)
                        {
                            case "Км": { num *= 1.6; break; }
                            case "М": { num *= 1.609; break; }
                            case "См": { num *= 160934.4; break; }
                            case "Мм": { num *= 1609344; break; }
                            case "Мл": { break; }
                            case "Яр": { num *= 1.760; break; }
                            case "Фт": { num *= 5280; break; }
                        }
                        break;
                    }
                case "Яр":
                    {
                        switch (to)
                        {
                            case "Км": { num *= 0.000914; break; }
                            case "М": { num *= 0.91; break; }
                            case "См": { num *= 91.44; break; }
                            case "Мм": { num *= 914.4; break; }
                            case "Мл": { num *= 0.000568; break; }
                            case "Яр": { break; }
                            case "Фт": { num *= 3; break; }
                        }
                        break;
                    }
                case "Фт":
                    {
                        switch (to)
                        {
                            case "Км": { num *= 0.0003048; break; }
                            case "М": { num *= 0.3048; break; }
                            case "См": { num *= 30.48; break; }
                            case "Мм": { num *= 304.8; break; }
                            case "Мл": { num *= 0.00019; break; }
                            case "Яр": { num *= 0.3333; break; }
                            case "Фт": { break; }
                        }
                        break;
                    }


                default:
                    {
                        Result.Text = "Null";
                        break;
                    }
            }
            Result.Text = Math.Round(num, 6).ToString();
        }

        private void Lenght_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Len = null;
        }
    }
}
