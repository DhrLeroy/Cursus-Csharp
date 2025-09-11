using TestHelper;

namespace TestOefening3G
{
    [TestClass]
    public sealed class Test3G
    {
        [TestMethod]
        public void TestSlechtOkéBest()
        {
            HelperMethods.AssertOutputs("Aantal films: Titel film (van slecht naar goed): Titel film (van slecht naar goed): Titel film (van slecht naar goed): 1. Best\r\n2. Oke\r\n3. Slecht", "3", "Slecht", "Oke", "Best");
        }
        [TestMethod]
        public void TestSuperSlechtSlechtOkéBesteOoit()
        {
            HelperMethods.AssertOutputs("Aantal films: Titel film (van slecht naar goed): Titel film (van slecht naar goed): Titel film (van slecht naar goed): Titel film (van slecht naar goed): 1. Beste ooit\r\n2. Oke\r\n3. Slecht\r\n4. Super slecht", "4","Super slecht", "Slecht", "Oke", "Beste ooit");
        }
    }
}
