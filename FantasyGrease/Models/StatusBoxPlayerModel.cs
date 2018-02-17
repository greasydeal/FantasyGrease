using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Threading;
using EliteMMO.API;
using FantasyGrease.ViewModels;
using System.Windows;


namespace FantasyGrease.Models
{
    public class StatusBoxPlayerModel
    {
        
        private App app = App.Current as App;
        EliteAPI apiHook;
		StatusBoxPlayerViewModel viewModel;

		public StatusBoxPlayerModel(StatusBoxPlayerViewModel vm)
		{
			viewModel = vm;
		}

		/// <summary>
		/// Variables
		/// </summary>
		#region Variables Region
		private string _hp;
        public string Hp
        {
            get
			{ return _hp; }
            set
            {
				_hp = value;
            }
        }

        private string _mp;
        public string Mp
        {
            get { return _mp; }
            set
            {
                _mp = value;
            }
        }

        private string _job;
        public string Job
        {
            get { return _job; }
            set
            {
                _job = value;
            }
        }

        private string _zone;
        public string Zone
        {
            get { return _zone; }
            set
            {
                _zone = value;
            }
        }

        private string _posX;
        public string PosX
        {
            get { return _posX; }
            set
            {
                _posX = value;
            }
        }

        private string _posY;
        public string PosY
        {
            get { return _posY; }
            set
            {
                _posY = value;
            }
        }

        private string _posZ;
        public string PosZ
        {
            get { return _posZ; }
            set
            {
                _posZ = value;
            }
        }

        private string _target;
        public string Target
        {
            get { return _target; }
            set
            {
				_target = value;
            }
        }

		private string _action;
		public string Action
		{
			get { return _action; }
			set
			{
				_action = value;
			}
		}
		#endregion

		/// <summary>
		/// Init Model
		/// </summary>
		public StatusBoxPlayerModel()
        {

        }

		/// Update status values - Pulls from API
        public void Update()
        {
			if (apiHook == null)
			{
				apiHook = app.mainHook.apiHook;
			}

			if (apiHook != null)
			{
				Hp = apiHook.Player.HP.ToString();
				Mp = apiHook.Player.MP.ToString();
				Job = apiHook.Player.MainJob.ToString();
				Zone = apiHook.Player.ZoneId.ToString();
				PosX = apiHook.Player.X.ToString();
				PosY = apiHook.Player.Y.ToString();
				PosZ = apiHook.Player.Z.ToString();
				Target = apiHook.Target.GetTargetInfo().TargetName;
				Action = "N/A";
			}
		}

		/// <summary>
		/// Logic for UI update on value change
		/// </summary>
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
