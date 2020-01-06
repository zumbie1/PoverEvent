using System;
using System.Collections.Generic;
using System.Text;

namespace ScoreV2.Models
{
    public class Person
    {
        public string Name { get; set; }

        public int TeamNumb{ get; set; }

        public override string ToString()
        {
            return Name + " " + TeamNumb;
        }
    }
}
