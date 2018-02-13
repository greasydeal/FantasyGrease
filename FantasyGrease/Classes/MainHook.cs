using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteMMO.API;
using System.Windows;

namespace FantasyGrease.Classes
{
    public class MainHook
    {
		public EliteAPI apiHook;

		public void SetHook(EliteAPI instance)
		{
			apiHook = instance;
		}
    }
}
