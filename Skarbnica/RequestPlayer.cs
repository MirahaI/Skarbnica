using ScarbnichkaLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skarbnica
{
    public partial class RequestPlayer : Form
    {
        public Player ChoosedPlayer { get; set; }
        public RequestPlayer()
        {
            InitializeComponent();
        }

        private void NeedforRequest_Click(object sender, EventArgs e)
        {
            if (Form1.game.Asker == Form1.game.Players[0])
                b1.Enabled = false;
            if (Form1.game.Asker == Form1.game.Players[1])
                b2.Enabled = false;
            if (Form1.game.Asker == Form1.game.Players[2])
                b3.Enabled = false;
            if (Form1.game.Asker == Form1.game.Players[3])
                b4.Enabled = false;

            var boba = (Button)sender;
            if (boba.Name[1] == 1)
                ChoosedPlayer = Form1.game.Players[0];
            if (boba.Name[1] == 2)
                ChoosedPlayer = Form1.game.Players[1];
            if (boba.Name[1] == 3)
                ChoosedPlayer = Form1.game.Players[2];
            if (boba.Name[1] == 4)
                ChoosedPlayer = Form1.game.Players[3];
        }
    }
}
