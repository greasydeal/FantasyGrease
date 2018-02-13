using System;
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
        private HookViewModel hookViewModel;
		private App app = App.Current as App;

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
				app.mainHook.SetHook(instance);
				hookViewModel.CloseWindow();
			}
			catch
			{
				hookViewModel.HookFailed();
			}
		}
	}
}
