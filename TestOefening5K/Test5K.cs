namespace TestOefening5K
{
    [TestClass]
    public sealed class Test5K
    {
        [TestMethod]
        public void Test2()
        {
            TestHelper.HelperMethods.AssertOutputs("Aantal seconden tussen bliksem en donder: De blikseminslag was 0.686 km van je verwijderd.", "2");

        }
        [TestMethod]
        public void Test4()
        {
            TestHelper.HelperMethods.AssertOutputs("Aantal seconden tussen bliksem en donder: De blikseminslag was 1.372 km van je verwijderd.", "4");

        }
        [TestMethod]
        public void Testmin1()
        {
            TestHelper.HelperMethods.AssertOutputs("Aantal seconden tussen bliksem en donder: Donder kan niet voor bliksem komen.", "-1");

        }
    }
}
