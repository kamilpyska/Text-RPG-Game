using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class AmuletForm : Form
    {
        public AmuletForm()
        {
            InitializeComponent();
        }

        private void hideAmuletFormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
