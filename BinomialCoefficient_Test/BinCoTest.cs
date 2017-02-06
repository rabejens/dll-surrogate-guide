using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinomialCoefficient_Test {
    [TestClass]
    public class BinCoTest {

        [TestMethod]
        public void BinCoIsCorrect() {
            var bc = new BinomialCoefficient.BinomialCoefficient();
            Assert.AreEqual((ulong)10, bc.BinCo(5, 3));
        }
    }
}
