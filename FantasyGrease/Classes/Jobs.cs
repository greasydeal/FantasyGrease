using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyGrease.Classes
{
	class Jobs
	{
		// Job Name Switch - Takes jobID and returns name - Used in MainJobName()
		public string NameById(byte jobId)
		{
			switch (jobId)
			{
				default:
					return null;

				case 1:
					return "WAR";

				case 2:

					return "MNK";

				case 3:
					return "WHM";

				case 4:
					return "BLM";

				case 5:
					return "RDM";

				case 6:
					return "THF";

				case 7:
					return "PLD";

				case 8:
					return "DRK";

				case 9:
					return "BST";

				case 10:
					return "BRD";

				case 11:
					return "RNG";

				case 12:
					return "SAM";

				case 13:
					return "NIN";

				case 14:
					return "DRG";

				case 15:
					return "SMN";

				case 16:
					return "BLU";

				case 17:
					return "COR";

				case 18:
					return "PUP";

				case 19:
					return "DNC";

				case 20:
					return "SCH";

				case 21:
					return "GEO";

				case 22:
					return "RUN";
			}
		}

	}
}
