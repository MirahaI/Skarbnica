using CardsModel;
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
                new Player("Taras", new GraphicCardSet(pnl1)),
                new Player("Mykola", new GraphicCardSet(pnl2)),
                new Player("Ostap", new GraphicCardSet(pnl3)),
                new Player("Lesya", new GraphicCardSet(pnl4))
            };

            game = new Scarbnica_Game(players, showState);
            game.Prepare();
            game.Deck = new GraphicCardSet(pnlDeck);
            game.Deal();

        }

        private void showState()
        {
            lres.Text = game.ResultInfo;

            pnlFigure.Enabled = game.GameMode == Scarbnica_Game.Mode.AskingFigure;
            pnlNumber.Enabled = game.GameMode == Scarbnica_Game.Mode.AskingNumber;
            pnlSuite.Enabled = game.GameMode == Scarbnica_Game.Mode.AskingSuite;

            foreach (var player in game.Players)
            {
                if (player == game.Asker)
                    ((GraphicCardSet)player.Hand).ShowCards();
                else
                    ((GraphicCardSet)player.Hand).HideCards();
            }

            //написать количество сундуков
            lp1.Text = game.Players[0].NumofBox.ToString();
            lp2.Text = game.Players[1].NumofBox.ToString();
            lp3.Text = game.Players[2].NumofBox.ToString();
            lp4.Text = game.Players[3].NumofBox.ToString();


        }

        private void bSix_Click_1(object sender, EventArgs e)
        {
            CardFigure activefigure = new CardFigure();
            var b = (Button)sender;
            foreach (CardFigure figure in Enum.GetValues(typeof(CardFigure)))
            {
                if (b.Name == figure.ToString())
                    activefigure = figure;
            }
            game.CheckIfFigureFits(activefigure);
            //понять, какая фигура написана на нажатой кнопке и вызвать чекиффигрфитс с этой фигурой
        }

        private void lres_Click(object sender, EventArgs e)
        {

        }

        private void bone_Click(object sender, EventArgs e)
        {
            int activenumber = 0;
            var b1 = (Button)sender;
            if (b1.Name == "One")
                activenumber = 1;
            if (b1.Name == "Two")
                activenumber = 2;
            if (b1.Name == "Three")
                activenumber = 3;
            if (b1.Name == "Four")
                activenumber = 4;
            game.CheckIfNumberFits(activenumber);
        }

        private void bAsk_Click(object sender, EventArgs e)
        {
            List<CardSuite> activesuites = new List<CardSuite>();
            if (checkDiamond.Checked == true)
                activesuites.Add(CardSuite.Diamond);
            if (checkClub.Checked == true)
                activesuites.Add(CardSuite.Club);
            if (checkSpade.Checked == true)
                activesuites.Add(CardSuite.Spade);
            if (checkHeart.Checked == true)
                activesuites.Add(CardSuite.Heart);
        }
    }
}
