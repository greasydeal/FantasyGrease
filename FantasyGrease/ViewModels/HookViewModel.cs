using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FantasyGrease.Models;
using FantasyGrease.Views;

namespace FantasyGrease.ViewModels
{
    class HookViewModel
    {

		private MainWindow mainWindow;
        private HookModel hookModel;
        private HookWindow hookWindow;
        private Process[] procCheck;

        public HookViewModel(HookWindow window, MainWindow main)
        {
            hookModel = new HookModel(this);
            hookWindow = window;
			mainWindow = main;

            procCheck = Process.GetProcessesByName("pol");

			var procCount = this.procCheck.Count();

			if (procCount != 0)
			{
				foreach (var id in this.procCheck)
				{
					hookWindow.AddProcess(id.MainWindowTitle.ToString());
				}
			}
		}

        public void HookChar()
        {
            int selectionIndex = hookWindow.processList.SelectedIndex;
            if (selectionIndex >= 0)
            {
                var selectedProcess = procCheck.ElementAt(selectionIndex);
                int procId = selectedProcess.Id;

				if (hookModel.HookChar(procId))
				{
					mainWindow.Hooked(hookModel.GetCharName());
				}
			}
            else { hookWindow.NoCharSelected(); }
            
        }

		public void HookFailed()
		{
			hookWindow.HookFailed();
		}

        public void CloseWindow()
        {
            hookWindow.CloseWindow();
        }
    }
}
