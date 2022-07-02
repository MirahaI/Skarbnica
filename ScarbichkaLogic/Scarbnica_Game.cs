using CardsModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScarbnichkaLogic
{
    public class Scarbnica_Game
    {
        public enum Mode
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
                switch (GameMode)
                {
                    case Mode.AskingFigure:
                        return $"{Asker.Name} is asking about Figure {beenasked.Name}";  
                    case Mode.AskingNumber:
                        return $"{Asker.Name} is asking about Number {beenasked.Name}";
                    case Mode.AskingSuite:
                        return $"{Asker.Name} is asking about Suite {beenasked.Name}";
                    default:
                        throw new Exception("We dont know that mode");
                }
            }
        }
        public bool IsGameOver { get; set; }
        public Mode GameMode { get; set; }
        private Action ShowState;

        private Func<Player> RequestBeenAsked;
        public Player Asker { get; set; }
        private Player beenasked;
        private CardFigure activeFigure;
        private int activeNumber;
        private List<CardSuite> activeSuite;


        public Scarbnica_Game(List<Player> players, Action showState, Func<Player> requestBeenAsked)
        {
            RequestBeenAsked = requestBeenAsked;
            Players = players;
            ShowState = showState;
            Deck = new CardSet();
        }

        public string GetPossibleActions() 
        {
            if (GameMode == Mode.AskingFigure)
                return "Asking about Figure";
            if (GameMode == Mode.AskingNumber)
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
            GameMode = Mode.AskingFigure;
            Asker = WhoFirst();
            beenasked = NextPlayer(Asker);
            ShowState();
        }

    

        //public void Turn(Card cardForTurn)
        //{
        //    if (Impossible(cardForTurn)) return;
        //    ShowState();
        //}


        public bool CheckIfFigureFits(CardFigure fig)  
        {
            bool res =  beenasked.Hand.FirstOrDefault(c => c.Figure == fig) != default;

            if (res)
            {
                ResultInfo = "Asker guessed Figure right!";
                activeFigure = fig;
                GameMode = Mode.AskingNumber;
                ShowState();
            }
            else
            {
                ResultInfo = "Asker guessed Figure wrong!";
                PickUpAfterWrongAnswer();
                NextTurn(res);
            }
            
            return res;
        }
        public bool CheckIfNumberFits(int answernumber)
        {
            int had = beenasked.Hand.Count(c => c.Figure == activeFigure);
            
            if (answernumber == had)
            {
                ResultInfo = "Asker guessed Number right!";
                GameMode = Mode.AskingSuite;
                ShowState();
                activeNumber = answernumber;
            }
            else
            {
                ResultInfo = "Asker guessed Number wrong!";
                PickUpAfterWrongAnswer();
                GameMode = Mode.AskingFigure;
                NextTurn(false);
            }
            return answernumber == had;
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
                ResultInfo = "Asker guessed Suites right!";
                CardSetForAsker();

                GameMode = Mode.AskingFigure;
                beenasked = RequestBeenAsked();
            }
            else
            {
                ResultInfo = "Asker guessed Suites wrong!";
                PickUpAfterWrongAnswer();
                GameMode = Mode.AskingFigure;
                
            }
            NextTurn(check);
            return check;
        }

        public void CardSetForAsker()
        {
            List<Card> pull = new List<Card>();

            foreach (var c in beenasked.Hand)
            {
                if (activeFigure == c.Figure)
                    pull.Add(c);
            }

            beenasked.Hand.RemoveCard(pull);
            Asker.Hand.Add(pull);
        }

        private void PickUpAfterWrongAnswer()
        {
            List<Card> Pull = new List<Card>();
            Asker.Hand.Add(Deck.Pull());
        }

        private Player NextPlayer(Player player, Predicate<Player> except, Player stopPlayer = null)
        {
            Player applicant = NextPlayer(player);
            if (stopPlayer == applicant) return null;
            if (except(applicant)) return NextPlayer(applicant, except, player);
            return applicant;
        }

        private void NextTurn(bool guess)
        {
            CheckBox();
            ifDeckemptyandHandsempty();
            if (IsGameOver) return;
            CheckWinner(IsGameOver);

            if (!guess)
            {     
                Asker = beenasked;
                beenasked = NextPlayer(Asker);
            }
            ShowState();
        }

        private void CheckWinner(bool IsGameOver)
        {
            if (IsGameOver == true)
            {
                Player winner = Players[0];
                foreach (var p in Players)
                {
                    if (p.NumofBox > winner.NumofBox)
                    {
                        winner = p;
                        ResultInfo = $"{winner.Name} has collected the most boxes!";
                    }
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

        private void CheckBox() //Error when Box is ready
        {
            //перебрать фигуры и игроков, для каждой посчитать количество у игрока. Если 4 выбрасываем эти фигуры
            foreach (CardFigure figure in Enum.GetValues(typeof(CardFigure)))
            {
                foreach (var p in Players)
                {
                    int res = p.Hand.Count(c => c.Figure == figure);
                    if (res == 4)
                    {
                        p.Hand.RemoveCard(p.Hand.Where(c => c.Figure == figure).ToArray());
                        p.NumofBox++;
                    }

                    //int res = 0;
                    //foreach (var c in p.Hand)
                    //{
                    //    if (c.Figure.ToString() == name)
                    //    {
                    //        res++;
                    //        if (res == 4)
                    //        {
                    //            p.NumofBox++;
                    //            foreach (var cardToRemove in p.Hand)
                    //            {
                    //                if (c.Figure.ToString() == name)
                    //                    p.Hand.RemoveCard(cardToRemove);
                    //            }
                    //        }
                    //    }
                    //}
                }
            }
        }

        //private bool Impossible(Card cardForTurn)
        //{
        //    return IsGameOver ||
        //        (GameMode == Mode.AskingFigure && ActivePlayer == beenasked) ||
        //        (GameMode == Mode.AskingNumber && ActivePlayer == beenasked) ||
        //        (GameMode == Mode.AskingSuite && ActivePlayer == beenasked) ||
        //        (ActivePlayer == beenasked);
        //}

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
