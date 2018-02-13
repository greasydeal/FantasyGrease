using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyGrease.Models;
using EliteMMO.API;
using System.Windows.Media;
using System.Windows.Threading;

namespace FantasyGrease.ViewModels
{
	public class StatusBoxPlayerViewModel
	{
		StatusBoxPlayerModel statusBoxPlayerModel = new StatusBoxPlayerModel();
        private App app = App.Current as App;
		EliteAPI apiHook;
/*
		private void Update()
		{
			apiHook = app.mainHook.apiHook;
			statusBoxPlayerModel.Hp = apiHook.Player.HP.ToString();
			statusBoxPlayerModel.Mp = apiHook.Player.MP.ToString();
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
                //Update();
            }
        }

    */

    }
}
