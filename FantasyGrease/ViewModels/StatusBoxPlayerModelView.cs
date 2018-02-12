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
    class StatusBoxPlayerModelView
    {
        StatusBoxPlayerModel statusBoxPlayer;
        EliteAPI apiHook;

        public void StatusBoxHandshake(StatusBoxPlayerModel passedBox)
        {
            statusBoxPlayer = passedBox;
        }

    }
}
