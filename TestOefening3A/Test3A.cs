using TestHelper;

namespace TestOefening3A
{
    [TestClass]
    public sealed class Test3A
    {
        [TestMethod]
        public void Test12345()
        {
            HelperMethods.AssertOutputs("Geef een getal in: Geef een getal in: Geef een getal in: Geef een getal in: Geef een getal in: 1\r\n2\r\n3\r\n4\r\n5", "1", "2", "3", "4", "5");
        }
        [TestMethod]
        public void Test108642()
        {
            HelperMethods.AssertOutputs("Geef een getal in: Geef een getal in: Geef een getal in: Geef een getal in: Geef een getal in: 10\r\n8\r\n6\r\n4\r\n2", "10", "8", "6", "4", "2");
        }
    }
}
