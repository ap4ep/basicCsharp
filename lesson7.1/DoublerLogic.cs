using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7._1
{
    public class DoublerLogic
    {
        public int WinAmount { get; private set; }
        public int Amount { get; private set; }
        public int ClickCount { get; private set; }

        public void Start()
        {
            Random r = new Random();
            WinAmount = r.Next(15, 150);
            Amount = 0;
            ClickCount = 0;
        }

        public void Reset()
        {
            ClickCount = 0;
            Amount = 0;
        }

        public int SetPlusOne()
        {
            return Amount++;
        }

        public int SetDoubled()
        {
            Amount *= 2;
            return Amount;
        }

        public int SetClickCount()
        {
            return ClickCount++;
        }
    }
}
