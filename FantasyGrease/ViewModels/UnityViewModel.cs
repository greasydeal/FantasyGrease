using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGrease.ViewModels
{
    class UnityViewModel : INotifyPropertyChanged
	{
		public bool isRunning;

		public string test
		{
			get { return "test"; }
			set { }
		}

		public UnityViewModel()
		{
			isRunning = false;
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
