using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyGrease.ViewModels;

namespace FantasyGrease.Models
{
	public class StatusBoxPlayerModel : INotifyPropertyChanged
	{
        StatusBoxPlayerModelView statusBoxPlayerModelView = new StatusBoxPlayerModelView();

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

		public StatusBoxPlayerModel()
		{
			statusBoxPlayerModelView.StatusBoxHandshake(this);
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
