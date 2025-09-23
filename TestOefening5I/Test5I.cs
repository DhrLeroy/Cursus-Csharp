namespace TestOefening5I
{
    [TestClass]
    public sealed class Test5I
    {
        [TestMethod]
        public void Test18()
        {
            TestHelper.HelperMethods.AssertOutputs("Getal: 2 is een deler.\r\n3 is een deler.\r\n3 is een deler.\r\n18 = 2 x 3 x 3.", "18");
        }
        [TestMethod]
        public void Test4()
        {
            TestHelper.HelperMethods.AssertOutputs("Getal: 2 is een deler.\r\n2 is een deler.\r\n4 = 2 x 2.", "4");
        }
    }
}
