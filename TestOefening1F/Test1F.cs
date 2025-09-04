using TestHelper;

namespace TestOefening1F
{
    [TestClass]
    public sealed class Test1F
    {
        [TestMethod]
        public void TestFavorieteHuisdierGeorge()
        {
            HelperMethods.AssertOutputs("Wat is jouw favoriete huisdier? \nIk hou zo van George.", "George");
        }
    }
}
