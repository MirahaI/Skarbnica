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
        private Mode ModeThatbeenguessedright;
        private Action ShowState;
        private Player asker;
        private Player beenasked;
        private CardFigure activeFigure;
        private int activeNumber;
        private List<CardSuite> activeSuite;

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
            ShowState();
        }


        public bool CheckIfFigureFits(CardFigure fig)  
        {
            bool res =  beenasked.Hand.FirstOrDefault(c => c.Figure == fig) != default;

            if (res)
            {
                activeFigure = fig;
                mode = Mode.AskingNumber;
                ModeThatbeenguessedright = Mode.AskingFigure;
            }
            else
            {
                PickUpAfterWrongAnswer();
                mode = Mode.AskingFigure;
                ModeThatbeenguessedright = Mode.AskingFigure;
                NextTurn();
            }
            return res;
        }
        public bool CheckIfNumberFits(int answernumber)
        {
            bool checknum = false;
            int needfigure = 0;
            activeNumber = answernumber;
            foreach (var c in beenasked.Hand)
            {
                if (activeFigure == c.Figure)
                    needfigure++;
            }
            if (activeNumber == needfigure)
            {
                checknum = true;
                mode = Mode.AskingSuite;
                ModeThatbeenguessedright = Mode.AskingNumber;
            }
            else
            {
                PickUpAfterWrongAnswer();
                mode = Mode.AskingSuite;
                ModeThatbeenguessedright = Mode.AskingFigure;
                NextTurn();
            }
            return checknum;
        }
        public bool CheckIfSuitesFits(List<CardSuite> answersuite)
        {
            activeSuite = answersuite;
            bool check = true; 
            foreach (var suite in activeSuite)
            {
                if (beenasked.Hand.FirstOrDefault(c => c.Suite == suite && c.Figure == activeFigure) == default)
                {
                    check = false;
                } 
            }
            if (check == true)
            {
                CardSetForAsker();
                mode = Mode.AskingFigure;
                ModeThatbeenguessedright = Mode.AskingSuite;
                NextTurn();
            }
            else
            {
                PickUpAfterWrongAnswer();
                mode = Mode.AskingFigure;
                ModeThatbeenguessedright = Mode.AskingNumber;
                NextTurn();

            }
            return check;
        }

        public void CardSetForAsker()
        {
            List<Card> pull = new List<Card>();

            foreach (var c in beenasked.Hand)
            {
                if (activeFigure == c.Figure)
                    pull.Add(beenasked.Hand.Pull(c));
            }

            asker.Hand.Add(pull);
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

            if (ModeThatbeenguessedright != Mode.AskingSuite)
            {
                asker = beenasked;
                beenasked = NextPlayer(asker);
            }

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
            //перебрать фигуры и игроков, для каждой посчитать количество у игрока. Если 4 выбрасываем эти фигуры
            foreach (string name in Enum.GetNames(typeof(CardFigure)))
            {
                int res = 0;
                foreach (var p in Players)
                {
                    foreach (var c in p.Hand)
                    {
                        if (c.Figure.ToString() == name)
                        {
                            res++;
                            if (res == 4)
                            {
                                p.NumofBox++;
                                foreach (var cardToRemove in p.Hand)
                                {
                                    if (c.Figure.ToString() == name)
                                        p.Hand.RemoveCard(cardToRemove);
                                }
                            }
                        }
                    }
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
