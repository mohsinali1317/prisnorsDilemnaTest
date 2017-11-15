using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrisnorsDilemna
{
    public enum Strategy
    {
        AlwaysDefect = 0,
        AlwaysCoperate = 1,
        TitForTat = 2
    }

    public enum Move
    {
        Defect = 0,
        Coperate = 1
    }



    public class Player
    {
        public string Name;
        public double Score;

        public Strategy Strategy;

        public List<Move> Moves;

        public Player(string name, double score, Strategy strategy)
        {
            Name = name;
            Score = score;
            Strategy = strategy;
            Moves = new List<Move>();
        }


        public void AddMove(Move move)
        {
            Moves.Add(move);
        }

        internal Move DoMove(Player otherPlayer)
        {
            Move m = Move.Coperate;
            switch (Strategy)
            {
                case Strategy.TitForTat:
                    if (otherPlayer.Moves.Count == 0)
                    {
                        // add a random thing here to select move
                        Move value = Helper.RandomEnumValue<Move>();
                        AddMove(value);
                        m = value;
                    }
                    else
                    {
                        m = otherPlayer.Moves.Last();
                        AddMove(m);
                    }
                    break;
                case Strategy.AlwaysDefect:
                    m = Move.Defect;
                    AddMove(m);
                     
                    break;
                case Strategy.AlwaysCoperate:
                    m = Move.Coperate;
                    AddMove(m);
                    break;
            }

            return m;
        }
    }
}
