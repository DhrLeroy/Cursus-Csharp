namespace TestOefening1C
{
    [TestClass]
    public sealed class Test1C
    {
        [TestMethod]
        public void TestJohnTheLastofUs()
        {
            TestHelper.HelperMethods.AssertOutputs(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "John speelt graag The Last of Us!");
        }
    }
}
