using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();
            operation_pressed = false;
            Button b = (Button)sender;
            if(b.Text == ",")
            {
                if(!result.Text.Contains(","))
                    result.Text += b.Text;
            }
            else
                result.Text += b.Text;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
            }
            else
            {
                operation = b.Text;
                value = Double.Parse(result.Text);
                operation_pressed = true;
            }
        }

        private void equal_click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "√":
                    result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
                    break;
                case "^2":
                    result.Text = Math.Pow(Double.Parse(result.Text), 2).ToString();
                    break;
                case "^n":
                    result.Text = Math.Pow(value,Double.Parse(result.Text)).ToString();
                    break;
                case "(-)":
                    result.Text = ((-1)*value).ToString();
                    break;
                case "rad->deg":
                    result.Text = ((value* Math.PI) /180).ToString();
                    break;
                case "sin":
                    result.Text = Math.Sin(value).ToString();
                    break;
                case "cos":
                    result.Text = Math.Cos(value).ToString();
                    break;
                case "tan":
                    result.Text = Math.Tan(value).ToString();
                    break;
                default:
                    break;
            }
            value = Double.Parse(result.Text);
            operation = "";
        }

        private void C_Click(object sender, EventArgs e)
        {
            result.Clear();
            value = 0;
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case "ENTER":
                    equal.PerformClick();
                    break;
                case ",":
                    dec.PerformClick();
                    break;
                case ".":
                    dec.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
