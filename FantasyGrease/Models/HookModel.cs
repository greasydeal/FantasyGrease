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
		EliteAPI apiHook;

		public HookModel(HookViewModel viewModel)
		{
            hookViewModel = viewModel;
		}

		public bool HookChar(int procID)
		{
			try
			{
				apiHook = new EliteAPI(procID);
				app.mainHook.SetHook(apiHook);
				hookViewModel.CloseWindow();
				return true;
			}
			catch
			{
				hookViewModel.HookFailed();
				return false;
			}
		}

		public string GetCharName()
		{
			return apiHook.Player.Name.ToString();
		}

	}
}
