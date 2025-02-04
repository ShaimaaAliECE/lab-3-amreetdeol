﻿using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Collectable : Displayable
    {

        public string Description { get; set; }
        internal CollectionBoard Board { get; set; }

        protected Collectable(string description)
        {
            Description = description;
        }
        public virtual void AddMe(List<Collectable> list) { }

        public virtual void Display() { }

    }
}

