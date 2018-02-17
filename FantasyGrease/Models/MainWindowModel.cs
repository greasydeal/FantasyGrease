using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using FantasyGrease.ViewModels;

namespace FantasyGrease.Models
{
	public class MainWindowModel
	{
		private string _windowTitle;
		public string WindowTitle
		{
			get { return _windowTitle; }
			set
			{
				_windowTitle = value;
			}
		}
		
	}
}
