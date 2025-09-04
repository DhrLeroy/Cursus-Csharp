namespace TestOefening1B
{
    [TestClass]
    public sealed class Test1B
    {
        [TestMethod]
        public void TestHelloJohn()
        {
            TestHelper.HelperMethods.AssertOutputs(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "Hallo John!");
        }
    }
}
