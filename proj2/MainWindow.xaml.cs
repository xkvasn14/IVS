///-------------------------------------------------------------------------------------------------
/// <file> MainWindow.xaml.cs.</file>
/// 
/// <summary> Implements the main window.xaml class</summary>
/// 
/// <author> Jakub Dvorak</author>
/// <date> 14.04.2020 </date>
///-------------------------------------------------------------------------------------------------

using System.Windows;
using System.Windows.Input;

namespace Calculator___material
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> The application's main form.</summary>
    ///
    /// ### <author> Jakub Dvorak</author>
    ///
    /// ### <date> 14.04.2020</date>
    ///-------------------------------------------------------------------------------------------------

    public partial class MainWindow : Window
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary> Default variable for number creating.</summary>
        /// ### <param name="number1"> Default variable for number creating.</param>
        ///-------------------------------------------------------------------------------------------------

        private double number1 = 0;

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Default variable for result interpretation.</summary>
        /// ### <param name="number2"> Default variable for result interpretation.</param>
        ///-------------------------------------------------------------------------------------------------

        private double number2 = 0;

        ///-------------------------------------------------------------------------------------------------
        /// <summary> True if is decimal, false if not.</summary>
        /// ### <param name="isDecimal"> True if is decimal, false if not.</param>
        ///-------------------------------------------------------------------------------------------------

        private bool isDecimal = false;

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Number of decimals.</summary>
        /// ### <param name="decimalCount"> Number of decimals.</param>
        ///-------------------------------------------------------------------------------------------------

        private int decimalCount = 0;

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Was number pressed?</summary>
        /// ### <param name="numberPressed"> Used for idetification if the number button was pressed.</param>
        ///-------------------------------------------------------------------------------------------------
        /// 
        private bool numberPressed = false;

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Used for idetification of previous equalization.</summary>
        /// ### <param name="prevEqv"> Used for idetification of previous equalization.</param>
        ///-------------------------------------------------------------------------------------------------

        private string prevEqv;

        /// <summary> The mathematics library.</summary>
        Mathematics.Math Math = new Mathematics.Math();

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Default constructor.</summary>
        ///-------------------------------------------------------------------------------------------------

        public MainWindow()
        {
            InitializeComponent();
            InputBox.Text = "0";
            HistoryBox_Text.Text = "History:";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Number constructor.</summary>
        ///
        /// <param name="number"> Number passed by number buttons.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Number_Ctor(int number)
        {
            if (prevEqv == "eqv")
            {
                number1 = 0;
                prevEqv = default(string);
            }
            if (!isDecimal)
            {
                number1 = number1 * 10 + number;
            }
            else
            {
                decimalCount++;
                number1 = number1 + Math.Pow(10, -decimalCount) * number;
            }
            numberPressed = true;
            string toBePrinted = number1.ToString();
            InputBox.Text = toBePrinted;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "0" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(0);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "1" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(1);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "2" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(2);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "3" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(3);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "4" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(4);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "5" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(5);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "6" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(6);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "7" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(7);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "8" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(8);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "9" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Number_Ctor(9);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Sets variables to default.</summary>
        ///-------------------------------------------------------------------------------------------------

        private void Defaults()
        {
            OutputBox.Text = number2.ToString();
            number1 = default(double);
            decimalCount = 0;
            isDecimal = false;
            numberPressed = false;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Operations chooser.</summary>
        ///
        /// <param name="prevEqv"> The previous equalization.</param>
        ///-------------------------------------------------------------------------------------------------

        private void Operations(string prevEqv)
        {
            switch (prevEqv)
            {
                case "add":
                    number2 = Math.Sum(number2, number1);
                    break;
                case "sub":
                    number2 = Math.Sub(number2, number1);
                    break;
                case "mul":
                    number2 = Math.Mul(number2, number1);
                    break;
                case "div":
                    number2 = Math.Div(number2, number1);
                    break;
                case "pow":
                    number2 = Math.Pow(number2, number1);
                    break;
                case "fac":
                    number2 = Math.Fac(number1);
                    break;
                case "sqrt":
                    number2 = Math.Sqrt(number1, number2);
                    break;
                case "mod":
                    number2 = Math.Mod(number2, number1);
                    break;

                case "eqv":
                    number2 = number1;
                    break;
                default:
                    number2 = number1;
                    break;
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "=" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonEqv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "=";
            switch (prevEqv)
            {
                case "add":
                    number2 = Math.Sum(number2, number1);
                    break;
                case "sub":
                    number2 = Math.Sub(number2, number1);
                    break;
                case "mul":
                    number2 = Math.Mul(number2, number1);
                    break;
                case "div":
                    number2 = Math.Div(number2, number1);
                    break;
                case "pow":
                    number2 = Math.Pow(number2, number1);
                    break;
                case "sqrt":
                    number2 = Math.Sqrt(number1, number2);
                    break;
                case "mod":
                    number2 = Math.Mod(number2, number1);
                    break;


                case "eqv":
                    number2 = number1;
                    break;
                default:
                    break;
            }

            OutputBox.Text = number2.ToString();
            InputBox.Clear();

            HistoryBox.Text = OutputBox.Text + "\n" + HistoryBox.Text;
            
            number1 = number2;
            prevEqv = "eqv";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "CE" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonCE_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            OutputBox.Clear();
            decimalCount = 0;
            SignBox.Clear();
            prevEqv = default(string);
            isDecimal = false;
            InputBox.Text = "0";
            
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "+" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "+";
            if (numberPressed)
            {
                InputBox.Text = "0";
                Operations(prevEqv);
                Defaults();
            }
            prevEqv = "add";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "-" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonSub_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "-";
            if (numberPressed)
            {
                InputBox.Text = "0";
                Operations(prevEqv);
                Defaults();
            }
            prevEqv = "sub";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "×" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "×";
            if (numberPressed)
            {
                InputBox.Text = "0";
                Operations(prevEqv);
                Defaults();
            }
            prevEqv = "mul";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "÷" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///
        /// ### <author> Jakub</author>
        ///
        /// ### <date> 09.04.2020</date>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "÷";
            if (numberPressed)
            {
                InputBox.Text = "0";
                Operations(prevEqv);
                Defaults();
            }
            prevEqv = "div";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "C" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                number1 = number1 / 10;
                number1 = Math.Floor(number1);

                if (decimalCount >= 0)
                {
                    decimalCount = 0;
                    isDecimal = false;
                }
            }
            else
            {
                double numberHelp = number1 * Math.Pow(10, decimalCount);
                numberHelp = numberHelp % 10;
                number1 = number1 - (Math.Pow(10, -(decimalCount)) * numberHelp);
                decimalCount--;
                if (decimalCount <= 0)
                {
                    decimalCount = 0;
                    isDecimal = false;
                }
            }

            string toBePrinted = number1.ToString();
            if (InputBox.Text.Length != 0)
            {
                InputBox.Text = toBePrinted;
            }
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "," click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonDec_Click(object sender, RoutedEventArgs e)
        {
            if (!isDecimal)
            {
                InputBox.AppendText(",");
            }
            isDecimal = true;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "^" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonPow_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "^";
            if (numberPressed)
            {
                InputBox.Text = "0";
                Operations(prevEqv);
                Defaults();
            }
            prevEqv = "pow";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "!" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonFac_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "!"; 
            InputBox.Text = "0";
            prevEqv = "fac";

            Operations(prevEqv);
            Defaults();

            prevEqv = default(string);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "√" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonRoot_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "√";
            if (numberPressed)
            {
                InputBox.Text = "0";
                if (prevEqv == "eqv")
                {
                    number1 = 0;
                }
                Operations(prevEqv);
                Defaults();
            }
            prevEqv = "sqrt";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "%" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonMod_Click(object sender, RoutedEventArgs e)
        {
            SignBox.Text = "%";
            if (numberPressed)
            {
                InputBox.Text = "0";
                Operations(prevEqv);
                Defaults();
            }
            prevEqv = "mod";
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by Keyboard Input.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Key event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            switch (e.Key)
            {
                case Key.NumPad0:
                    
                    Button0_Click(sender, e);
                    break;
                case Key.NumPad1:
                    Button1_Click(sender, e);
                    break;
                case Key.NumPad2:
                    Button2_Click(sender, e);
                    break;
                case Key.NumPad3:
                    Button3_Click(sender, e);
                    break;
                case Key.NumPad4:
                    Button4_Click(sender, e);
                    break;
                case Key.NumPad5:
                    Button5_Click(sender, e);
                    break;
                case Key.NumPad6:
                    Button6_Click(sender, e);
                    break;
                case Key.NumPad7:
                    Button7_Click(sender, e);
                    break;
                case Key.NumPad8:
                    Button8_Click(sender, e);
                    break;
                case Key.NumPad9:
                    Button9_Click(sender, e);
                    break;
                case Key.Back:
                    ButtonC_Click(sender, e);
                    break;
                case Key.Enter:
                    ButtonEqv_Click(sender, e);
                    break;
                case Key.Subtract:
                    ButtonSub_Click(sender, e);
                    break;
                case Key.Add:
                    ButtonAdd_Click(sender, e);
                    break;
                case Key.Multiply:
                    ButtonMul_Click(sender, e);
                    break;
                case Key.Divide:
                    ButtonDiv_Click(sender, e);
                    break;
                case Key.OemComma:
                    ButtonDec_Click(sender, e);
                    break;
                case Key.OemPeriod:
                    ButtonDec_Click(sender, e);
                    break;
                case Key.Decimal:
                    ButtonDec_Click(sender, e);
                    break;
                default:
                    break;
            }

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by "?" click.</summary>
        ///
        /// <param name="sender"> Source of the event.</param>
        /// <param name="e">      Routed event information.</param>
        ///-------------------------------------------------------------------------------------------------

        private void ButtonHelp_Click(object sender, RoutedEventArgs e)
        {

            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();

        }
    }
}
