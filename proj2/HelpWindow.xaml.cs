///-------------------------------------------------------------------------------------------------
/// <file> HelpWindow.xaml.cs</file>
///
/// <summary> Implements the help window.xaml class</summary>
/// 
/// <author> Jakub Dvorak</author>
/// <date> 14.04.2020 </date>
///-------------------------------------------------------------------------------------------------

using System.Windows;

namespace Calculator___material
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary> Form for viewing the help.</summary>
    ///-------------------------------------------------------------------------------------------------

    public partial class HelpWindow : Window
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary> Default constructor.</summary>
        /// <param name="Left"> Text inicialization for left column in help window.</param>
        /// <param name="Right"> Text inicialization for right column in help window.</param>
        ///-------------------------------------------------------------------------------------------------

        public HelpWindow()
        {
            InitializeComponent();
            Left.Text = "+\n−\n×\n÷\nC\nCE\n!\n^\n√\n%\n";
            Right.Text = "Addition\nSubtraction\nMultiplication\nDivision\nClear just the last digit\nClear everything\nFactorial\nExponentiation\nn-th root (Default: 2)\nModulo\n";
        }
    }
}
