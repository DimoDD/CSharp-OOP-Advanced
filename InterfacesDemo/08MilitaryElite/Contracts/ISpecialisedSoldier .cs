using System;
using System.Collections.Generic;
using System.Text;
using _08MilitaryElite.Enums;

namespace _08MilitaryElite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
