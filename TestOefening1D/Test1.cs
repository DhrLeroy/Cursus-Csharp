namespace TestOefening1D
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMaytheForcebewithyoudot()
        {
            TestHelper.HelperMethods.AssertOutputs(System.Reflection.Assembly.GetExecutingAssembly().GetName().Name, "Mijn favoriete quote: \"May the Force be with you.\"");
        }
    }
}
