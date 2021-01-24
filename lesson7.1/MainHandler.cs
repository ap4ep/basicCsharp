using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7._1
{
    class MainHandler
    {
        private readonly DoublerLogic _doublerLogic;
        private readonly MainForm _mainForm;

        public MainHandler(DoublerLogic doublerLogic, MainForm mainForm)
        {
            _doublerLogic = doublerLogic;
            _mainForm = mainForm;

            _mainForm.Amount = 0;
            _mainForm.WinAmount = 0;
            _mainForm.ClickCount = 0;

            _mainForm.ClickedPlay += _mainForm_ClickedPlay; 
            _mainForm.ClickedPlusOne += _mainForm_ClickedPlusOne; 
            _mainForm.ClickedDoubled += _mainForm_ClickedDoubled;
            _mainForm.ClickedReset += _mainForm_ClickedReset;
        }

        private void _mainForm_ClickedReset(object sender, EventArgs e)
        {
            _doublerLogic.Reset();
            UpdateForm();
        }

        private void _mainForm_ClickedDoubled(object sender, EventArgs e)
        {
            _doublerLogic.SetDoubled();
            _doublerLogic.SetClickCount();
            UpdateForm();
            CheckCondition();
        }

        private void _mainForm_ClickedPlusOne(object sender, EventArgs e)
        {
            _doublerLogic.SetPlusOne();
            _doublerLogic.SetClickCount();
            UpdateForm();
            CheckCondition();
        }

        private void _mainForm_ClickedPlay(object sender, EventArgs e)
        {
            _doublerLogic.Start();
            UpdateForm();
            _mainForm.ShowWinCondition(_doublerLogic.WinAmount);
        }

        private void CheckCondition()
        {
            if (_doublerLogic.Amount == _doublerLogic.WinAmount)
                _mainForm.Win();
            if (_doublerLogic.Amount > _doublerLogic.WinAmount)
                _mainForm.Loses();
        }

        private void UpdateForm()
        {
            _mainForm.WinAmount = _doublerLogic.WinAmount;
            _mainForm.Amount = _doublerLogic.Amount;
            _mainForm.ClickCount = _doublerLogic.ClickCount;
        }
    }
}
