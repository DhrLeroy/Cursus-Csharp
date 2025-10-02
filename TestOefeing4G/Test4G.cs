using System.Reflection.Emit;
using TestHelper;

namespace TestOefeing4G
{
    [TestClass]
    public sealed class Test4G
    {
        [TestMethod]
        public void Testappel_lepel_negen_acht()
        {
            HelperMethods.AssertOutputs("Woorden: appel: False\r\nLepel: True\r\nnegen: True\r\nacht: False", "appel Lepel negen acht");
        }
        [TestMethod]
        public void Testvrachtwagen__auto()
        {
            HelperMethods.AssertOutputs("Woorden: Vrachtwagen: False\r\nauto: False", "Vrachtwagen  auto");
        }
    }
}
