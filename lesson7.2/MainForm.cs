using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson7._2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public int TryCount
        {
            get { return Convert.ToInt32(txtTryCount.Text); }
            set { txtTryCount.Text = value.ToString(); }
        }

        public int Guess
        {
            get { return Convert.ToInt32(txtInput.Text); }
            set { txtInput.Text = value.ToString(); }
        }

        public string Hint
        {
            get { return lblHint.Text; }
            set { lblHint.Text = value; }
        }

        #region Event
        public event EventHandler ClickedPlay;
        public event EventHandler ClickedCheck;

        private void btnStart_Click(object sender, EventArgs e)
        {
            ClickedPlay?.Invoke(this, EventArgs.Empty);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            ClickedCheck?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region MessageBox
        public void ShowWinCondition()
        {
            MessageBox.Show("Для победы вам нужно отгдать число от 1 до 100");
        }

        public void Win()
        {
            MessageBox.Show("Угадал :)");
        }
        #endregion
    }
}
