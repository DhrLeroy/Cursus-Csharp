namespace TestOefening8A
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Test15januari2024()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef uw geboortedatum in.\nDag: Maand: Jaar: 1 jaar", "15", "1", "2024");
        }
        [TestMethod]
        public void Test29februari2000()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef uw geboortedatum in.\nDag: Maand: Jaar: 1 jaar.", "29", "2", "2000");
        }
        [TestMethod]
        public void TestverjaartMorgen()
        {
            var morgen = DateTime.Today.AddDays(1);
            var jaartal = 1999;
            TestHelper.HelperMethods.AssertOutputs($"Geef uw geboortedatum in.\nDag: Maand: Jaar: {DateTime.Today.Year - jaartal - 1} jaar", $"{morgen.Day}", $"{morgen.Month}", $"{jaartal}");
        }
        [TestMethod]
        public void TestverjaartGisteren()
        {
            var gisteren = DateTime.Today.AddDays(-1);
            var jaartal = 1999;
            TestHelper.HelperMethods.AssertOutputs($"Geef uw geboortedatum in.\nDag: Maand: Jaar: {DateTime.Today.Year - jaartal} jaar", $"{gisteren.Day}", $"{gisteren.Month}", $"{jaartal}");
        }
        [TestMethod]
        public void Test31december1980()
        {
            TestHelper.HelperMethods.AssertOutputs("Geef uw geboortedatum in.\nDag: Maand: Jaar: 44 jaar", "31", "12", "1980");
        }
    }
}
