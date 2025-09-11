namespace TestOefening3E
{
    [TestClass]
    public sealed class Test3E
    {
        [TestMethod]
        public void TestMethodEierenMelkBloem()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef een ingrediënt: Geef een ingrediënt: Geef een ingrediënt: 1. Eieren\r\n2. Melk\r\n3. Bloem", "Eieren", "Melk", "Bloem");
        }
        [TestMethod]
        public void TestPizzadeegTomatensausMozarella()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef een ingrediënt: Geef een ingrediënt: Geef een ingrediënt: 1. Pizzadeeg\r\n2. Tomatensaus\r\n3. Mozarella", "Pizzadeeg", "Tomatensaus", "Mozarella");
        }
    }
}
