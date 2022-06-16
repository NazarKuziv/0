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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool isPoint = false; // перевіряє чи кома
        private bool isNum2 = false;  // перевіряє чи це 2 число

        private string num1 = null; // для запису 1 числа
        private string num2 = null; // для запису 2 числа

        private string currentOperation = ""; // для запису операції
        public void AddNum(string txt)
        {
            if (isNum2)
            {
                num2 += txt;
                textResult.Text = num2;
                textResult2.Text = num2;
            }
            else
            {
                num1 += txt;
                textResult.Text = num1;
                textResult2.Text = num1;
            }
        }
        public void SetNum(string txt)
        {
            if (isNum2)
            {
                num2 = txt;
                textResult.Text = num2; // запис в позначку (Label)
                textResult2.Text = num2;
            }
            else
            {
                num1 = txt;
                textResult.Text = num1;
                textResult2.Text = num1;
            }
        }
        private void buttonNumberClick(object obj, EventArgs e)
        {
            var txt = ((Button)obj).Text; // зчитування тексту кнопки і запис у змінну txt
            {
                if (isPoint && txt == ",") { return; }// недопускає запису коми 2 разі підряд
                if (txt == ",") { isPoint = true; }
            }

            if (txt == "+/-")
            {
                if (textResult.Text.Length > 0)
                    if (textResult.Text[0] == '-')
                    {
                        textResult.Text = textResult.Text.Substring(1, textResult.Text.Length - 1);
                    }
                    else
                    {
                        textResult.Text = "-" + textResult.Text;
                    }
                SetNum(textResult.Text);
                return;
            }

            AddNum(txt);
        }

        private void buttonNumberClick2(object obj, EventArgs e)
        {
            var txt = ((Button)obj).Text; // зчитування тексту кнопки і запис у змінну txt
            {
                if (isPoint && txt == ",") { return; }// недопускає запису коми 2 разі підряд
                if (txt == ",") { isPoint = true; }
            }

            if (txt == "+/-")
            {
                if (textResult.Text.Length > 0)
                    if (textResult.Text[0] == '-')
                    {
                        textResult.Text = textResult.Text.Substring(1, textResult.Text.Length - 1);
                    }
                    else
                    {
                        textResult.Text = "-" + textResult.Text;
                    }
                SetNum(textResult.Text);
                return;
            }
            if (txt == "PI")
            {
                textResult2.Text = Convert.ToString(Math.Round(Math.PI, 2));
                SetNum(textResult2.Text);
                return;
            }
            if (txt == "e")
            {
                textResult2.Text = Convert.ToString(Math.Round(Math.E, 2));
                SetNum(textResult2.Text);
                return;
            }

            AddNum(txt);
        }
        private void buttonOperationClick(object obj, EventArgs e)
        {
            if (num1 == null) { if (textResult.Text.Length > 0) num1 = textResult.Text; else return; }

            isNum2 = true;
            currentOperation = ((Button)obj).Text; // зчитування тексту кнопки і запис у змінну
            SetResult(currentOperation);
        }
        private void SetResult(string operation)
        {
            string result = null;
            switch (operation)
            {
                case "+": { result = MathOp.Add(num1, num2); break; }
                case "-": { result = MathOp.Sub(num1, num2); break; }
                case "*": { result = MathOp.Mul(num1, num2); break; }
                case "/": { result = MathOp.Dev(num1, num2); break; }
                case "%": { result = MathOp.Dev(num1, num2); break; }
                case "x^y": { result = MathOp.Pow2(num1, num2); break; }
                case "√x": { result = MathOp.Sqrt(num1); isNum2 = false; break; }
                case "x^2": { result = MathOp.Pow(num1); isNum2 = false; break; }
                case "1/x": { result = MathOp.OneDev(num1); isNum2 = false; break; }
                case "x!": { result = MathOp.Factorial(num1); isNum2 = false; break; }
                case "log": { result = MathOp.Log(num1); isNum2 = false; break; }
                case "ln": { result = MathOp.Ln(num1); isNum2 = false; break; }
                case "10^x": { result = MathOp.Pow10(num1); isNum2 = false; break; }
                case "|x|": { result = MathOp.Abs(num1); isNum2 = false; break; }
                case "e^x": { result = MathOp.PowEx(num1); isNum2 = false; break; }
                case "sin": { result = MathOp.Sin(num1); isNum2 = false; break; }
                case "cos": { result = MathOp.Cos(num1); isNum2 = false; break; }
                case "tan": { result = MathOp.Tan(num1); isNum2 = false; break; }
                case "cot": { result = MathOp.Cot(num1); isNum2 = false; break; }
                default: break;
            }
            OuputResult(result, operation);
            if (isNum2) { if (result != null) num1 = result; } else num1 = null;  
            isPoint = false;
        }
        private void OuputResult(string result, string operation)
        {
            switch (operation)
            {
                case "√x": { if (num1 != null) textHistory.Text = "√" + num1 + " = "; textHistory2.Text = textHistory.Text; break; }
                case "x^2": { if (num1 != null) textHistory.Text = num1 + "^2 = "; textHistory2.Text = textHistory.Text; break; }
                case "x!": { if (num1 != null) textHistory.Text = num1 + "! = "; textHistory2.Text = textHistory.Text; break; }
                case "1/x": { if (num1 != null) textHistory.Text = "1/" + num1 + " = "; textHistory2.Text = textHistory.Text; break; }
                case "log": { if (num1 != null) textHistory2.Text = "log(" + num1 + ") = "; break; }
                case "ln": { if (num1 != null) textHistory2.Text = "ln(" + num1 + ") = "; break; }
                case "10^x": { if (num1 != null) textHistory2.Text = "10^" + num1 + " = "; break; }
                case "e^x": { if (num1 != null) textHistory2.Text = "e^" + num1 + " = "; break; }
                case "|x|": { if (num1 != null) textHistory2.Text = "abs(" + num1 + ") = "; break; }
                case "sin": { if (num1 != null) textHistory2.Text = "sin(" + num1 + ") = "; break; }
                case "cos": { if (num1 != null) textHistory2.Text = "cos(" + num1 + ") = "; break; }
                case "tan": { if (num1 != null) textHistory2.Text = "tan(" + num1 + ") = "; break; }
                case "cot": { if (num1 != null) textHistory2.Text = "cot(" + num1 + ") = "; break; }
                
                default:
                    {
                        if (num2 != null)
                        {
                            if (operation == "x^y")
                            {
                                textHistory2.Text = num1 + "^" + num2 + " = ";
                                break;
                            }
                            else
                            {
                                textHistory.Text = num1 + "" + operation + "" + num2 + " = ";
                                textHistory2.Text = textHistory.Text;
                            }

                        }
                        else if (num1 != null)
                        {
                            if (operation == "x^y")
                            {
                                textHistory2.Text = num1 + "^";                     
                                break;
                            }
                            else
                            {

                                textHistory.Text = num1 + "" + operation + "";
                                textHistory2.Text = textHistory.Text;                                
                                break;
                            }


                        }
                    }
                    break;
            }
            num2 = null;
            if (result != null)
            {
                textResult.Text = result;
                textResult2.Text = result;
            }
        }

        private void buttonClear(object obj, EventArgs e)
        {
            textResult.Text = "";
            textResult2.Text = "";
            textHistory.Text = "0";
            textHistory2.Text = "0";

            isNum2 = false;
            isPoint = false;
            num1 = null;
            num2 = null;
            currentOperation = null;
        }

        private void buttonResultClick(object obj, EventArgs e)
        {
            SetResult(currentOperation);
            isNum2 = false;
            num1 = null;
            num2 = null;

        }

        private void buttonResetNumber(object obj, EventArgs e)
        {
            if (textResult.Text.Length <= 0) { return; } // перевірка чи Label не пропжній
            textResult.Text = textResult.Text.Substring(0, textResult.Text.Length - 1);// видалення останього числа
            SetNum(textResult.Text);
        }
        private void buttonResetNumber2(object obj, EventArgs e)
        {
            if (textResult2.Text.Length <= 0) { return; } // перевірка чи Label не пропжній
            textResult2.Text = textResult2.Text.Substring(0, textResult2.Text.Length - 1);// видалення останього числа
            SetNum(textResult2.Text);
        }

        static public Lenght Len = null;
        private void lenght_button_Click(object sender, EventArgs e)
        {
            if (Len == null)
                Len = new Lenght();
            Len.Show();
            Len.Activate();
        }
        static public Mass Mas = null;
        private void mass_button_Click(object sender, EventArgs e)
        {
            if (Mas == null)
                Mas = new Mass();
            Mas.Show();
            Mas.Activate();
        }
        static public Area Area = null;
        private void area_button_Click(object sender, EventArgs e)
        {
            if (Area == null)
                Area = new Area();
            Area.Show();
            Area.Activate();
        }
        static public Volume Vol = null;
        private void volume_button_Click(object sender, EventArgs e)
        {
            if (Vol == null)
                Vol = new Volume();
            Vol.Show();
            Vol.Activate();
        }
        static public Speed Speed = null;
        private void speed_button_Click(object sender, EventArgs e)
        {
            if (Speed == null)
                Speed = new Speed();
            Speed.Show();
            Speed.Activate();
        }
        static public Temperature T = null;
        private void temperature_button_Click(object sender, EventArgs e)
        {
            if (T == null)
                T = new Temperature();
            T.Show();
            T.Activate();
        }
        static public Data Dat = null;
        private void data_button_Click(object sender, EventArgs e)
        {
            if (Dat == null)
                Dat = new Data();
            Dat.Show();
            Dat.Activate();
        }
        static public NumSystem NumSys = null;
        private void num_system_button_Click(object sender, EventArgs e)
        {
            if (NumSys == null)
                NumSys = new NumSystem();
            NumSys.Show();
            NumSys.Activate();
        }

    }
}
