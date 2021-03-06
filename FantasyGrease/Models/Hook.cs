﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using FantasyGrease;
using FantasyGrease.Views;
using EliteMMO.API;

namespace FantasyGrease.Models
{
	class Hook
	{
		private MainWindow MainWindow = App.Current.Windows[0] as MainWindow;

		public Hook()
		{

		}

		public void HookChar(int procID)
		{
			HookWindow HookWindow = App.Current.Windows[1] as HookWindow;
			EliteAPI instance;

			try
			{
				instance = new EliteAPI(procID);
				MainWindow.CatchAPIHook(instance);
				HookWindow.Close();
			}
			catch
			{
				System.Windows.MessageBox.Show("Unable to hook character.\nAre you running as administrator?");
			}
		}
	}
}
