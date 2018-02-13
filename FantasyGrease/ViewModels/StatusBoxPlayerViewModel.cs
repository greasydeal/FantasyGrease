using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyGrease.Models;
using EliteMMO.API;
using System.Windows.Media;

namespace FantasyGrease.ViewModels
{
	public class StatusBoxPlayerViewModel
	{
		//private StatusBoxPlayerModel statusBoxPlayerModel;
		private App app = App.Current as App;
		EliteAPI apiHook;

		public void Update(StatusBoxPlayerModel statusBoxPlayerModel)
		{
			apiHook = app.mainHook.apiHook;
			statusBoxPlayerModel.Hp = apiHook.Player.HP.ToString();
			statusBoxPlayerModel.Mp = apiHook.Player.MP.ToString();
		}

    }
}
