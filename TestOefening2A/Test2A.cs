namespace TestOefening2A
{
    [TestClass]
    public sealed class Test2A
    {
        [TestMethod]
        public void Test32()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef a in: Geef b in: Som: 3 + 2 = 5\r\nVerschil: 3 - 2 = 1\r\nProduct: 3 x 2 = 6\r\nQuotiënt: 3 / 2 = 1,5", "3", "2");//
        }
        [TestMethod]
        public void Test41()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef a in: Geef b in: Som: 4 + 1 = 5\r\nVerschil: 4 - 1 = 3\r\nProduct: 4 x 1 = 4\r\nQuotiënt: 4 / 1 = 4", "4", "1");//
        }
    }
}
