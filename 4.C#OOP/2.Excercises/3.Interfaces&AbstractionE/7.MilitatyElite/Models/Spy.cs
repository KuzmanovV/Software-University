using System;
using System.Collections.Generic;
using System.Text;
using _7.MilitatyElite.Contracts;

namespace _7.MilitatyElite.Models
{
    class Spy: Soldier,ISpy
    {
        public Spy(
            string id, 
            string firstName,
            string lastName,
            int codeNumber) 
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }
        public override string ToString()
        {
            return base.ToString()
                   +Environment.NewLine
                   +$"Code Number: {CodeNumber}";
        }
    }
}
