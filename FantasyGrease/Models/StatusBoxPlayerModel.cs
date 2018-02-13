using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using EliteMMO.API;
using FantasyGrease.ViewModels;
using System.Windows;


namespace FantasyGrease.Models
{
    public class StatusBoxPlayerModel : INotifyPropertyChanged
    {
        //StatusBoxPlayerViewModel statusBoxPlayerModelView;
        private App app = App.Current as App;
        EliteAPI apiHook;

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

        private string job;
        public string Job
        {
            get { return job; }
            set
            {
                job = value;
                OnPropertyChanged("job");
            }
        }

        private string zone;
        public string Zone
        {
            get { return zone; }
            set
            {
                zone = value;
                OnPropertyChanged("zone");
            }
        }

        private string posX;
        public string PosX
        {
            get { return posX; }
            set
            {
                posX = value;
                OnPropertyChanged("posX");
            }
        }

        private string posY;
        public string PosY
        {
            get { return posY; }
            set
            {
                posY = value;
                OnPropertyChanged("posY");
            }
        }

        private string posZ;
        public string PosZ
        {
            get { return posZ; }
            set
            {
                posZ = value;
                OnPropertyChanged("posZ");
            }
        }

        private string targetInfo;
        public string TargetInfo
        {
            get { return zone; }
            set
            {
                targetInfo = value;
                OnPropertyChanged("targetInfo");
            }
        }

        public StatusBoxPlayerModel()
        {

            this.hp = "N/A";
            this.mp = "N/A";
            this.job = "N/A";
            this.zone = "N/A";
            this.posX = "N/A";
            this.posY = "N/A";
            this.posZ = "N/A";
            this.targetInfo = "N/A";

            UpdateTimerStart();
          
        }

        private bool timerStart = false;
        public bool TimerStart
        {
            get { return timerStart; }
            set
            {
                timerStart = value;
                UpdateTimerStart();
            }
        }

        public void UpdateTimerStart()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            apiHook = app.mainHook.apiHook;
            if (apiHook != null)
            {
                Update();
            }
        }

        private void Update()
        {
            apiHook = app.mainHook.apiHook;
            Hp = apiHook.Player.HP.ToString();
            Mp = apiHook.Player.MP.ToString();
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
