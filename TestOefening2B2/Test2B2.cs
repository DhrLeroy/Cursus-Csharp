namespace TestOefening2B2
{
    [TestClass]
    public sealed class Test2B2
    {
        [TestMethod]
        public void Test2B2_1komma5()
        {
            TestHelper.HelperMethods.AssertOutputs("x: Functiewaarde x^4-3x^3+1x/4-9 = -13,6875", "1,5");
        }
        [TestMethod]
        public void Test2B2_4()
        {
            TestHelper.HelperMethods.AssertOutputs("x: Functiewaarde x^4-3x^3+1x/4-9 = 56", "4");
        }
    }
}
