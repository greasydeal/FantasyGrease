﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using FantasyGrease;
using FantasyGrease.ViewModels;
using EliteMMO.API;

namespace FantasyGrease.Models
{
	class HookModel
	{
        //private MainWindow MainWindow = App.Current.Windows[0] as MainWindow;
        private HookViewModel hookViewModel;

		public HookModel(HookViewModel viewModel)
		{
            hookViewModel = viewModel;
		}

		public void HookChar(int procID)
		{
			EliteAPI instance;

			try
			{
				instance = new EliteAPI(procID);
				hookViewModel.CatchAPIHook(instance);
				hookViewModel.CloseWindow();
			}
			catch
			{
				System.Windows.MessageBox.Show("Unable to hook character.\nAre you running as administrator?");
			}
		}
	}
}
