using System;
using System.Collections.Generic;
using System.Text;

namespace _08MilitaryElite
{
    public interface ISoldier
    {
        //id, first name and last name
        int Id { get; }

        string FirstName { get; }

        string LastName { get; }
    }
}
