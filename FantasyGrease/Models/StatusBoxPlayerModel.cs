using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyGrease.ViewModels;
using FantasyGrease.Classes.Timers;

namespace FantasyGrease.Models
{
	public class StatusBoxPlayerModel : INotifyPropertyChanged
	{
		//StatusBoxPlayerViewModel statusBoxPlayerModelView;
		public TimerStatusBoxPlayer timerStatusBox;

		public StatusBoxPlayerModel()
		{
			timerStatusBox = new TimerStatusBoxPlayer();
			timerStatusBox.Start(this);
		}

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

        private string mp;
        public string Mp
        {
            get { return mp; }
            set
            {
                mp = value;
                OnPropertyChanged("mp");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			if(PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
