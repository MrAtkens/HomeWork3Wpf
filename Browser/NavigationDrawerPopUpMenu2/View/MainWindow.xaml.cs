using System;
using System.Windows;

namespace BrowserOnWpf
{


	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();

		}

		private void ButtonSearchClick(object sender, RoutedEventArgs e)
		{
			browserWindow.Navigate(new Uri("http://" + selectSite.Text));
		}

		private void MinimazeClick(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void MaximazeClick(object sender, RoutedEventArgs e)
		{
			if (WindowState == WindowState.Normal)
			{
				WindowState = WindowState.Maximized;
			}
			else if (WindowState == WindowState.Maximized)
			{
				WindowState = WindowState.Normal;
			}
		}

		private void ExitClick(object sender, RoutedEventArgs e)
		{
			System.Windows.Application.Current.Shutdown();
		}

		private void WindowDragMove(object sender, System.Windows.Input.MouseButtonEventArgs e)
		{
			DragMove();
		}
	}

}

