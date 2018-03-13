using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyGrease.Models.Bots;

namespace FantasyGrease.ViewModels
{
    class UnityViewModel : INotifyPropertyChanged
	{

		public bool isRunning;

		public string Status { get { return "Not running."; } set { } }

		public UnityViewModel()
		{
			isRunning = false;
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
