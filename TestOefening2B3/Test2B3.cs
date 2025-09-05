namespace TestOefening2B3
{
    [TestClass]
    public sealed class Test2B3
    {
        [TestMethod]
        public void Test2B3_1komma5()
        {
            TestHelper.HelperMethods.AssertOutputs("x: Functiewaarde x^5-x^4 = 2,53125", "1,5");
        }
        [TestMethod]
        public void Test2B3_4()
        {
            TestHelper.HelperMethods.AssertOutputs("x: Functiewaarde x^5-x^4 = 768", "4");
        }
    }
}
