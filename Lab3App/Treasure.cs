using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            Board.UpdateTotalScore(Score);
        }

        protected Treasure(string description, int score) : base(description)
        {
            Score = +score;
        }

        
    }
}

