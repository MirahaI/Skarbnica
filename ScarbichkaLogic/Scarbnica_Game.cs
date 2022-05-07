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
            //Asking,
            AskingSuite,
            AskingFigure,
            AskingNumber,
            PickingUp
            //Attack,
            //Defending,
            //PickingUp
        }
        //private const string GIVEUPSTR = "Take cards";
        //private const string PASSSTR = "Pass the move";

        private readonly static Random random = new Random();
        public List<Player> Players { get; set; }
        public CardSet Deck { get; set; }
        
        //public CardSet Table { get; set; }
        public CardSet Bin { get; set; }
        
        //public Card Trump { get; set; }

        public string ResultInfo { get; set; }
        public string StateInfo
        {
            get
            {
                switch (mode)
                {
                    case Mode.AskingSuite:
                        return $"{ActivePlayer.Name} is asking about Suite {beenasked.Name}";
                    case Mode.AskingFigure:
                        return $"{ActivePlayer.Name} is asking about Figure {beenasked.Name}"; //$"{defender.Name} is defending"; 
                    case Mode.AskingNumber:
                        return $"{ActivePlayer.Name} is asking about Number {beenasked.Name}"; //$"{defender.Name} is giving up. {mover.Name} can pick up {countToTurn} cards.";
                    case Mode.PickingUp:
                        return $"{ActivePlayer.Name} was wrong and picking up a card!";
                    default:
                        throw new Exception("We dont know that mode");
                }
            }
        }

        public bool IsGameOver { get; set; }
        private Mode mode;
        private Action ShowState;
        //private Player mover;
        //private Player defender;
        //private Player attacker;
        private Player asker;
        private Player beenasked;
        private Player activePlayer;
        //private int countToTurn;
        //private Player firstPasser;

        public Player ActivePlayer { get; set; }

        public Scarbnica_Game(List<Player> players, Action showState)
        {
            Players = players;
            ShowState = showState;
            //Table = new CardSet();
            Deck = new CardSet();
            Prepare();
        }

        public string GetPossibleActions() 
        {
            if (mode == Mode.PickingUp)
                return "Pick up";
            return "Ask";
            //if (mode == Mode.Defending)
            //    return "Give up";
            //return "Pass";
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
            //Trump = Deck.LastCard;
            foreach (var player in Players)
            {
                player.Hand.Add(Deck.Deal(4));
                player.Hand.Sort();
            }

            ResultInfo = "All right";
            mode = Mode.AskingSuite;
            asker = WhoFirst();
            //defender = NextPlayer(attacker);

            mover = attacker;
            ActivePlayer = mover;
            countToTurn = Math.Min(4, defender.Hand.Count);
            ShowState();
        }

        public void Turn(Card cardForTurn)
        {
            if (Impossible(cardForTurn)) return;

            Table.Add(ActivePlayer.Hand.Pull(cardForTurn));
            ResultInfo = "";
            SwitchMode();
            ShowState();

        }

        private void SwitchMode()
        {
            switch (mode)
            {
                case Mode.AskingSuite:
                    SwitchAfterAskingSuite();
                    break;
                case Mode.AskingFigure:
                    SwitchAfterAskingFigure();
                    break;
                case Mode.AskingNumber:
                    SwitchAfterAskingNumber();
                    break;
                case Mode.PickingUp:
                    SwitchAfterPickingUp();
                    break;
                default:
                    throw new Exception("Unregistrated mode");
            }
        }

        private void SwitchAfterAskingNumber()
        {
            throw new NotImplementedException();
        }

        private void SwitchAfterAskingFigure()
        {
            throw new NotImplementedException();
        }

        private void SwitchAfterAskingSuite()
        {
            throw new NotImplementedException();
        }

        private void SwitchAfterPickingUp()
        {
            countToTurn--;
            if (countToTurn == 0) PickUp();
            else if (mover.Hand.Count == 0)
            {
                NextMover();
                ActivateMover();
            }
        }

        private void ActivateMover()
        {
            if (mover.Hand.Count == 0) NextMover();
            ActivePlayer = mover;
        }

        private void NextMover()
        {
            Player applicant = NextPlayer(mover, p => p == defender || p.Hand.Count == 0);
            if (applicant == null || applicant == firstPasser)
            {
                if (mode == Mode.PickingUp)
                    PickUp();
                else Beat();
                return;
            }
            mover = applicant;
        }


        private Player NextPlayer(Player player, Predicate<Player> except, Player stopPlayer = null)
        {
            Player applicant = NextPlayer(player);
            if (stopPlayer == applicant) return null;
            if (except(applicant)) return NextPlayer(applicant, except, player);
            return applicant;
        }

        private void PickUp()
        {
            //defender.Hand.Add(Table.Deal(Table.Count));
            //ResultInfo = $" {defender.Name} picked up ";
            NextTurn();
        }

        private void SwitchAfterDefending()
        {
            if (defender.Hand.Count == 0 || countToTurn == 0)
                Beat();
            else
            {
                firstPasser = null;
                TurnAttackMode();
            }
        }

        public void GiveUp()
        {
            mode = Mode.PickingUp;
            if (countToTurn == 0) PickUp();
            ActivateMover();
            ShowState();
        }

        public void Pass()
        {
            if (firstPasser == null) firstPasser = ActivePlayer;
            NextMover();
            ActivateMover();
            ShowState();
        }

        //private void Beat()
        //{
        //    Table.Clear();
        //    ResultInfo = "Got beaten";
        //    NextTurn();
        //}

        private void NextTurn()
        {
            CardDraw();
            CheckWinner();
            if (IsGameOver) return;
            if (mode == Mode.PickingUp)
                attacker = NextPlayer(defender);
            else
                attacker = defender.IsInGame ? defender : NextPlayer(attacker);
            defender = NextPlayer(attacker);
            mover = attacker;
            firstPasser = null;

            countToTurn = Math.Min(6, defender.Hand.Count);
            TurnAttackMode();
        }

        private void CheckWinner()
        {
            //int countInGame = Players.Count(p => p.IsInGame);
            //if (countInGame == 1)
            //{
            //    IsGameOver = true;
            //    ResultInfo = $"{(Players.FirstOrDefault(p => p.IsInGame)).Name} has been defeated";
            //}
            //
            //if (countInGame == 0)
            //{
            //    IsGameOver = true;
            //    ResultInfo = "There is a draw";
            //}
        }

        private void CardDraw()
        {
            //CardDraw(attacker);
            //var player = NextPlayer(attacker, p => p == defender);  
            //while (player != null && player != attacker)
            //{
            //    CardDraw(player);
            //    player = NextPlayer(player, p => p == defender);
            //}
            //CardDraw(defender);
            //
            //foreach (var plr in Players)
            //{
            //    plr.IsInGame = plr.Hand.Count != 0;
            //}
        }

        //private void CardDraw(Player player)
        //{
        //    int count = player.Hand.Count;
        //    if (count < 6) player.Hand.Add(Deck.Deal(6 - count));
        //    player.Hand.Sort();
        //}

        private void TurnAttackMode()
        {
            ActivateMover();
            mode = Mode.Attack;
        }

        private void SwitchAfterAttack()
        {
            countToTurn--;
            TurnDefendingMode();
            ShowState();
        }

        private void TurnDefendingMode()
        {
            ActivePlayer = defender;
            mode = Mode.Defending;
        }

        //private bool Impossible(Card cardForTurn)
        //{
        //    return IsGameOver ||
        //        (mode != Mode.Defending && ActivePlayer == defender) ||
        //        (!ActivePlayer.Hand.Contains(cardForTurn)) ||
        //        (mode != Mode.Defending && Table.Count > 0 && Table.FirstOrDefault(c => c.Figure == cardForTurn.Figure) == null) ||
        //        (mode == Mode.Defending && !IsBeat(cardForTurn, Table.LastCard)); 
        //}

        //private bool IsBeat(Card front, Card back)
        //{
        //    if (front.Suite == back.Suite) return front.Figure > back.Figure;
        //    return (front.Suite == Trump.Suite);
        //}

        private Player NextPlayer(Player player)
        {
            var applicant = Players[Players.Count - 1] == player ? Players[0] : Players[Players.IndexOf(player) + 1];
            if (!applicant.IsInGame) return NextPlayer(applicant);
            return applicant;
        }

        
        private Player PreviousPlayer(Player player)
        {
            var applicant = Players[0] == player ? Players[Players.Count - 1] : Players[Players.IndexOf(player) + 1];
            if (!applicant.IsInGame) return NextPlayer(applicant);
            return applicant;
        }

        private Player WhoFirst()
        {
            Player active = Players[random.Next(0, 3)];
            return active;
            //Card minCard = new Card(Trump.Suite, CardFigure.Ace);
            //Player active = Players[0];
            //foreach (var player in Players)
            //{
            //    foreach (var card in player.Hand)
            //    {
            //        if (card.Suite == Trump.Suite && card.Figure < minCard.Figure)
            //        {
            //            minCard = card;
            //            active = player;
            //        }
            //    }
            //}
            //return active;
        }
    }
}
