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
        public Scarbnica_Game Game { get; set; }
        public List<Button> buttons = new List<Button>();
        public Player ChoosedPlayer { get; set; }
        public RequestPlayer(Scarbnica_Game game)
        {
            InitializeComponent();
            Game = game;
            for (int i = 0; i < Game.Players.Count; i++)
            {
                Button b = new Button();
                b.Width = 50;
                b.Text = Game.Players[i].Name;
                b.Location = GetLocation(i, Game.Players.Count, new Point(Width / 2, Height / 2));
                b.Click += NeedforRequest_Click;
                buttons.Add(b);
                Controls.Add(b);
                b.Enabled = Game.Asker != Game.Players[i];
            }

        }

        private Point GetLocation(int num, int count, Point center)
        {
            int r = 50;
            double angle = num * 2 * Math.PI / count - Math.PI / 4;
            return new Point((int)(center.X - 75 + Math.Sin(angle) * r), (int)(center.Y - Math.Cos(angle) * r));
        }

        private void NeedforRequest_Click(object sender, EventArgs e)
        {
            var boba = (Button)sender;
            int num = buttons.IndexOf(boba);
            ChoosedPlayer = Game.Players[num];
            Close();
        }
    }
}
