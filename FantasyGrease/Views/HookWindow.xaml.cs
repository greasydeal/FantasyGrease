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
using System.Windows.Shapes;
using System.Diagnostics;
using FantasyGrease.Models;
using FantasyGrease.ViewModels;
using EliteMMO.API;

namespace FantasyGrease.Views
{
	/// <summary>
	/// Interaction logic for HookWindow.xaml
	/// </summary>
	public partial class HookWindow : Window
	{

        private HookViewModel viewModel;

		/// <summary>
		/// Hook Window Class Startup
		/// </summary>
		public HookWindow(MainWindow mainWindow)
		{
			InitializeComponent();
            viewModel = new HookViewModel(this, mainWindow);
		}

		/// Add detected POL processes to list on hook window
		public void AddProcess(string procName)
		{
			processList.Items.Add(procName);
		}

		/// No Character is selected when clicking hook
		public void NoCharSelected()
		{
			MessageBox.Show("No character selected!");
		}

		/// API failed to hook after clicking hook
		public void HookFailed()
		{
			MessageBox.Show("Unable to hook character.\nAre you running as administrator?");
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			Window mainWindow = App.Current.Windows[0];
			this.Left = mainWindow.Left + (mainWindow.Width - this.ActualWidth) / 2;
			this.Top = mainWindow.Top + (mainWindow.Height - this.ActualHeight) / 2;
		}

		private void Close_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		public void CloseWindow()
		{
			this.Close();
		}

		private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left) this.DragMove();
		}

		private void Hook_Button_Click(object sender, RoutedEventArgs e)
		{
            viewModel.HookChar();
		}

		private void Window_Unloaded(object sender, RoutedEventArgs e)
		{
			Window mainWindow = App.Current.Windows[0];
			mainWindow.IsEnabled = true;
		}
	}
}
