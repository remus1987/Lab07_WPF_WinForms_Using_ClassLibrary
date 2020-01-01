using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lab07_WPF_CalculatorApp_Using_ClassLibrary;

namespace WPF_GraphicalCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calc = new Calculator();
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Event_Calculate_Result
        private void Button_CalculateResult(object sender, EventArgs e)
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
        #endregion

        #region Event_Calculate_Operation_Buttons
        private void CalculateOperationButton(Object o, EventArgs ev)
        {
            Button Opsbtn = (Button)o;
            operation = Opsbtn.Content.ToString();
        }
        #endregion

        #region Event_Get_User_Button_Value
        private void GetUserButtonValue(Object o, EventArgs args)
        {
            //MessageBox.Show(btn.Text);
            Button btn = (Button)o;

            if (txtfirstNumber.Text == "")
            {
                txtfirstNumber.Text = btn.Content.ToString();
            }
            else if (txtsecondNumber.Text == "")
            {
                txtsecondNumber.Text = btn.Content.ToString();
            }

        }
        #endregion

        #region Event_Clear_Button
        private void clearBtnClick(Object sender, EventArgs args)
        {
            txtfirstNumber.Text = "";
            txtsecondNumber.Text = "";
            outputTxtBox.Text = "";

        }
        #endregion

    }
}
