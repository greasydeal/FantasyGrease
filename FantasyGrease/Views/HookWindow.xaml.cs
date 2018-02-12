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
		//private HookModel hookModel = new HookModel();
        private HookViewModel hookViewModel;
		//Process[] procCheck = Process.GetProcessesByName("pol");

		/// <summary>
		/// Hook Window Class Startup
		/// </summary>
		public HookWindow()
		{
			InitializeComponent();
            hookViewModel = new HookViewModel(this);

            /*
            var procCheck = Process.GetProcessesByName("pol");
            var procCount = this.procCheck.Count();

			if (procCount != 0)
			{
				foreach (var id in this.procCheck)
				{
					processList.Items.Add(id.MainWindowTitle.ToString());
				}
			}
            */
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

		private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
		{
			if (e.ChangedButton == MouseButton.Left) this.DragMove();
		}

		private void Hook_Button_Click(object sender, RoutedEventArgs e)
		{
            hookViewModel.HookChar();
            /*
            int selectionIndex = ProcessList.SelectedIndex;
			if (selectionIndex >= 0)
			{
				var selectedProcess = this.procCheck.ElementAt(selectionIndex);
				int procId = selectedProcess.Id;
				hookModel.HookChar(procId);
			}
			else { MessageBox.Show("No character selected!"); }
            */
		}

		private void Window_Unloaded(object sender, RoutedEventArgs e)
		{
			Window mainWindow = App.Current.Windows[0];
			mainWindow.IsEnabled = true;
		}
	}
}
