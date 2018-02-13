using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using FantasyGrease.Models;
using FantasyGrease.ViewModels;
using FantasyGrease.Views;
using EliteMMO.API;

namespace FantasyGrease.ViewModels
{
    class HookViewModel
    {

        private EliteAPI apiHook;
        private HookModel hookModel;
        private HookView hookView;
        private Process[] procCheck;

        public HookViewModel(HookView window)
        {
            hookModel = new HookModel(this);
            hookView = window;
            procCheck = Process.GetProcessesByName("pol");

			var procCount = this.procCheck.Count();

			if (procCount != 0)
			{
				foreach (var id in this.procCheck)
				{
					window.processList.Items.Add(id.MainWindowTitle.ToString());
				}
			}
		}

        public void CatchAPIHook(EliteAPI core)
        {

            apiHook = core;
            MessageBox.Show("Hook successful to " + apiHook.Player.Name.ToString());
           /* mainWindow.titleText.Text = apiHook.Player.Name.ToString() + " - FantasyGrease";
            mainWindow.Title = apiHook.Player.Name.ToString() + " - FantasyGrease";
            mainWindow.hookChar_Button.Background = Brushes.LawnGreen;
            mainWindow.hookChar_Button.Content = apiHook.Player.Name.ToString();
            statusBoxPlayer.Hp = apiHook.Player.HP.ToString();
            statusBoxPlayer.Mp = apiHook.Player.MP.ToString(); */

        }

        public void HookChar()
        {
            //var procCheck = Process.GetProcessesByName("pol");
            int selectionIndex = hookView.processList.SelectedIndex;
            if (selectionIndex >= 0)
            {
                var selectedProcess = procCheck.ElementAt(selectionIndex);
                int procId = selectedProcess.Id;
                hookModel.HookChar(procId);
            }
            else { MessageBox.Show("No character selected!"); }
            
        }

		public void HookFailed()
		{
			System.Windows.MessageBox.Show("Unable to hook character.\nAre you running as administrator?");
		}

        public void CloseWindow()
        {
            hookView.Close();
        }
    }
}
