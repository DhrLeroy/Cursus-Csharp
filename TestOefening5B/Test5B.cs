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
        public void Test15_0()
        {
            HelperMethods.AssertOutputs("Beste optie: Pizzeria Don Corleone voor 187,5 euro.", "15", "0");
        }
        [TestMethod]
        public void Test80_0()
        {
            HelperMethods.AssertOutputs("Beste optie: Pizzeria Scaletta voor 832 euro.", "80", "0");
        }
        [TestMethod]
        public void Test80_800()
        {
            HelperMethods.AssertOutputs("Beste optie: Pizzeria Don Corleone voor 1000 euro.", "80", "800");
        }
    }
}
