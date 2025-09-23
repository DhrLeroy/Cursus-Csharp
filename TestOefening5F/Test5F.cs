using TestHelper;

namespace TestOefening5F
{
    [TestClass]
    public sealed class Test5F
    {
        [TestMethod]
        public void Test1()
        {
            HelperMethods.AssertOutputs("Leeftijd hond: Mensenjaren: 15", "1");
        }
        [TestMethod]
        public void Test2()
        {
            HelperMethods.AssertOutputs("Leeftijd hond: Mensenjaren: 24", "2");
        }
        [TestMethod]
        public void Test3()
        {
            HelperMethods.AssertOutputs("Leeftijd hond: Mensenjaren: 29", "3");
        }
        [TestMethod]
        public void Test4()
        {
            HelperMethods.AssertOutputs("Leeftijd hond: Mensenjaren: 34", "4");
        }
    }
}
