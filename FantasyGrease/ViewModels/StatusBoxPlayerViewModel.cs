using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyGrease.Models;
using EliteMMO.API;
using System.Windows.Media;
using System.Windows.Threading;
using System.ComponentModel;
using System.Timers;

namespace FantasyGrease.ViewModels
{
	public class StatusBoxPlayerViewModel : INotifyPropertyChanged
	{
		StatusBoxPlayerModel model;


		/// Init of StatusBoxPlayerViewModel
		public StatusBoxPlayerViewModel()
		{
			model = new StatusBoxPlayerModel(this);
			model.Hp = "N/A";
			model.Mp = "N/A";
			model.Job = "N/A";
			model.Zone = "N/A";
			model.PosX = "N/A";
			model.PosY = "N/A";
			model.PosZ = "N/A";
			model.Target = "N/A";
			model.Action = "N/A"; 

			if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
			{
				UpdateTimerStart();
			}
		}

		#region Status Strings

		private string _hp;
		public string Hp
		{
			get { return _hp; }
			set
			{
				_hp = value;
				OnPropertyChanged("hp");
			}
		}

		private string _mp;
		public string Mp
		{
			get { return _mp; }
			set
			{
				_mp = value;
				OnPropertyChanged("mp");
			}
		}

		private string _job;
		public string Job
		{
			get { return _job; }
			set
			{
				_job = value;
				OnPropertyChanged("job");
			}
		}

		private string _zone;
		public string Zone
		{
			get { return _zone; }
			set
			{
				_zone = value;
				OnPropertyChanged("zone");
			}
		}

		private string _posX;
		public string PosX
		{
			get { return _posX; }
			set
			{
				_posX = value;
				OnPropertyChanged("posX");
			}
		}

		private string _posY;
		public string PosY
		{
			get { return _posY; }
			set
			{
				_posY = value;
				OnPropertyChanged("posY");
			}
		}

		private string _posZ;
		public string PosZ
		{
			get { return _posZ; }
			set
			{
				_posZ = value;
				OnPropertyChanged("posZ");
			}
		}

		private string _target;
		public string Target
		{
			get { return _target; }
			set
			{
				_target = value;
				OnPropertyChanged("target");
			}
		}

		private string _action;
		public string Action
		{
			get { return _action; }
			set
			{
				_action = value;
				OnPropertyChanged("action");
			}
		}

		#endregion

		/// Timer to status update
		public void UpdateTimerStart()
		{
			Timer timer = new Timer();
			timer.Interval = 300;
			timer.Elapsed += UpdateTick;
			timer.Start();
		}

		/// Tick for update timer - Updates values with data from model
		private void UpdateTick(object sender, EventArgs e)
		{
			model.Update();
			this.Hp = model.Hp;
			this.Mp = model.Mp;
			this.Job = model.Job;
			this.Zone = model.Zone;
			this.PosX = model.PosX;
			this.PosY = model.PosY;
			this.PosZ = model.PosZ;
			this.Target = model.Target;
			this.Action = model.Action;
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
