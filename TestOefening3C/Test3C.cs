using TestHelper;

namespace TestOefening3C
{
    [TestClass]
    public sealed class Test3C
    {
        [TestMethod]
        public void TestShiroGeorgeZazu()
        {
            HelperMethods.AssertOutputs("Geef een naam van jouw huisdier op: Geef een naam van jouw huisdier op: Geef een naam van jouw huisdier op: Jouw huisdieren zijn: Shiro George Zazu", "Shiro", "George", "Zazu");
        }
        [TestMethod]
        public void TestDogCatFish()
        {
            HelperMethods.AssertOutputs("Geef een naam van jouw huisdier op: Geef een naam van jouw huisdier op: Geef een naam van jouw huisdier op: Jouw huisdieren zijn: Dog Cat Fish", "Dog", "Cat", "Fish");
        }
    }
}
