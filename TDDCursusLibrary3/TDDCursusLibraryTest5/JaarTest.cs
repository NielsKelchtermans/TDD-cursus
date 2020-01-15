using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDCursusLibrary;


namespace TDDCursusLibraryTest
{
    [TestClass]
    public class JaarTest
    {
        [TestMethod] // (2)
        public void EenJaarDeelbaarDoor400IsEenSchrikkeljaar() // (3)
        {
            //Assert.AreEqual(true, new Jaar(2000).IsSchrikkeljaar); // (4)
            Assert.IsTrue(new Jaar(2000).IsSchrikkeljaar);
        }

        [TestMethod]
        public void EenJaarDeelbaarDoor100MaarNietDoor400IsGeenSchrikkeljaar()
        {
            //Assert.AreEqual(false, new Jaar(1900).IsSchrikkeljaar);
            Assert.IsFalse(new Jaar(1900).IsSchrikkeljaar);
        }
        [TestMethod]
        public void EenJaarDeelbaarDoor4IsEenSchrikkeljaar()
        {
            //Assert.AreEqual(true, new Jaar(2012).IsSchrikkeljaar);
            Assert.IsTrue(new Jaar(2012).IsSchrikkeljaar);
        }
        [TestMethod]
        public void EenJaarNietDeelbaarDoor4IsGeenSchrikkeljaar()
        {
            //Assert.AreEqual(false, new Jaar(2015).IsSchrikkeljaar);
            Assert.IsFalse(new Jaar(2015).IsSchrikkeljaar);
        }
    }

}
