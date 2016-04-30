using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGameKata
{
    public class Game
    {

        public static int GetScore(List<int> pins)
        {
            int score = 0;
            for (int i = 0; i < pins.Count;i++ )
            {
                if (pins[i] == 10)
                    score = pins[i] + pins[i + 2] + pins[i + 3];
                else
                    score += pins[i];
            }

            return score;
        }
    }
}
