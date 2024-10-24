﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_Classes_Structs_OOP_code
{
    internal class Dude
    {
        public string name;
        public int experience = 0;

        public Dude(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Dude: " + this.name + " - " + this.experience + " EXP");
        }

        private void Reset()
        {
            this.name = "Not Assigned";
            this.experience = 0;
        }
    }
}
