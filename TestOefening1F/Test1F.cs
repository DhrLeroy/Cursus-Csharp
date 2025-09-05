using TestHelper;

namespace TestOefening1F
{
    [TestClass]
    public sealed class Test1F
    {
        [TestMethod]
        public void TestFavorieteHuisdierGeorge()
        {
            HelperMethods.AssertOutputs("Wat is jouw favoriete huisdier? Ik hou zo van George.", "George");
        }
    }
}
