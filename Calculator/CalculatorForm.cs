using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
         
        bool isDotEntered,
             isZero,
             isCalculated;
        enum OperationCode { ADD, SUBTRACT, MULTIPLY, DIVIDE, NOTHING }
        OperationCode operation;
        decimal lastResult;

        CultureInfo americanNumberStyle = new CultureInfo("en-US");

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            OnClearClick(this, e);
        }

        private void OnDigitClick(object sender, EventArgs e)
        {
            char digitChar = (sender as Button).Text[0];
            if (isZero && !isDotEntered)
            {
                SetToDisplay(digitChar.ToString());
                isZero = ( digitChar == '0' );
            }
            else
            {
                AppendToDisplay(digitChar);
            }
            NoCalculation(sender, e);
        }

        private void OnDotClick(object sender, EventArgs e)
        {
            if (!isDotEntered)
            {
                isDotEntered = true;
                if (isZero) SetToDisplay("0");
                AppendToDisplay('.');
            }
            NoCalculation(sender, e);
        }

        private void OnClearClick(object sender, EventArgs e)
        {
            SetToDisplay("0");
            isDotEntered = false;
            isZero = true;
            lastResult = 0;
            operation = OperationCode.NOTHING;
            NoCalculation(sender, e);
        }

        private void OnOperationClick(object sender, EventArgs e)
        {
            OnCalculationClick(sender, e);
            lastResult = ConvertToDecimal(lblDisplay.Text);
            isZero = true;
            isDotEntered = false;
            switch ((sender as Button).Text[0])
            {
                case '+': operation = OperationCode.ADD; break;
                case '-': operation = OperationCode.SUBTRACT; break;
                case '*': operation = OperationCode.MULTIPLY; break;
                case '/': operation = OperationCode.DIVIDE; break;
            }

        }

        private void OnCalculationClick(object sender, EventArgs e)
        {
            if (isCalculated)
            {
                return;
            }
            isCalculated = true;
            decimal secondOperand = ConvertToDecimal(lblDisplay.Text);
            switch (operation)
            {
                case OperationCode.ADD:
                    lastResult = lastResult + secondOperand;
                    break;
                case OperationCode.SUBTRACT:
                    lastResult = lastResult - secondOperand;
                    break;
                case OperationCode.MULTIPLY:
                    lastResult = lastResult * secondOperand;
                    break;
                case OperationCode.DIVIDE:
                    if (secondOperand == 0)
                    {
                        OnClearClick(this, e);
                        SetToDisplay("ZERO_DIV_ERR");
                        lastResult = 0;
                        return;
                    }
                    lastResult = lastResult / secondOperand;
                    break;
                case OperationCode.NOTHING:
                    lastResult = secondOperand;
                    return;
            }
            try
            {
                string output;
                if (lastResult == Convert.ToInt64(lastResult))
                {
                    isDotEntered = false;
                    output = Convert.ToInt64(lastResult).ToString();
                    
                }
                else
                {
                    isDotEntered = true;
                    output = lastResult.ToString();
                }
                SetToDisplay(output);
                CopyToClipboard(output);
                isZero = lastResult == 0;
            }
            catch
            {
                SetToDisplay("NUM_OVERFLOW");
            }
            finally
            {
                this.btnEquals.DialogResult = DialogResult.OK;
            }
        }
        private void NoCalculation(object sender, EventArgs e)
        {
            isCalculated = false;
        }

        private void CopyToClipboard(string s)
        {
            Clipboard.SetText(s);
        }

        private void SetToDisplay(string s = "0")
        {
            lblDisplay.Text = s;
        }

        private void OnKeyboardCharacterPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled) return;
            var button = (sender as Button);
            var ch = button.Text[0];
            if (ch == e.KeyChar)
            {
                e.Handled = true;
                if ('0' <= ch && ch <= '9')
                {
                    OnDigitClick(button, e);
                }
                else
                {
                    switch (ch)
                    {
                        case '=': OnCalculationClick(button, e); break;
                        case '.': OnDotClick(button, e); break;
                        case '+': case '-': case '*': case '/':OnOperationClick(button, e); break;
                    }
                }
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                OnCalculationClick(button, e);
            }
            if (e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
                OnClearClick(button, e);
            }
        }

        private void OnKeyboardPress(object sender, KeyPressEventArgs e)
        {
            foreach(var btn in tablayoutButtons.Controls)
            {
                OnKeyboardCharacterPress(btn, e);
            }
        }

        private void AppendToDisplay(char s)
        {
            lblDisplay.Text += s;
        }

        private decimal ConvertToDecimal(string number)
        {
            return decimal.TryParse(
                lblDisplay.Text,
                NumberStyles.Any,
                americanNumberStyle,
                out decimal parsed
            ) ? parsed : 0;
        }
    }
}
