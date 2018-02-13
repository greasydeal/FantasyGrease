using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using FantasyGrease.ViewModels;

namespace FantasyGrease.Models
{
	public class MainWindowModel : INotifyPropertyChanged
	{
		private string windowTitle;
		public string WindowTitle
		{
			get { return windowTitle; }
			set
			{
				windowTitle = value;
				OnPropertyChanged("windowTitle");
			}
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
