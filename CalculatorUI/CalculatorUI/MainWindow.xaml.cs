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

namespace CalculatorUI
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void NumberOrOperationButtonClick(object sender, RoutedEventArgs e)
		{
				Button bufferButton = (Button)sender;
				outPutField.Text += bufferButton.Content.ToString();
		}

		private void EquallyClick(object sender, RoutedEventArgs e)
		{
			try
			{
				result();
			}
			catch (Exception exc)
			{
				outPutField.Text = "Error!";
			}
		}

		private void result()
		{
			String oprationString;
			int operation = 0;
			if (outPutField.Text.Contains("+"))
			{
				operation = outPutField.Text.IndexOf("+");
			}
			else if (outPutField.Text.Contains("-"))
			{
				operation = outPutField.Text.IndexOf("-");
			}
			else if (outPutField.Text.Contains("X"))
			{
				operation = outPutField.Text.IndexOf("X");
			}
			else if (outPutField.Text.Contains("/"))
			{
				operation = outPutField.Text.IndexOf("/");
			}
			else if (outPutField.Text.Contains("√"))
			{
				operation = outPutField.Text.IndexOf("√");
			}
			else if (outPutField.Text.Contains("%"))
			{
				operation = outPutField.Text.IndexOf("%");
			}
			else
			{
				//error    
			}

			oprationString = outPutField.Text.Substring(operation, 1);
			double op1 = Convert.ToDouble(outPutField.Text.Substring(0, operation));
			double op2 = Convert.ToDouble(outPutField.Text.Substring(operation + 1, outPutField.Text.Length - operation - 1));

			if (oprationString == "+")
			{
				outPutField.Text += "=" + (op1 + op2);
			}
			else if (oprationString == "-")
			{
				outPutField.Text += "=" + (op1 - op2);
			}
			else if (oprationString == "X")
			{
				outPutField.Text += "=" + (op1 * op2);
			}
			else if (oprationString == "/")
			{
				outPutField.Text += "=" + (op1 / op2);
			}
			else if (oprationString == "%")
			{
				outPutField.Text += "=" + (op1 * op2/100);
			}
			else if (oprationString == "√")
			{
				outPutField.Text += "=" + (Math.Sqrt(op1));
			}
		}

		private void ButtonDeleteAllClick(object sender, RoutedEventArgs e)
		{
			outPutField.Text = "";
		}

		private void ButtonDeleteClick(object sender, RoutedEventArgs e)
		{
			if (outPutField.Text.Length > 0)
			{
				outPutField.Text = outPutField.Text.Substring(0, outPutField.Text.Length - 1);
			}
		}

	}
}
