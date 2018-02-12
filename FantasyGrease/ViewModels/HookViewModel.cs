using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using FantasyGrease.ViewModels;
using EliteMMO.API;

namespace FantasyGrease.ViewModels
{
    class HookViewModel
    {

        EliteAPI apiHook;
        MainWindow mainWindow = App.Current.Windows[0] as MainWindow;

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
    }
}
