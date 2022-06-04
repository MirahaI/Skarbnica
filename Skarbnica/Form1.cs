using GCI;
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
    public partial class Form1 : Form
    {
        Scarbnica_Game game;
        public Form1()
        {
            InitializeComponent();

            List<Player> players = new List<Player>()
            {
                new Player("&&&", new GraphicCardSet(pnl1)) //,  и так далее

            };

            game = new Scarbnica_Game(players, showState);
            game.Prepare();
            game.Deck = new GraphicCardSet(pnlDeck);
            game.Deal();
        }

        private void showState()
        {
            pnlFigure.Enabled = game.GameMode == Scarbnica_Game.Mode.AskingFigure;
            // то же

            foreach (var player in game.Players)
            {
                if (player == game.Asker)
                    ((GraphicCardSet)player.Hand).ShowCards();
                else
                    ((GraphicCardSet)player.Hand).HideCards();
            }

            //написать количество сундуков


        }

        private void bAsk_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bSix_Click_1(object sender, EventArgs e)
        {
            var b = (Button)sender;
            //понять, какая фигура написана на нажатой кнопке и вызвать чекиффигрфитс с этой фигурой
            
        }
    }
}
