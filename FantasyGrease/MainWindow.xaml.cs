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
using System.Diagnostics;
using FantasyGrease.Models;
using FantasyGrease.Views;
using EliteMMO.API;

namespace FantasyGrease
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		EliteAPI apiHook = null;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left) this.DragMove();
		}

		private void hookChar_Button_Click(object sender, RoutedEventArgs e)
		{
			if (apiHook == null)
			{
				HookView hookView = new HookView();
				hookView.Show();
				this.IsEnabled = false;
			}
		}
	}
}
