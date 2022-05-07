using CardsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GCI
{
    public class GraphicCard: Card
    {
        private static readonly Image faceDownImage;
        private static readonly Dictionary<Card, Image> cardImages = new Dictionary<Card, Image>();
        public PictureBox Pb { get; }
        private bool opened;
        public bool Opened
        {
            get => opened;
            set
            {
                opened = value;
                if (opened)
                    Pb.Image = cardImages[this];
                else
                    Pb.Image = faceDownImage;
            }
        }
        public GraphicCard(CardSuite suite, CardFigure figure, PictureBox pb) : base(suite, figure)
        {
            Pb = pb;
            Pb.SizeMode = PictureBoxSizeMode.Zoom;
            Pb.Image = faceDownImage;
        }
        static GraphicCard() 
        {
            faceDownImage = Image.FromFile($"{Application.StartupPath}\\images\\shirt.png");
            CardSet full = new CardSet();
            full.Full(); 
            foreach (var card in full)
            {
                cardImages[card] = Image.FromFile($"{Application.StartupPath}\\images\\{card.Suite} {card.Figure}.png");
            }
        }
        
        public void Show()
        {
            Opened = true;
        }
        public void Hide()
        {
            Opened = false;
        }
    }
}
