using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GCI;
using System.Drawing;
using CardsModel;

namespace GCI
{
    public class GraphicCardSet: CardSet
    {
        public Panel Panel { get; }
        public GraphicCardSet(Panel panel) : base()
        {
            Panel = panel;
        }

        public GraphicCardSet(Panel panel, params GraphicCard[] cards) : base(cards) 
        {
            Panel = panel;
        }

        public GraphicCardSet(Panel panel, List<GraphicCard> cards) : this(panel, cards.ToArray()) 
        {
        }

        public override void Add(params Card[] cards)
        {
            base.Add(cards);
            foreach (var card in Cards)
            {
                var gcard = card as GraphicCard; 
                if (gcard != null)
                {
                    Panel.Controls.Add(gcard.Pb);
                }
            }
        }

        public override void RemoveCard(Card card)
        {
            var gcard = card as GraphicCard; 
            if (gcard != null)
                Panel.Controls.Remove(gcard.Pb);
            base.RemoveCard(card);
        }

        public override Card GetCard(CardSuite suite, CardFigure figure)
        {
            return new GraphicCard(suite, figure, new PictureBox()); 
        }

        public void Draw()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard card = Cards[i] as GraphicCard;
                card.Pb.BringToFront();
                card.Pb.Size = new System.Drawing.Size(card.Pb.Image.Width * Panel.Height / card.Pb.Image.Height, Panel.Height);
                card.Pb.Location = new Point(i * (Panel.Width - card.Pb.Width) / Count, 0);
            }
        }

        public void ShowCards()
        {
            foreach (GraphicCard card in Cards)
            {
                card.Show();
            }
            Draw();
        }

        public void HideCards()
        {
            foreach (GraphicCard card in Cards)
            {
                card.Hide();
            }
            Draw();
        }
    }
}
