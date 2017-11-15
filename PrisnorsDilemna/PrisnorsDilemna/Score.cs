using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrisnorsDilemna
{
    /*
     * If both coperate 3 points each
     * If both defect 1 point each
     * If A defect and B coperate, A gets 5 and B gets 0
     * and vice versa
     * 
     * */

    public class Score
    {
        public static void GetScore(ref Player P1, ref Player P2)
        {
            Move PlayerOneMove = P1.Moves.Last();
            Move PlayerTwoMove = P2.Moves.Last();


            if(PlayerOneMove == Move.Coperate && PlayerTwoMove == Move.Coperate)
            {
                P1.Score += 3;
                P2.Score += 3;
            }

            else if (PlayerOneMove == Move.Defect && PlayerTwoMove == Move.Defect)
            {
                P1.Score += 1;
                P2.Score += 1;
            }

            else if (PlayerOneMove == Move.Defect && PlayerTwoMove == Move.Coperate)
            {
                P1.Score += 5;
                P2.Score += 0;
            }

            else if (PlayerOneMove == Move.Coperate && PlayerTwoMove == Move.Defect)
            {
                P1.Score += 0;
                P2.Score += 5;
            }

        }
    }
}
