using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7._2
{
    class GuessTheNumberLogic
    {
        public int TryCount { get; private set; }
        public string Hint { get; private set; }
        public int WinCondition { get; private set; }
        
        public int SetWinCondition()
        {
            Random r = new Random();
            WinCondition = r.Next(1, 100);
            return WinCondition;
        }

        public int SetTryCount()
        {
            TryCount++;
            return TryCount;
        }

        public bool CheckGuess(int guess)
        {
            return guess == WinCondition;
        }

        public string GetHint(int guess, int winCondition)
        {
            int difference = winCondition - guess;
            difference = Math.Abs(difference);

            if (difference <= 99 && difference >= 80)
                return "Очень холодно";
            if (difference <= 79 && difference >= 50)
                return "Холодно";
            if (difference <= 49 && difference >= 30)
                return "Тепло";
            if (difference <= 29 && difference >= 10)
                return "Горячо";
            if (difference <= 9 && difference >= 1)
                return "Очень горячо";

            return "Загаданое число от 1 до 100";
        }
    }
}
