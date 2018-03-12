using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteMMO.API;

namespace FantasyGrease.Classes
{
	class Player
	{
		static public EliteAPI apiHook;

		// Constructor
		public Player()
		{

		}

		// Constructor with API Hook overload
		public Player(EliteAPI instance)
		{
			apiHook = instance;
		}

		// Name - Returns player name
		public string Name => apiHook.Player.Name;

		// Hp - Returns player HP (uint)
		public uint HP => apiHook.Player.HP;

		// HpMax - Returns player max HP (uint)
		public uint HPMax => apiHook.Player.HPMax;

		// HPP - Returns players current hp precentage (uint)
		public uint HPP => apiHook.Player.HPP;

		// Mp - Returns player MP (uint)
		public uint MP => apiHook.Player.MP;

		// MpMax - Returns player max MP (uint)
		public uint MPMax => apiHook.Player.MPMax;

		// MPP - Returns players current mp precentage (uint)
		public uint MPP => apiHook.Player.MPP;

		// Main Job Name - Returns main job name (string)
		public string MainJobName
		{
			get
			{ 
				Jobs jobs = new Jobs();
				return jobs.NameById(MainJobId);
			}
		}

		// Main Job Id - Returns main job id (byte)
		public byte MainJobId => apiHook.Player.MainJob;

		// Main Job Level - Returns main job level (byte)
		public byte MainJobLevel => apiHook.Player.MainJobLevel;

		// Sub Job Name - Returns sub job name (string)
		public string SubJobName
		{
			get
			{
				Jobs jobs = new Jobs();
				return jobs.NameById(SubJobId);
			}
		}

		// Sub Job Id - Returns sub job id (byte)
		public byte SubJobId => apiHook.Player.SubJob;

		// Sub Job Level - Reutrns sub job level (byte)
		public byte SubJobLevel => apiHook.Player.SubJobLevel;

		// Zone Id - Returns current zone id (int)
		public int ZoneId => apiHook.Player.ZoneId;

		// Pos X - Returns current X location (float)
		public float X => apiHook.Player.X;

		// Pos Y - Returns current Y location (float)
		public float Y => apiHook.Player.Y;

		// Pos Z - Returns current Z location (float)
		public float Z => apiHook.Player.Z;

		// Rot - Returns current roation
		public float Rot => apiHook.Player.H;

		// Target Id - Returns Id of the current target
		public uint TargetId => apiHook.Target.GetTargetInfo().TargetId;

		// Target Index - Returns index of the current target
		public uint TargetIndex => apiHook.Target.GetTargetInfo().TargetIndex;


		// Target Name - Returns name of the current target
		public string TargetName => apiHook.Target.GetTargetInfo().TargetName;

		// Set Rotation - Sets player's rotation
		public void SetRotation(float rot) => apiHook.Player.H = rot;

	}
}
