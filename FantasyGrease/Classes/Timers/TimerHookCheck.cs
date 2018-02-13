using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using FantasyGrease.ViewModels;
using EliteMMO.API;


namespace FantasyGrease.Classes.Timers
{
	public class TimerHookCheck
	{
		App app = App.Current as App;
		MainWindowViewModel mainWindowViewModel;
		EliteAPI apiHook;

		public void Start(MainWindowViewModel model)
		{
			mainWindowViewModel = model;
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
				mainWindowViewModel.Hooked();
			}
		}
	}
}
