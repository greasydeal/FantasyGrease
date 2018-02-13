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

        private string hp = "N/A";
        public string Hp
        {
            get { return hp; }
            set
            {
                hp = value;
                OnPropertyChanged("hp");
            }
        }

        private string mp = "N/A";
        public string Mp
        {
            get { return mp; }
            set
            {
                mp = value;
                OnPropertyChanged("mp");
            }
        }

        public StatusBoxPlayerModel()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                this.hp = "N/A";
                this.mp = "N/A";
            }
            else
            {
                UpdateTimerStart();
            }
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
