using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary
{
    public class LandService
    {
        //interface type ipv een object aan te maken van LandDao
        private readonly ILandDAO landDAO;
        //constructor nodig om landDAO een effectief object te geven want anders null
        public LandService(ILandDAO landDAO)
        {
            this.landDAO = landDAO;
        }
        public decimal FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden(string landcode)
        {
            throw new NotImplementedException();
        }
    }
}
