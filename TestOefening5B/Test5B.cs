using TestHelper;

namespace TestOefening5B
{
    [TestClass]
    public sealed class Test5B
    {
        [TestMethod]
        public void Test30_30()
        {
            HelperMethods.AssertOutputs("Beste optie: allebei hetzelfde voor 375 euro.", "30", "30");
        }
        [TestMethod]
        public void Test15_4()
        {
            HelperMethods.AssertOutputs("Beste optie: allebei hetzelfde voor 375 euro.", "30", "30");
        }
        [TestMethod]
        public void Test80_3()
        {
            HelperMethods.AssertOutputs("Beste optie: allebei hetzelfde voor 375 euro.", "30", "30");
        }
    }
}
