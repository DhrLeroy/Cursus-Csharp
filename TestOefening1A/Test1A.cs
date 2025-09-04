using System.Reflection;

namespace TestOefening1A
{
    [TestClass]
    public sealed class Test1A
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            TestHelper.HelperMethods.AssertOutputs("Hello world!");
        }
    }
}
