using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Threading;
using FantasyGrease.Models;
using FantasyGrease.ViewModels;
using EliteMMO.API;
using System.Windows;

namespace FantasyGrease.Classes.Timers
{
    public class TimerStatusBoxPlayer
    {
		StatusBoxPlayerModel playerStatusBox;
		StatusBoxPlayerViewModel statusBoxPlayerViewModel = new StatusBoxPlayerViewModel();
		App app = App.Current as App;
		EliteAPI apiHook;

		public void Start(StatusBoxPlayerModel model)
		{
			playerStatusBox = model;
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
				statusBoxPlayerViewModel.Update(playerStatusBox);
			}
		}
	}
}
