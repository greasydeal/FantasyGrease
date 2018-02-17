using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Media;
using FantasyGrease.Models;
using FantasyGrease.Views;

namespace FantasyGrease.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
	{

		private string _windowTitle;
		public string WindowTitle
		{
			get { return _windowTitle; }

			set
			{
				_windowTitle = value;
				OnPropertyChanged("windowTitle");
			}
		}

		public MainWindowViewModel()
		{
			this.WindowTitle = "FantasyGrease";
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
