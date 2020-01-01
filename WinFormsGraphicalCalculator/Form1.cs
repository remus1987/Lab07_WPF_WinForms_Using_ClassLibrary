using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab07_WPF_CalculatorApp_Using_ClassLibrary;

namespace WinFormsGraphicalCalculator
{
    public partial class Form1 : Form

    {
        Calculator calc = new Calculator();
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(txtfirstNumber.Text);
            int num2 = Int32.Parse(txtsecondNumber.Text);
            int result = 0;
            if (operation == "+")
            {
                result = calc.Add(num1, num2);
            }
            if (operation == "-")
            {
                result = calc.Subtract(num1, num2);
            }
            if (operation == "*")
            {
                result = calc.Multiply(num1, num2);
            }
            if (operation == "/")
            {
                result = calc.Divide(num1, num2);
            }

            outputTxtBox.Text = result.ToString();

        }
        private void CalculateOperationButton(Object o, EventArgs ev)
        {
            Button Opsbtn = (Button)o;
            operation = Opsbtn.Text;
        }
        // event handler for all the buttons to be triggered
        //the object will be that button that will trigger the event
        private void GetUserButtonValue(Object o, EventArgs args)
        {
            //MessageBox.Show(btn.Text);
            Button btn = (Button)o;

            if (txtfirstNumber.Text == "")
            {
                txtfirstNumber.Text = btn.Text;
            }
            else if (txtsecondNumber.Text == "")
            {
                txtsecondNumber.Text = btn.Text;
            }

        }
        private void clearBtnClick(Object sender, EventArgs args)
        {
            txtfirstNumber.Text = "";
            txtsecondNumber.Text = "";
            outputTxtBox.Text = "";

        }
    }
}
