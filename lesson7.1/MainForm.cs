using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7._1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Event
        }

        public int Amount
        {
            get { return Convert.ToInt32(lblAmount.Text); }
            set { lblAmount.Text = value.ToString(); }
        }
        public int WinAmount
        {
            get { return Convert.ToInt32(lblWinAmount.Text); }
            set { lblWinAmount.Text = value.ToString(); }
        }
        public int ClickCount
        {
            get { return Convert.ToInt32(lblClickCount.Text); }
            set { lblClickCount.Text = value.ToString(); }
        }

        #region Event
        public event EventHandler ClickedPlay;
        public event EventHandler ClickedPlusOne;
        public event EventHandler ClickedDoubled;
        public event EventHandler ClickedReset;

        private void btnCommand1_Click(object sender, EventArgs e)
        {
            if(ClickedPlusOne != null) ClickedPlusOne(this, EventArgs.Empty); 
        }

        private void btnCommand2_Click(object sender, EventArgs e)
        {
            if(ClickedDoubled != null) ClickedDoubled(this, EventArgs.Empty);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(ClickedReset != null) ClickedReset(this, EventArgs.Empty);
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ClickedPlay != null) ClickedPlay(this, EventArgs.Empty);
        }
        #endregion

        public void Win()
        {
            MessageBox.Show("ПОБЕДА");
        }

        public void Loses()
        {
            MessageBox.Show("ПРОИГРЫШЬ");
        }
    }
}
