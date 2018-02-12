using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGrease.Models
{
	public class StatusBoxPlayerModel : INotifyPropertyChanged
	{

		private MainWindow mainWindow = App.Current.Windows[0] as MainWindow;

		private string hp;
		public string Hp
		{
			get { return hp; }
			set
			{
				hp = value;
				OnPropertyChanged("hp");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public StatusBoxPlayerModel()
		{
			mainWindow.StatusBoxHandshake(this);
		}

		private void OnPropertyChanged(string propertyName)
		{
			if(PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
