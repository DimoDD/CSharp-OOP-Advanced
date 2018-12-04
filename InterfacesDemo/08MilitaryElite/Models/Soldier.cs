using System;
using System.Collections.Generic;
using System.Text;

namespace _08MilitaryElite.Contracts.Models
{
    public class Soldier : ISoldier
    {
        private int id;

        public int Id
        {
            get => this.id;
            private set => this.id=value;
        }
        
    }
}
