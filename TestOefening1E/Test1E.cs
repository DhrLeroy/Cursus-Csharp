namespace TestOefening1E
{
    [TestClass]
    public sealed class Test1E
    {
        [TestMethod]
        public void TestIkzeitegenhemIkbeljesavonds()
        {
            TestHelper.HelperMethods.AssertOutputs("Ik zei tegen hem: \"Ik bel je 's avonds\"");
        }
    }
}
