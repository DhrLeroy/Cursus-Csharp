using TestHelper;

namespace TestOefening2B1
{
    [TestClass]
    public sealed class Test2B1
    {
        [TestMethod]
        public void Test2B1_1komma5()
        {
            HelperMethods.AssertOutputs("x: Functiewaarde x^2+2x-3 = 2,25", "1,5");
        }
        [TestMethod]
        public void Test2B1_4()
        {
            HelperMethods.AssertOutputs("x: Functiewaarde x^2+2x-3 = 21", "4");
        }
    }
}
