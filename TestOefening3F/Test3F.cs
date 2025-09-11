namespace TestOefening3F
{
    [TestClass]
    public sealed class Test3F
    {
        [TestMethod]
        public void Test6()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef een getal in: 6\r\n12\r\n18\r\n24\r\n30\r\n36\r\n42\r\n48\r\n54\r\n60\r\n3\r\n6\r\n9\r\n12\r\n15\r\n18\r\n21\r\n24\r\n27\r\n30", "6");
        }
        [TestMethod]
        public void Test7()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef een getal in: 7\r\n14\r\n21\r\n28\r\n35\r\n42\r\n49\r\n56\r\n63\r\n70\r\n3,5\r\n7\r\n10,5\r\n14\r\n17,5\r\n21\r\n24,5\r\n28\r\n31,5\r\n35", "7");
        }
    }
}
