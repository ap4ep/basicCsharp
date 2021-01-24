using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7._2
{
    class MainPresenter
    {
        private readonly GuessTheNumberLogic _guesTheNumberLogic;
        private readonly MainForm _mainForm;

        public MainPresenter(GuessTheNumberLogic guesTheNumberLogic, MainForm mainForm)
        {
            _guesTheNumberLogic = guesTheNumberLogic;
            _mainForm = mainForm;

            _mainForm.TryCount = 0;

            _mainForm.ClickedPlay += _mainForm_ClickedPlay;
            _mainForm.ClickedCheck += _mainForm_ClickedCheck;
        }

        private void _mainForm_ClickedPlay(object sender, EventArgs e)
        {
            _mainForm.TryCount = 0;
            _guesTheNumberLogic.SetWinCondition();
            _mainForm.ShowWinCondition();
        }

        private void _mainForm_ClickedCheck(object sender, EventArgs e)
        {
            _guesTheNumberLogic.SetTryCount();
            _mainForm.TryCount = _guesTheNumberLogic.TryCount;

            if (_guesTheNumberLogic.CheckGuess(_mainForm.Guess))
                _mainForm.Win();
            else
                _mainForm.Hint = _guesTheNumberLogic.GetHint(_mainForm.Guess, _guesTheNumberLogic.WinCondition);
        }
    }
}
