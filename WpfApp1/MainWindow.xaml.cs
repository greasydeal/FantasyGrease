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
		StatusBoxPlayer statusBoxPlayer;

		public MainWindow()
		{
			InitializeComponent();
		}

		public void CatchAPIHook(EliteAPI core)
		{

			apiHook = core;
			this.titleText.Text = apiHook.Player.Name.ToString() + " - FantasyGrease";
			this.Title = apiHook.Player.Name.ToString() + " - FantasyGrease";
			this.hookChar_Button.Background = Brushes.LawnGreen;
			this.hookChar_Button.Content = apiHook.Player.Name.ToString();
			statusBoxPlayer.Hp = apiHook.Player.HP.ToString();

		}

		public void StatusBoxHandshake(StatusBoxPlayer passedBox)
		{
			statusBoxPlayer = passedBox;
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
				HookWindow hookWindow = new HookWindow();
				hookWindow.Show();
				this.IsEnabled = false;
			}
		}
	}
}
