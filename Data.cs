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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void Data_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.Dat = null;
        }

        private void Convert_button_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numericUpDown1.Value);
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            switch (from)
            {
                case "Б":
                    {
                        switch (to)
                        {
                            case "Б": { break; }
                            case "Кб": { num *= 0.000976525; break; }
                            case "Мб": { num *= 9.53674316 * Math.Pow(10, -7); break; }
                            case "Гб": { num *= 9.31322575 * Math.Pow(10, -10); break; }
                            case "Тб": { num *= 9.09494702 * Math.Pow(10, -13); break; }
                            case "Пб": { num *= 8.881842 * Math.Pow(10, -16); break; }
                        }
                        break;
                    }
                case "Кб":
                    {
                        switch (to)
                        {
                            case "Б": { num *= 1024; break; }
                            case "Кб": { break; }
                            case "Мб": { num *= 0.000976525; break; }
                            case "Гб": { num *= 9.53674316 * Math.Pow(10, -7); break; }
                            case "Тб": { num *= 9.31322575 * Math.Pow(10, -10); break; }
                            case "Пб": { num *= 9.09494702 * Math.Pow(10, -13); break; }
                        }
                        break;
                    }
                case "Мб":
                    {
                        switch (to)
                        {
                            case "Б": { num *= 1048576; break; }
                            case "Кб": { num *= 1024; break; }
                            case "Мб": { break; }
                            case "Гб": { num *= 0.000976525; ; break; }
                            case "Тб": { num *= 9.53674316 * Math.Pow(10, -7); break; }
                            case "Пб": { num *= 9.31322575 * Math.Pow(10, -10); break; }
                        }
                        break;
                    }
                case "Гб":
                    {
                        switch (to)
                        {
                            case "Б": { num *= 1.07374182 * Math.Pow(10, 9); break; }
                            case "Кб": { num *= 1048576; break; }
                            case "Мб": { num *= 1024; break; }
                            case "Гб": { break; }
                            case "Тб": { num *= 0.000976525; break; }
                            case "Пб": { num *= 9.53674316 * Math.Pow(10, -7); break; }
                        }
                        break;
                    }
                case "Тб":
                    {
                        switch (to)
                        {
                            case "Б": { num *= 1.09951163 * Math.Pow(10, 12); break; }
                            case "Кб": { num *= 1.07374182 * Math.Pow(10, 9); break; }
                            case "Мб": { num *= 1048576; break; }
                            case "Гб": { num *= 1024; break; }
                            case "Тб": { break; }
                            case "Пб": { num *= 0.000976525; break; }
                        }
                        break;
                    }
                case "Пб":
                    {
                        switch (to)
                        {
                            case "Б": { num *= 1.12589991 * Math.Pow(10, 15); break; }
                            case "Кб": { num *= 1.09951163 * Math.Pow(10, 12); break; }
                            case "Мб": { num *= 1.07374182 * Math.Pow(10, 9); break; }
                            case "Гб": { num *= 1048576; break; }
                            case "Тб": { num *= 1024; break; }
                            case "Пб": { break; }
                        }
                        break;
                    }
                default:
                    {
                        Result.Text = "Null";
                        break;
                    }
            }
            Result.Text = Math.Round(num,3).ToString();
        }

        private void Data_Load(object sender, EventArgs e)
        {

        }
    }
}
