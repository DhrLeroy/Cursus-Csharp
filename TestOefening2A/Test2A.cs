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
    }
}
