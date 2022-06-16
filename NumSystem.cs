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
    public partial class NumSystem : Form
    {
        public NumSystem()
        {
            InitializeComponent();
        }

        private void NumSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.NumSys = null;
        }
        //public static string BINtoDEC(string bin)
        //{
        //    int result = 0;
        //    for (int i = bin.Length; i > 0; i--)
        //        if (bin.Substring(i - 1, 1) == "1")
        //            result += (int)Math.Pow(2, (bin.Length - i));
        //    return result.ToString();
        //}
        public static int BINtoDEC(string input)
        {
            if(!input.Any(ch => ch < '0' || ch > '1'))
            {
                return Convert.ToInt32(input, 2);
            }
            else
            {
                return 0;
            }
                       
        }
        public static int OCTtoDEC(string input)
        {
            if (!input.Any(ch => ch < '0' || ch > '7'))
            {
                return Convert.ToInt32(input, 8);
            }
            else
            {
                return 0;
            }        
        }
        public static int HEXtoDEC(string input)
        {
            bool isHex;
            foreach (var ch in input)
            {
                isHex = ((ch >= '0' && ch <= '9') ||
                         (ch >= 'a' && ch <= 'f') ||
                         (ch >= 'A' && ch <= 'F'));

                if (!isHex)
                    return 0;
            }
       
             return Convert.ToInt32(input, 16);
           
        }
        public static int DEC(string input)
        {
            if (!input.Any(ch => ch < '0' || ch > '9'))
            {
                return Convert.ToInt32(input);
            }
            else
            {
                return 0;
            }
        }
        private void Convert_button_Click(object sender, EventArgs e)
        {
            string from = comboBox1.Text;
            string to = comboBox2.Text;
            string Base = textBox1.Text;
            switch (from)
            {
                case "BIN":
                    {
                        switch (to)
                        {

                            case "BIN": { break; }
                            case "OCT": { Base = Convert.ToString(BINtoDEC(textBox1.Text), 8); break; }
                            case "DEC": { Base = Convert.ToString(BINtoDEC(textBox1.Text)); break; }
                            case "HEX": { Base = Convert.ToString(BINtoDEC(textBox1.Text), 16); break; }
                            default: { Base = "e"; break; }
                        }
                        break;
                    }
                case "OCT":
                    {
                        switch (to)
                        {
                            case "BIN": { Base = Convert.ToString(OCTtoDEC(textBox1.Text), 2); break; }
                            case "OCT": { break; }
                            case "DEC": { Base = Convert.ToString(OCTtoDEC(textBox1.Text)); break; }
                            case "HEX": { Base = Convert.ToString(OCTtoDEC(textBox1.Text), 16); break; }

                        }
                        break;
                    }
                case "DEC":
                    {
                        switch (to)
                        {
                            case "BIN": { Base = Convert.ToString(DEC(textBox1.Text), 2); break; }
                            case "OCT": { Base = Convert.ToString(DEC(textBox1.Text), 8); break; }
                            case "DEC": { break; }
                            case "HEX": { Base = Convert.ToString(DEC(textBox1.Text), 16); break; }

                        }
                        break;
                    }
                case "HEX":
                    {
                        switch (to)
                        {
                            case "BIN": { Base = Convert.ToString(HEXtoDEC(textBox1.Text), 2); break; }
                            case "OCT": { Base = Convert.ToString(HEXtoDEC(textBox1.Text), 8); break; }
                            case "DEC": { Base = Convert.ToString(HEXtoDEC(textBox1.Text)); break; }
                            case "HEX": { break; }

                        }
                        break;
                    }
                default:
                    {
                        Result.Text = "Null";
                        break;
                    }
            }
            Result.Text = Base;
        }
    }
}
