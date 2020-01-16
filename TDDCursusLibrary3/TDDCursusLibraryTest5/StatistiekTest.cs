using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class StatistiekTest
    {
        [TestMethod]
        public void HetGemiddeldeVan10en15is12punt5()
        {

            Assert.AreEqual(12.5m, Statistiek.Gemiddelde(new decimal[] { 10, 15 }));
        }
        [TestMethod]
        public void HetGemiddeldeVanEenGetalIsDatGetal()
        {
            var getal = 1.23m;
            Assert.AreEqual(getal, Statistiek.Gemiddelde(new decimal[] { getal }));
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void HetGemiddeldeVanEenLegeVerzamelingKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(new decimal[] { });
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void HetGemiddeldeVanNullKanJeNietBerekenen()
        {
            Statistiek.Gemiddelde(null);
        }

    }

}
