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
using FantasyGrease.Classes;
using System.Windows;


namespace FantasyGrease.Models
{
    public class StatusBoxPlayerModel
    {
		StatusBoxPlayerViewModel viewModel;
		Player player = new Player();

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

		private string _hpMax;
		public string HpMax
		{
			get
			{ return _hpMax; }
			set
			{
				_hpMax = value;
			}
		}

		private string _hpp;
		public string Hpp
		{
			get
			{ return _hpp; }
			set
			{
				_hpp = value;
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

		private string _mpp;
		public string Mpp
		{
			get
			{ return _mpp; }
			set
			{
				_mpp = value;
			}
		}

		private string _mpMax;
		public string MpMax
		{
			get
			{ return _mpMax; }
			set
			{
				_mpMax = value;
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

		private string _targetId;
		public string TargetId
		{
			get { return _targetId; }
			set
			{
				_targetId = value;
			}
		}
		#endregion

		/// <summary>
		/// Init Model
		/// </summary>
		public StatusBoxPlayerModel()
        {
			
		}

		// Update status values - Pulls from API
        public void Update()
        {

			if (Player.apiHook != null)
			{
				Hp = player.HP.ToString();
				HpMax = player.HPMax.ToString();
				Hpp = player.HPP.ToString();
				Mp = player.MP.ToString();
				MpMax = player.MPMax.ToString();
				Mpp = player.MPP.ToString();
				Job = player.MainJobLevel + player.MainJobName + "/" + player.SubJobLevel + player.SubJobName;
				Zone = player.ZoneId.ToString();
				PosX = player.X.ToString();
				PosY = player.Y.ToString();
				PosZ = player.Z.ToString();
				Target = player.TargetName;
				TargetId = player.TargetId.ToString();
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
