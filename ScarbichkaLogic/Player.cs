using CardsModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ScarbnichkaLogic
{
    public class Player
    {
        public Player(string name, CardSet hand)
        {
            Name = name;
            Hand = hand;
            
        }

        public Player(string name) : this(name, new CardSet())
        {
        }

        public string Name { get; set; }
        public CardSet Hand { get; set; }

        //num of box
        public bool IsInGame { get; set; } = true;
    }
}
