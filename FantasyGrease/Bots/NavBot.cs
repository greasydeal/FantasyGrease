using FantasyGrease.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGrease.Bots
{
	class NavBot : Bot
	{
		static bool isRunning;

		public NavBot()
		{
			
		}

		private float[] CurrentWayPoint => new float[] { player.X, player.Y, player.Z };

	}
}
