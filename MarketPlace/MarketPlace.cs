using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketPlace
{
    public partial class MarketPlace : Form
    {
        public MarketPlace()
        {
            InitializeComponent();
            Auth auth = new Auth();
            auth.ShowDialog();
        }

        private void MarketPlace_Load(object sender, EventArgs e)
        {

        }

        private void profileTab_Click(object sender, EventArgs e)
        {

        }
    }
}
