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
            AskingNumber,
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
                        return $"{asker.Name} is asking about Figure {beenasked.Name}";  
                    case Mode.AskingNumber:
                        return $"{asker.Name} is asking about Number {beenasked.Name}";
                    case Mode.AskingSuite:
                        return $"{asker.Name} is asking about Suite {beenasked.Name}";
                    default:
                        throw new Exception("We dont know that mode");
                }
            }
        }

        public bool IsGameOver { get; set; }
        private Mode mode;
        private Mode lastmode;
        private Action ShowState;
        private Player asker;
        private Player beenasked;
        private CardFigure activeFigure;
        private int activeNumber;
        private CardSuite activeSuite;

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
            if (mode == Mode.AskingNumber)
                return "Asking about Number";
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
            ShowState();
        }

    

        public void Turn(Card cardForTurn)
        {
            if (Impossible(cardForTurn)) return;

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
                case Mode.AskingNumber:
                    SwitchAfterAskingNumber();
                    break;
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
            //if 
        }

        private void SwitchAfterAskingFigure()
        {
            throw new NotImplementedException();
        }

        private void SwitchAfterAskingNumber()
        {
            throw new NotImplementedException();
        }

        private void SwitchAfterAskingSuite()
        {
            throw new NotImplementedException();
        }

        public bool CheckIfFigureFits(CardFigure fig)  
        {
            bool res =  beenasked.Hand.FirstOrDefault(c => c.Figure == fig) != default;

            if (res) activeFigure = fig;
            return res;
        }
        public bool CheckIfNumberFits(int answernumber, CardFigure fig)
        {
            bool checknum = false;
            int needfigure = 0;
            foreach (var c in beenasked.Hand)
            {
                if (fig == c.Figure)
                    needfigure++;
            }
            if (answernumber == needfigure)
            {
                checknum = true;
            }
            activeNumber = answernumber;
            return checknum;
        }
        public bool CheckIfSuitesFits(CardFigure figure, List<CardSuite> answersuite)
        {
            bool checksuite = false;
            List<Card> withfigfits = new List<Card>();
            foreach (var card in beenasked.Hand)
            {
                if (card.Figure == figure)
                    withfigfits.Add(card);
            }
            foreach (var suite in answersuite)
            {
                foreach (var c in withfigfits)
                {
                    if (suite == c.Suite)
                        checksuite = true;
                    checksuite = false;
                }
            }
            return checksuite;
        }

        public void CardSetForAsker(CardFigure fig, List<CardSuite> answersuite, Player asker, Player beenasked)
        {
            List<Card> demopull = new List<Card>();
            List<Card> pull = new List<Card>();
            foreach (var c in beenasked.Hand)
            {
                if (fig == c.Figure)
                    demopull.Add(c);
            }
            foreach (var suite in answersuite)
            {
                foreach (var c in demopull)
                {
                    if (suite == c.Suite)
                        pull.Add(c);
                }
            }
            asker.Hand.Add(pull);
            beenasked.Hand.RemoveCardSet(pull);
        }

        private void PickUpAfterWrongAnswer()
        {
            List<Card> Pull = new List<Card>();
            asker.Hand.Add(Deck[Deck.Count - 1]);
            Deck.RemoveCard(Deck[Deck.Count - 1]);
            NextTurn();
        }

        private Player NextPlayer(Player player, Predicate<Player> except, Player stopPlayer = null)
        {
            Player applicant = NextPlayer(player);
            if (stopPlayer == applicant) return null;
            if (except(applicant)) return NextPlayer(applicant, except, player);
            return applicant;
        }

        private void NextTurn()
        {
            CheckBox();
            ifDeckemptyandHandsempty();
            if (IsGameOver) return;
            CheckWinner();

            if (lastmode != Mode.AskingSuite)
            {
                asker = beenasked;
                beenasked = NextPlayer(asker);
            }

            TurnOnAskingFigure();
        }

        private void CheckWinner()
        {
            Player winner = Players[0];
            foreach (var p in Players)
            {
                if (p.NumofBox > winner.NumofBox)
                {
                    winner = p;
                    ResultInfo = $"{winner.Name} has collected the most boxes!";
                }
                if (p.NumofBox == winner.NumofBox)
                {
                    ResultInfo = $"There is a draw";
                }
            }
        }

        private bool ifDeckemptyandHandsempty()
        {
            bool emptyhands = false;
            bool emptydeck = false;
            foreach (var p in Players)
            {
                if (p.Hand.Count == 0)
                    emptyhands = true;
            }
            if (Deck.Count == 0)
                emptydeck = true;
            if (emptydeck == true && emptyhands == true)
                IsGameOver = true;
            return IsGameOver;
        }

        private void CheckBox()
        {
            foreach (var p in Players)
            {
                for (int i = 0; i < p.Hand.Count - 1; i++)
                {
                    //?
                }
            }
        }

        private bool Impossible(Card cardForTurn)
        {
            return IsGameOver ||
                (mode == Mode.AskingFigure && ActivePlayer == beenasked) ||
                (mode == Mode.AskingNumber && ActivePlayer == beenasked) ||
                (mode == Mode.AskingSuite && ActivePlayer == beenasked) ||
                (ActivePlayer == beenasked);
        }

        private Player NextPlayer(Player player)
        {
            var applicant = Players[Players.Count - 1] == player ? Players[0] : Players[Players.IndexOf(player) + 1];
            if (!applicant.IsInGame) return NextPlayer(applicant);
            return applicant;
        }

        private Player WhoFirst()
        {
            Player active = Players[random.Next(0, Players.Count - 1)];
            return active;
        }
    }
}
