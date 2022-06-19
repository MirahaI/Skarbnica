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
    public partial class RequestPlayer : Form
    {
        public Player ChoosedPlayer { get; set; }
        public RequestPlayer()
        {
            InitializeComponent();
        }
    }
}
