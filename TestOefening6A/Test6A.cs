using TestHelper;

namespace TestOefening6A
{
    [TestClass]
    public sealed class Test6A
    {
        [TestMethod]
        public void Test1235()
        {
            HelperMethods.AssertOutputs("Getal: Getal: Getal: Getal: Getal: Macht 1: 1\r\nMacht 2: 4\r\nMacht 3: 9\r\nMacht 5: 25");
        }
        [TestMethod]
        public void Testmin570()
        {
            HelperMethods.AssertOutputs("Getal: Getal: Getal: Getal: Macht -5: 25\r\nMacht 7: 49\r\nMacht 0: 0");
        }
    }
}
