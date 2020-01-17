using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;


namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO;           //stub
        private LandService landService;    //te testen class
        [TestInitialize]
        public void Initialize()
        {
            landDAO = new LandDAOStub();
            landService = new LandService(landDAO);
        }
        [TestMethod]
        public void FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));
        }

    }
}
