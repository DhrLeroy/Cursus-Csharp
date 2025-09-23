using TestHelper;

namespace TestOefening5E
{
    [TestClass]
    public sealed class Test5E
    {
        [TestMethod]
        public void Test3()
        {
            HelperMethods.AssertOutputs("Aantal: Totaal: 18 euro", "3");
        }
        [TestMethod]
        public void Test4()
        {
            HelperMethods.AssertOutputs("Aantal: Totaal: 20 euro", "4");
        }
        [TestMethod]
        public void Test5()
        {
            HelperMethods.AssertOutputs("Aantal: Totaal: 25 euro", "5");
        }
        [TestMethod]
        public void Testmin2_0_2()
        {
            HelperMethods.AssertOutputs("Aantal: Aantal: Aantal: Totaal: 13 euro", "-2","0","2");
        }
    }
}
