using CardsModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScarbnichkaLogic
{
    public class Scarbnica_Game
    {
        enum Mode
        {
            AskingFigure,
            //AskingNumber,
            AskingSuite,
        }


        private readonly static Random random = new Random();
        public List<Player> Players { get; set; }
        public CardSet Deck { get; set; }
        public string ResultInfo { get; set; }
        public string StateInfo
        {
            get
            {
                switch (mode)
                {
                    case Mode.AskingFigure:
                        return $"{ActivePlayer.Name} is asking about Figure {beenasked.Name}";  
                    //case Mode.AskingNumber:
                    //    return $"{ActivePlayer.Name} is asking about Number {beenasked.Name}";
                    case Mode.AskingSuite:
                        return $"{ActivePlayer.Name} is asking about Suite {beenasked.Name}";
                    default:
                        throw new Exception("We dont know that mode");
                }
            }
        }

        public bool IsGameOver { get; set; }
        private Mode mode;
        private Action ShowState;
        private Player asker;
        private Player beenasked;
        private Player activePlayer;

        public Player ActivePlayer { get; set; }

        public Scarbnica_Game(List<Player> players, Action showState)
        {
            Players = players;
            ShowState = showState;
            Deck = new CardSet();
            Prepare();
        }

        public string GetPossibleActions() 
        {
            if (mode == Mode.AskingFigure)
                return "Asking about Figure";
            //if (mode == Mode.AskingNumber)
            //    return "Asking about Number";
            return "Asking about Suite";
        }

        public void Prepare()
        {
            foreach (var player in Players)
            {
                player.IsInGame = true;
            }
            Deck.Full(); 
            Deck.CutTo(36);

            Deck.Shuffle();
        }

        public void Deal()
        {
            IsGameOver = false;
            foreach (var player in Players)
            {
                player.Hand.Add(Deck.Deal(4));
                player.Hand.Sort();
            }

            ResultInfo = "All right";
            mode = Mode.AskingSuite;
            asker = WhoFirst();
            beenasked = NextPlayer(asker);

            ActivePlayer = asker;
            ShowState();
        }

        public void Turn(Card cardForTurn)
        {
            if (Impossible(cardForTurn)) return;

            //Table.Add(ActivePlayer.Hand.Pull(cardForTurn));
            ResultInfo = "";
            SwitchMode();
            ShowState();

        }

        private void SwitchMode()
        {
            switch (mode)
            {
                case Mode.AskingFigure:
                    SwitchAfterAskingFigure();
                    break;
                //case Mode.AskingNumber:
                //    SwitchAfterAskingNumber();
                //    break;
                case Mode.AskingSuite:
                    SwitchAfterAskingSuite();
                    break;
                default:
                    throw new Exception("Unregistrated mode");
            }
        }
        private void TurnOnAskingFigure()
        {
            mode = Mode.AskingFigure;
        }

        private void SwitchAfterAskingFigure()
        {
            throw new NotImplementedException();
        }

        //private void SwitchAfterAskingNumber()
        //{
        //    throw new NotImplementedException();
        //}

        private void SwitchAfterAskingSuite()
        {
            throw new NotImplementedException();
        }

        public bool CheckIfFigureFits(string answerfigure)
        {
            bool checkfig = false;
            foreach (var c in beenasked.Hand)
            {
                if (answerfigure == c.Figure.ToString())
                    checkfig = true;
            }
            return checkfig;
        }
        //public bool CheckIfNumberFits(int answernumber, string checkfig)
        //{
        //    bool checknum = false;
        //    int needfigure = 0;
        //    foreach (var c in beenasked.Hand)
        //    {
        //        if (checkfig == c.Figure.ToString())
        //            needfigure++;
        //    }
        //    if (answernumber == needfigure)
        //    {
        //        checknum = true;
        //    }
        //    return checknum;
        //}
        public bool CheckIfSuitesFits(List<string> answersuite)
        {
            bool checksuite = false;
            foreach (var suite in answersuite)
            {
                foreach (var c in beenasked.Hand)
                {
                    if (suite == c.Figure.ToString())
                        checksuite = true;
                    checksuite = false;
                }
            }
            return checksuite;
        }

        public List<Card> CardSetForAsker(string answerfigure, List<string> answersuite)
        {
            List<Card> cardsthathasbeenguessedbyfigure = new List<Card>();
            List<Card> endcardset = new List<Card>();
            foreach (var c in beenasked.Hand)
            {
                if (answerfigure == c.Figure.ToString())
                    cardsthathasbeenguessedbyfigure.Add(c);
            }
            foreach (var suite in answersuite)
            {
                foreach (var c in cardsthathasbeenguessedbyfigure)
                {
                    if (suite == c.Suite.ToString())
                        endcardset.Add(c);
                }
            }
            return endcardset;
        }

        private Player NextPlayer(Player player, Predicate<Player> except, Player stopPlayer = null)
        {
            Player applicant = NextPlayer(player);
            if (stopPlayer == applicant) return null;
            if (except(applicant)) return NextPlayer(applicant, except, player);
            return applicant;
        }

        private void PickUpAfterWrongAnswer()
        {
            //defender.Hand.Add(Table.Deal(Table.Count));
            //ResultInfo = $" {defender.Name} picked up ";
            NextTurn();
        }

        public void GiveUp()
        {
            //mode = Mode.PickingUp;
            //if (countToTurn == 0) PickUp();
            //ActivateMover();
            //ShowState();
        }

        private void NextTurn()
        {
            //CardDraw();
            //CheckWinner();
            //if (IsGameOver) return;
            //if (mode == Mode.PickingUp)
            //    attacker = NextPlayer(defender);
            //else
            //    attacker = defender.IsInGame ? defender : NextPlayer(attacker);
            //defender = NextPlayer(attacker);
            //mover = attacker;
            //firstPasser = null;

            //countToTurn = Math.Min(6, defender.Hand.Count);
            //TurnAttackMode();
        }

        private void CheckWinner()
        {
            int countInGame = Players.Count(p => p.IsInGame);
            if (countInGame == 1)
            {
                IsGameOver = true;
                ResultInfo = $"{(Players.FirstOrDefault(p => p.IsInGame)).Name} has been defeated";
            }
            
            if (countInGame == 0)
            {
                IsGameOver = true;
                ResultInfo = "There is a draw";
            }
        }

        private bool Impossible(Card cardForTurn)
        {
            return IsGameOver ||
                (mode == Mode.AskingFigure && ActivePlayer == beenasked) ||
                //(mode == Mode.AskingNumber && ActivePlayer == beenasked) ||
                (mode == Mode.AskingSuite && ActivePlayer == beenasked) ||
                (ActivePlayer == beenasked);
                //|| (mode == ) ||
        }

        private Player NextPlayer(Player player)
        {
            var applicant = Players[Players.Count - 1] == player ? Players[0] : Players[Players.IndexOf(player) + 1];
            if (!applicant.IsInGame) return NextPlayer(applicant);
            return applicant;
        }

        private Player WhoFirst()
        {
            Player active = Players[random.Next(0, 3)];
            return active;
        }
    }
}
