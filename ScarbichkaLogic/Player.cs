using CardsModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScarbnichkaLogic
{
    public class Player
    {

        public Player(string name, CardSet hand, int numofBox)
        {
            Name = name;
            Hand = hand;
            NumofBox = numofBox;
        }

        public string Name { get; set; }
        public CardSet Hand { get; set; }
        public int NumofBox { get; set; }
        public bool IsInGame { get; set; } = true;
    }
}
