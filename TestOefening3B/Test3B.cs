using TestHelper;

namespace TestOefening3B
{
    [TestClass]
    public sealed class Test3B
    {
        [TestMethod]
        public void Test123()
        {
            HelperMethods.AssertOutputs("Geef een getal in: Geef een getal in: Geef een getal in: Som = 6", "1", "2", "3");
        }
        [TestMethod]
        public void Test863()
        {
            HelperMethods.AssertOutputs("Geef een getal in: Geef een getal in: Geef een getal in: Som = 17", "8", "6", "3");
        }
        [TestMethod]
        public void Test12min3()
        {
            HelperMethods.AssertOutputs("Geef een getal in: Geef een getal in: Geef een getal in: Som = 0", "1", "2", "-3");
        }
    }
}
