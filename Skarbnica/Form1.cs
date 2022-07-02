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
        public Scarbnica_Game game;
        List<Label> lbls;
        List<Panel> panels;
        public Form1()
        {
            InitializeComponent();

            panels = new List<Panel>() { pnl1, pnl2, pnl3, pnl4 };

            List<Player> players = new List<Player>();


            var playerForm = new PlayerCreator();
            playerForm.ShowDialog();
            for (int i = 0; i < playerForm.Names.Count; i++)
            {
                var name = playerForm.Names[i];
                players.Add(new Player(name, new GraphicCardSet(panels[i])));
            }

            lbls = new List<Label>() { lp1, lp2, lp3, lp4 };

            game = new Scarbnica_Game(players, showState, requestPlayer);


            game.Deck = new GraphicCardSet(pnlDeck); 
            game.Prepare();
            game.Deal();

        }

        private Player requestPlayer()
        {
            RequestPlayer form = new RequestPlayer(game);
            form.ShowDialog();
            return form.ChoosedPlayer;
        }

        private void showState()
        {
            for (int i = 0; i < game.Players.Count; i++)
            {
                if (game.Players[i] == game.beenasked)
                    lbls[i].ForeColor = Color.Red;
                else
                    lbls[i].ForeColor = Color.Black;
            }

            lres.Text = game.ResultInfo;

            pnlFigure.Enabled = game.GameMode == Scarbnica_Game.Mode.AskingFigure;
            pnlNumber.Enabled = game.GameMode == Scarbnica_Game.Mode.AskingNumber;
            pnlSuite.Enabled = game.GameMode == Scarbnica_Game.Mode.AskingSuite;

            ((GraphicCardSet)game.Deck).HideCards();
            foreach (var player in game.Players)
            {
                if (player == game.Asker)
                    ((GraphicCardSet)player.Hand).ShowCards();
                else
                    ((GraphicCardSet)player.Hand).HideCards();
            }

            for (int i = 0; i < game.Players.Count; i++)
            {
                lbls[i].Text = $"{game.Players[i].Name}: {game.Players[i].NumofBox}";
            }

        }

        private void ForFigure_Click(object sender, EventArgs e)
        {
            var b = (Button)sender;

            foreach (CardFigure figure in Enum.GetValues(typeof(CardFigure)))
            {
                if (b.Text == figure.ToString())
                    game.CheckIfFigureFits(figure);
            }
        }

        private void ForNumber_Click(object sender, EventArgs e)
        {
            int activenumber = 0;
            var b1 = (Button)sender;
            if (b1.Text == "One")
                activenumber = 1;
            if (b1.Text == "Two")
                activenumber = 2;
            if (b1.Text == "Three")
                activenumber = 3;
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

            game.CheckIfSuitesFits(activesuites);

            checkDiamond.Checked = false;
            checkClub.Checked = false;
            checkSpade.Checked = false;
            checkHeart.Checked = false;
            //посбрасывать
        }
    }
}
