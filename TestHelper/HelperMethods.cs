using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace TestHelper
{
    public static class HelperMethods
    {
        public static void AssertOutputs(string assemblyName, string expected, params string[] input)
        {
            var inputString = new StringReader(string.Join("\n", input));
            Console.SetIn(inputString);

            var sw = new StringWriter();
            var originalOut = Console.Out;
            Console.SetOut(sw);

            try
            {
                // Act: invoke the top-level statements
                // Top-level statements in .NET 6+ generate a hidden Program.Main method.
                var assembly = Assembly.Load(assemblyName.Substring(4)); // replace with your assembly name
                var entryPoint = assembly.EntryPoint;
                entryPoint.Invoke(null, entryPoint.GetParameters().Length == 0 ? null : new object[] { Array.Empty<string>() });

                // Assert
                var output = sw.ToString();
                StringAssert.Contains(output.Trim(), expected.Trim());
            }
            finally
            {
                Console.SetOut(originalOut);
            }
        }
    }
}
