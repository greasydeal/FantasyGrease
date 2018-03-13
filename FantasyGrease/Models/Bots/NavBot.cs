using FantasyGrease.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGrease.Models.Bots
{
	class NavBot : Bot
	{
		public NavBot()
		{
			isRunning = false;
		}

		private float[] CurrentWayPoint => new float[] { player.X, player.Y, player.Z };
	}
}
