using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;
using Moq;


namespace TDDCursusLibraryTest
{
    [TestClass]
    public class LandServiceTest
    {
        private ILandDAO landDAO;           //stub
        private LandService landService;    //te testen class

        private Mock<ILandDAO> mockFactory; //mock using moq
        [TestInitialize]
        public void Initialize()
        {
            // landDAO = new LandDAOStub();         //stub mag nu weg door Mock
            mockFactory = new Mock<ILandDAO>();     //een mockobject wordt aangemaakt
            landDAO = mockFactory.Object;           //een mockobject met property object.

            //trainen van de class
            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden()).Returns(20);

            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).
                Returns(new Land { Landcode = "B", Oppervlakte = 5 });
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("NL")).Returns(new Land { Landcode = "NL",
                Oppervlakte = 10 });
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read(string.Empty)).Throws(new ArgumentException());


            landService = new LandService(landDAO);

        }
        [TestMethod]
        public void FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.FindVerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
            mockFactory.Verify(eenLandDAO => eenLandDAO.OppervlakteAlleLanden());
            
        }

    }
}
