namespace TestOefening5C
{
    [TestClass]
    public sealed class Test5C
    {
        [TestMethod]
        public void sTest0()
        {
            TestHelper.HelperMethods.AssertOutputs("0 is geen priemgetal.", "0");
        }
        [TestMethod]
        public void Test1()
        {
            TestHelper.HelperMethods.AssertOutputs("1 is geen priemgetal.", "1");
        }
        [TestMethod]
        public void Test4()
        {
            TestHelper.HelperMethods.AssertOutputs("4 is geen priemgetal.", "4");
        }
        [TestMethod]
        public void Test5()
        {
            TestHelper.HelperMethods.AssertOutputs("5 is een priemgetal.", "5");
        }
        [TestMethod]
        public void Test40()
        {
            TestHelper.HelperMethods.AssertOutputs("40 is geen priemgetal.", "40");
        }
        [TestMethod]
        public void Test101()
        {
            TestHelper.HelperMethods.AssertOutputs("101 is een priemgetal.", "101");
        }
    }
}
