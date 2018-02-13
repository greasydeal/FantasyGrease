using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using FantasyGrease.Models;
using FantasyGrease.Views;
using EliteMMO.API;

namespace FantasyGrease.ViewModels
{
    public class MainWindowViewModel
	{
		MainWindow mainWindow = App.Current.Windows[0] as MainWindow;
		EliteAPI apiHook;

		public void Hooked()
		{
			mainWindow.hookChar_Button.Background = Brushes.LawnGreen;
			mainWindow.hookChar_Button.Content = apiHook.Player.Name.ToString();
		}
    }
}
