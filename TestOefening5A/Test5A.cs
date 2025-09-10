namespace TestOefening5A
{
    [TestClass]
    public sealed class Test5A
    {
        [TestMethod]
        public void Testhelloatworlddotcom()
        {
            TestHelper.HelperMethods.AssertOutputs("E-mailadres: E-mailadres gevalideerd", "hello@world.com");
        }
        [TestMethod]
        public void Testhelloatworlddotc()
        {
            TestHelper.HelperMethods.AssertOutputs("E-mailadres: E-mailadres heeft geen geldig einde\r\nE-mailadres: E-mailadres gevalideerd", "hello@world.c", "hello@world.com");
        }
        [TestMethod]
        public void Testhellworldcom()
        {
            TestHelper.HelperMethods.AssertOutputs("E-mailadres: E-mailadres heeft geen geldig einde\r\nE-mailadres: E-mailadres gevalideerd", "hello@world.c", "hello@world.com");
        }

    }
}
