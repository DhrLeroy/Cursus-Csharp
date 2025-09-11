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
        public void Testhelloworlddotcom()
        {
            TestHelper.HelperMethods.AssertOutputs("E-mailadres: Geen @-teken in het e-mailadres\r\nE-mailadres: E-mailadres gevalideerd", "helloworld.com", "hello@world.com");
        }
        [TestMethod]
        public void Testhelloatworldcom()
        {
            TestHelper.HelperMethods.AssertOutputs("E-mailadres: E-mailadres heeft geen geldig einde\r\nE-mailadres: E-mailadres gevalideerd", "hello@worldcom", "hello@world.com");
        }
        [TestMethod]
        public void Testhelldotoatworldcom()
        {
            TestHelper.HelperMethods.AssertOutputs("E-mailadres: E-mailadres heeft geen geldig einde\r\nE-mailadres: E-mailadres gevalideerd", "hell.o@worldcom", "hello@world.com");
        }

    }
}
