namespace TestOefening1G
{
    [TestClass]
    public sealed class Test1G
    {
        [TestMethod]
        public void TestJohnBacktotheFuture()
        {
            TestHelper.HelperMethods.AssertOutputs("Naam: Favoriete film: Hallo John, ik kijk ook graag naar Back to the Future.", "John", "Back to the Future");
        }
        [TestMethod]
        public void TestEmmaTheMatrix()
        {
            TestHelper.HelperMethods.AssertOutputs("Naam: Favoriete film: Hallo Emma, ik kijk ook graag naar The Matrix.", "Emma", "The Matrix");
        }
    }
}
