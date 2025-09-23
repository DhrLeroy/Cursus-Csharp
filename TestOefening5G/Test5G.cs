namespace TestOefening5G
{
    [TestClass]
    public sealed class Test5G
    {
        [TestMethod]
        public void TestMethod4_7_2()
        {
            TestHelper.HelperMethods.AssertOutputs("Zijde 1: Zijde 2: Zijde 3: Deze zijden vormen geen driehoek.", "4", "7", "2");
        }
        [TestMethod]
        public void TestMethod4_5_2()
        {
            TestHelper.HelperMethods.AssertOutputs("Zijde 1: Zijde 2: Zijde 3: Deze zijden vormen een driehoek.", "4", "5", "2");
        }
    }
}
