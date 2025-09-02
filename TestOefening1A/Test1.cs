using System.Reflection;

namespace TestOefening1A
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestHelloWorld()
        {
            TestHelper.HelperMethods.AssertOutputs(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "Hello world!");
        }
    }
}
