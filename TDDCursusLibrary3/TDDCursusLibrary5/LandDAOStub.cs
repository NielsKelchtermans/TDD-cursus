using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class LandDAOStub : ILandDAO
    {
        public Land Read(string landcode)
        {
            return new Land { Landcode = landcode, Oppervlakte = 5 };
        }
        public int OppervlakteAlleLanden()
        {
            return 20;
        }
    }
}
