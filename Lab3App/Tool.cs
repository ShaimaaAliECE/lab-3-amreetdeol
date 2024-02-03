using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description) { }


        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
        }
        public virtual void DoAction()
        {

        }
    }
}

