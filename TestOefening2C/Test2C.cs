namespace TestOefening2C
{
    [TestClass]
    public sealed class Test2C
    {
        [TestMethod]
        public void Test2C_1m80_70kg()
        {
            TestHelper.HelperMethods.AssertOutputs("BMI = 21,60494", "1,80", "70");
        }
        [TestMethod]
        public void Test2C_1m65_80komma5kg()
        {
            TestHelper.HelperMethods.AssertOutputs("BMI = 29,568413", "1,65", "80,5");
        }
    }
}
